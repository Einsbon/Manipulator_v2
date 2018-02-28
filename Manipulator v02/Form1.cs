using MyoSharp.Communication; // IChannel
using MyoSharp.Device; // IHub
using MyoSharp.Exceptions; // MyoErrorHandlerDriver
using MyoSharp.Poses; // Pose
using OpenJigWare; // Ojw.CMessage
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manipulator_v02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        int x = 140, y = 00, z = 30; //초기 위치
        
        int moveTime = 400;
        int delayTime = 199;

        int l1 = 98; //첫번째 관절 길이, mm
        int l2 = 98; //두번째 관절 길이, mm
        int l3 = 30; //세번째 관절 길이, mm

        int gripperUngrab = 120;//원래는 작은수 (지금 - 붙임)
        int gripperGrab = 80;//원래는 높은수
        bool isGrab;
        Ojw.CHerkulex2 m = new Ojw.CHerkulex2();


        private void btnConnect_Click(object sender, EventArgs e)
        {
            m.Open(Convert.ToInt32(textBoxPort.Text), 115200);
            m.SetTorque(true, true);

            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            x += 20;
            if (!posOK(x,y,z))
            {
                x -= 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            y += 20;
            if (!posOK(x, y, z))
            {
                y -= 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            x -= 20;
            if (!posOK(x, y, z))
            {
                x += 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            y -= 20;
            //if ((Math.Sqrt(x * x + y * y) - l3) * (Math.Sqrt(x * x + y * y) - l3) + z * z >= (l1 + l2) * (l1 + l2))
            //{
            if (!posOK(x, y, z))
            {
                y += 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            z += 20;
            if (!posOK(x, y, z))
            {
                z -= 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }

        private void btnDonw_Click(object sender, EventArgs e)
        {
            z -= 20;
            if (!posOK(x, y, z))
            {
                z += 20;
            }
            InverseKinematicsMove(x, y, z, 1000, 1000);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);

            /*
            m_CGrap = new Ojw.CGraph(lbDisp, lbDisp.Width, Color.White, null,
                Color.Red, Color.Blue, Color.Black,
                Color.Red, Color.Blue, Color.Black);

            InitMyo();

            tmrDraw.Enabled = true;*/
        }


        private void btnIVMove_Click(object sender, EventArgs e)
        {
            int mmx = Convert.ToInt16(txtX.Text);
            int mmy = Convert.ToInt16(txtY.Text);
            int mmz = Convert.ToInt16(txtZ.Text);

            if(posOK(mmx,mmy,mmz) == true)
            {
                x = mmx;
                y = mmy;
                z = mmz;
                InverseKinematicsMove(x, y, z, 3000, 1000);
            }
            else
            {
                MessageBox.Show("범위 이상의 값입니다.");
            }

        }

        void InverseKinematicsMove(double xx, double yy, double az, int time, int delay)
        {
            double ll = Math.Sqrt(xx * xx + yy * yy) - l3;
            double a = Math.Sqrt(ll * ll + az * az);
            double ax = ll * (xx / Math.Sqrt(xx * xx + yy * yy));
            double ay = ll * (yy / Math.Sqrt(xx * xx + yy * yy));
            textBox1.Text = "a: " + Convert.ToString(a);
            textBox1.Text += "\r\nX; " + (Math.Round(xx / .01) * .01) + "\t\t" + (Math.Round(ax / .01) * .01);
            textBox1.Text += "\r\nY; " + (Math.Round(yy / .01) * .01) + "\t\t" + (Math.Round(ay / .01) * .01);
            textBox1.Text += "\r\nZ; " + (Math.Round(az / .01) * .01) + "\t\t" + (Math.Round(az / .01) * .01);

            textBox1.Text += "\r\n\r\n0: " + Convert.ToString((180 / Math.PI) * Math.Atan(ay / ax));
            textBox1.Text += "\r\n1: " + Convert.ToString((180 / Math.PI) * Math.Asin(az / a) + (180 / Math.PI) * Math.Acos((a * a + l1 * l1 - l2 * l2) / (2 * a * l1)));
            textBox1.Text += "\r\n2: " + Convert.ToString((180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - a * a) / (2 * l1 * l2))));
            textBox1.Text += "\r\n3: " + Convert.ToString(180 - ((180 / Math.PI) * Math.Asin(az / a) + (180 / Math.PI) * Math.Acos((a * a + l1 * l1 - l2 * l2) / (2 * a * l1)) + (180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - a * a) / (2 * l1 * l2)))));
            textBox1.Text += "\r\n4: " + Convert.ToString((180 / Math.PI) * Math.Atan(ay / ax)) + "\r\n";

            double m1 = ((180 / Math.PI) * Math.Asin(az / a) + (180 / Math.PI) * Math.Acos((a * a + l1 * l1 - l2 * l2) / (2 * a * l1)));
            double m0 = (180 / Math.PI) * Math.Atan(ay / ax);
            double m2 = -180 + (180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - a * a) / (2 * l1 * l2)));
            double m3 = 180 - (180 / Math.PI) * Math.Asin(az / a) - (180 / Math.PI) * Math.Acos((a * a + l1 * l1 - l2 * l2) / (2 * a * l1)) - (180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - a * a) / (2 * l1 * l2)));
            double m4 = (180 / Math.PI) * Math.Atan(ay / ax);

            textBox1.Text += "\r\n\r\nm0:" + Convert.ToString(m0);
            textBox1.Text += "\r\nm1:" + Convert.ToString(m1);
            textBox1.Text += "\r\nm2:" + Convert.ToString(m2);
            textBox1.Text += "\r\nm3:" + Convert.ToString(m3);
            textBox1.Text += "\r\nm4:" + Convert.ToString(m4);
            if (ax < 0 & ay < 0)
            {
                m0 -= 180;
                m4 -= 180;
            }
            if (ax < 0 & ay >= 0)
            {
                m0 += 180;
                m4 += 180;
            }
            if (ax == 0 & ay == 0)
            {
                m0 = 0;
                m4 = 0;
            }

            m1 += a / 40;

            m.Set_Angle(0, (int)m0);
            m.Set_Angle(11, (int)m1);
            m.Set_Angle(1, -(int)m1+90);
            m.Set_Angle(2, -(int)m2);
            m.Set_Angle(3, -(int)m3);
            m.Set_Angle(4, (int)m4);
            m.Send_Motor(time);
            m.Wait_Delay(delay);
        }

        private bool posOK(double px, double py, double pz)
        {
            double pl = Math.Sqrt(px * px + py * py) - l3;
            double pa = Math.Sqrt(pl * pl + pz * pz);
            double pax = pl * (px / Math.Sqrt(px * px + py * py));
            double pay = pl * (py / Math.Sqrt(px * px + py * py));

            double mm1 = ((180 / Math.PI) * Math.Asin(pz / pa) + (180 / Math.PI) * Math.Acos((pa * pa + l1 * l1 - l2 * l2) / (2 * pa * l1)));
            double mm0 = (180 / Math.PI) * Math.Atan(pay / pax);
            double mm2 = -180 + (180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - pa * pa) / (2 * l1 * l2)));
            double mm3 = 180 - (180 / Math.PI) * Math.Asin(pz / pa) - (180 / Math.PI) * Math.Acos((pa * pa + l1 * l1 - l2 * l2) / (2 * pa * l1)) - (180 / Math.PI) * (Math.Acos((l1 * l1 + l2 * l2 - pa * pa) / (2 * l1 * l2)));
            double mm4 = (180 / Math.PI) * Math.Atan(pay / pax);
            if (pax < 0 & pay < 0)
            {
                mm0 -= 180;
                mm4 -= 180;
            }
            if (pax < 0 & pay >= 0)
            {
                mm0 += 180;
                mm4 += 180;
            }
            if (pax == 0 & pay == 0)
            {
                mm0 = 0;
                mm4 = 0;
            }
            mm1 += a / 50;
            mm4 += a / 50;
            if (mm0 < -90 | mm0 > 90 | mm1 < -120 | mm1 > 120 | mm2 < -160 | mm2 > 160 | mm3 < -100 | mm3 > 150 | mm4 < -300 | mm4 > 300 | (pa>l1+l2-5) | px <= 0 | pz < -30)
            {
                return false;
            }
            else { return true; }
        }

        int grabberAngle = 5;
        void gripperMove(bool grabOK)
        {
            if (grabOK)
            {
                grabberAngle += -5;
                if (grabberAngle > gripperGrab | grabberAngle < gripperUngrab)
                {
                    grabberAngle -= -5;
                }
            }
            else
            {
                grabberAngle -= -5;
                if (grabberAngle> gripperGrab | grabberAngle < gripperUngrab)
                {
                    grabberAngle += -5;
                }
            }
            m.Set_Angle(5, grabberAngle);
        }

        private IChannel m_myoChannel;
        private IHub m_myoHub;
        private IHeldPose m_myoPos;

        private void InitMyo()
        {
            #region Step1
            // For Message
            Ojw.CMessage.Init(txtMessage);

            m_myoChannel = Channel.Create(ChannelDriver.Create(ChannelBridge.Create(), MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));
            m_myoHub = Hub.Create(m_myoChannel);

            // 이벤트 등록            
            m_myoHub.MyoConnected += new EventHandler<MyoEventArgs>(myoHub_MyoConnected); // 접속했을 때 myoHub_MyoConnected() 함수가 동작하도록 등록
            m_myoHub.MyoDisconnected += new EventHandler<MyoEventArgs>(myoHub_MyoDisconnected); // 접속했을 때 myoHub_MyoDisconnected() 함수가 동작하도록 등록

            #endregion Step1

            // start listening for Myo data
            m_myoChannel.StartListening();
            Ojw.CMessage.Write("Form Loaded...");
        }

        private void Myo_PoseChanged(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("{0} arm Myo detected {1} pose!", e.Myo.Arm, e.Myo.Pose);
            if (e.Myo.Arm == Arm.Left)
            {
                Ojw.CMessage.Write("왼팔의 Myo 가 동작시 키실 동작을 여기에 넣는다.");
            }
            else if (e.Myo.Arm == Arm.Right)
            {
                Ojw.CMessage.Write("오른팔의 Myo 가 동작시 키실 동작을 여기에 넣는다.");
            }
            pose = Convert.ToString(e.Myo.Pose);
        }
        string pose = " ";

        private void DInitMyo()
        {
            try
            {

                m_myoChannel.StopListening();

                m_myoHub.Dispose();
                m_myoChannel.Dispose();
            }
            catch
            {

            }
        }
        private int[] m_anHandle = new int[2];
        //private bool[] m_abHandle = new bool[2];
        private int m_nCnt_Handle = 0;
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}] has connected!", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);
            //m_abHandle[m_nCnt_Handle] = true;
            m_anHandle[m_nCnt_Handle] = e.Myo.Handle.ToInt32();
            e.Myo.Vibrate(VibrationType.Short); // 접속에 성공했으니 짧게 진동 출력

            #region Sensor
            e.Myo.AccelerometerDataAcquired += Myo_AccelerometerDataAcquired;
            e.Myo.GyroscopeDataAcquired += Myo_GyroscopeDataAcquired;
            //e.Myo.OrientationDataAcquired += Myo_OrientationDataAcquired;
            #endregion Sensor
            #region Pose(Edge - 자세가 변하는 순간에만 기록)
            e.Myo.PoseChanged += Myo_PoseChanged;
            e.Myo.Unlock(UnlockType.Hold);
            #endregion Pose(Edge - 자세가 변하는 순간에만 기록)
            m_nCnt_Handle++;
        }
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}]접속해제", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);
            m_nCnt_Handle = 0;
            //m_abHandle[0] = false;
            //m_abHandle[1] = false;
            #region Sensor
            e.Myo.AccelerometerDataAcquired -= Myo_AccelerometerDataAcquired;
            e.Myo.GyroscopeDataAcquired -= Myo_GyroscopeDataAcquired;
            e.Myo.PoseChanged -= Myo_PoseChanged;
            //e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
            #endregion Sensor
            e.Myo.Lock();

        }
        #region Acc
        private float[] m_afAcc = new float[3];


        private void Myo_AccelerometerDataAcquired(object sender, AccelerometerDataEventArgs e)
        {
            //float fMulti = 10.0f;
            //m_CGrap.Push((int)Math.Round(e.Accelerometer.X * fMulti), (int)Math.Round(e.Accelerometer.Y * fMulti), (int)Math.Round(e.Accelerometer.Z * fMulti));
            if (m_anHandle[0] == e.Myo.Handle.ToInt32())
            {
                m_afAcc[0] = e.Accelerometer.X;// / 57.1f * 90.0f;
                m_afAcc[1] = e.Accelerometer.Y;// / 57.1f * 90.0f;
                m_afAcc[2] = e.Accelerometer.Z;/// 57.1f * 90.0f;
                if (m_CTIdAcc.Get() >= 200)
                {
                    m_CTIdAcc.Set();
                    float[] afAngle = new float[3];
                    afAngle[0] = (float)Ojw.CMath.R2D((double)m_afAcc[0]);//(float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2]));
                    afAngle[1] = (float)Ojw.CMath.R2D((double)m_afAcc[1]);//(float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0]));
                    afAngle[2] = (float)Ojw.CMath.R2D((double)m_afAcc[2]);//(float)Math.Atan(m_afAcc[2] / (float)Math.Sqrt(m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1]));
                    Ojw.CMessage.Write("Acc : {0}, {1}, {2}", afAngle[0], afAngle[1], afAngle[2]);
                    a = afAngle[0];
                    b = afAngle[1];
                }
            }
#if false
            if (m_CTIdAcc.Get() >= 1000)
            {
                m_CTIdAcc.Set();
                float[] afAngle = new float[3];
                afAngle[0] = (float)Ojw.CMath.R2D((double)m_afAcc[0]);//(float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2]));
                afAngle[1] = (float)Ojw.CMath.R2D((double)m_afAcc[1]);//(float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0]));
                afAngle[2] = (float)Ojw.CMath.R2D((double)m_afAcc[2]);//(float)Math.Atan(m_afAcc[2] / (float)Math.Sqrt(m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1]));
                Ojw.CMessage.Write("Acc : {0}, {1}, {2}", afAngle[0], afAngle[1], afAngle[2]);

            }
#endif
        }
        #endregion Acc
        #region Gyro
        private float[] m_afGyro = new float[3];
        private void Myo_GyroscopeDataAcquired(object sender, GyroscopeDataEventArgs e)
        {
            //float fMulti = 10.0f;
            //m_CGrap.Push(m_afAcc(int)Math.Round(e.Gyroscope.X * fMulti), (int)Math.Round(e.Gyroscope.Y * fMulti), (int)Math.Round(e.Gyroscope.Z * fMulti));
            if (m_anHandle[0] == e.Myo.Handle.ToInt32())
            {
                m_afGyro[0] = e.Gyroscope.X;
                m_afGyro[1] = e.Gyroscope.Y;
                m_afGyro[2] = e.Gyroscope.Z;
            }
#if false
            #region Message display on every 1 second
            if (m_CTIdGyro.Get() >= 1000)
            {
                m_CTIdGyro.Set();
                float[] afAngle = new float[3];
                Ojw.CMessage.Write("Gyro : {0}, {1}, {2}", m_afGyro[0], m_afGyro[1], m_afGyro[2]);
            }
            #endregion Message display on every 1 second
#endif
        }
        #endregion Gyro

        private Ojw.CTimer m_CTId0 = new Ojw.CTimer();
        private Ojw.CTimer m_CTIdAcc = new Ojw.CTimer();
        private Ojw.CTimer m_CTIdGyro = new Ojw.CTimer();
        private float[] m_afInitAngle = new float[3];
        private void Myo_OrientationDataAcquired(object sender, OrientationDataEventArgs e)
        {
            const float PI = (float)System.Math.PI;

            int nDev = 1; //10;
            // convert the values to a 0-9 scale (for easier digestion/understanding)
            float nRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
            float nPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
            float nYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);

            if (m_CTId0.Get() >= 200)
            {
                m_CTId0.Set();
                //if (m_bFirst == true)
                //{
                //    m_afInitAngle[0] = e.Orientation.X;
                //    m_afInitAngle[1] = e.Orientation.Y;
                //    m_afInitAngle[2] = e.Orientation.W;
                //}
                float fX = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.X - m_afInitAngle[0]), 3);
                float fY = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.Y - m_afInitAngle[1]), 3);
                float fW = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.W - m_afInitAngle[2]), 3);
                //float fSwing = (float)Math.Round(Ojw.CMath.R2D(e.Roll), 3);
                //float fTilt = (float)Math.Round(Ojw.CMath.R2D(e.Pitch), 3);
                //float fPan = (float)Math.Round(Ojw.CMath.R2D(e.Yaw), 3);
                //m_C3d.SetRobot_Rot(fPan - 90.0f, -fTilt, -fSwing);
                Ojw.CMessage.Write("[{6}]Roll[{0}], Pitch[{1}], Yaw[{2}] || X[{3}], Y[{4}], W[{5}]", nRoll, nPitch, nYaw, fX, fY, fW, e.Myo.Handle);
            }
        }

        private void btnMyo_Click(object sender, EventArgs e)
        {
            m_CGrap = new Ojw.CGraph(lbDisp, lbDisp.Width, Color.White, null,
                Color.Red, Color.Blue, Color.Black,
                Color.Red, Color.Blue, Color.Black);

            InitMyo();

            tmrDraw.Enabled = true;
        }

        private Ojw.CGraph m_CGrap = null;

        private void btnAngleReset_Click(object sender, EventArgs e)
        {
            firstAngleCheck = true;
        }

        bool firstAngleCheck = false;
        int countt = 0;
        float firstA;
        float firstB;
        float a = 0;
        float b = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (firstAngleCheck == true)
            {
                firstA = a;
                firstB = b;
                firstAngleCheck = false;
            }
            txtMonitoring.Text = ((Math.Round((a - firstA) / .01) * .01)) + " \r\n" + ((Math.Round((b - firstB) / .01) * .01));

            if (countt <= 0)
            {
                MyoMover(a - firstA, b - firstB, pose);
            }
            else
            {
                countt--;
            }
        }

        private void btnMyoMove_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            firstAngleCheck = true;
        }

        private void btnPoseReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            x = 200;
            y = 0;
            z = 100;
            InverseKinematicsMove(x, y, z, 3000, 1000);
            countt = 25;
        }

        private void btnTorqueOn_Click(object sender, EventArgs e)
        {
            m.SetTorque(true, true);
        }

        private void btnTorqueOff_Click(object sender, EventArgs e)
        {
            m.SetTorque(false, false);
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            m.Set_Angle(5, gripperGrab);
            m.Send_Motor(1000);
        }

        private void btnUngrab_Click(object sender, EventArgs e)
        {
            m.Set_Angle(5, gripperUngrab);
            m.Send_Motor(1000);
        }


        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // 조이스틱 선언
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer(); // 조이스틱의 연결을 주기적으로 체크할 타이머

        private void btnJoystickStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void bntJoystickStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 조이스틱 정보 갱신
            m_CJoy.Update();
            // 조이스틱이 살아 있는지 체크하는 함수
            FJoystick_Check_Alive();
            // 조이스틱 데이타 체크
            FJoystick_Check_Data();
        }

        bool grabOK2 = false;

        int joystickSpd = 11;
        private void FJoystick_Check_Data()
        {
            double cjy = m_CJoy.dX0;
            double cjx = m_CJoy.dY0;
            double cjz = m_CJoy.dY1;


            if (cjy > 0.53 | cjy < 0.47)
            {
                y -= (int)((cjy - 0.5) * joystickSpd);
                txtWarning.Text = "";
                if (posOK(x,y,z) == false)
                {
                    txtWarning.Text = "범위 이상의 모터 각도";
                    y += (int)((cjy - 0.5) * joystickSpd);
                }
            }

            if (cjx > 0.53 | cjx < 0.47)
            {
                x -= (int)((cjx - 0.5) * joystickSpd);
                txtWarning.Text = "";
                if (posOK(x,y,z) == false)
                {
                    txtWarning.Text = "범위 이상의 모터 각도";
                    x += (int)((cjx - 0.5) * joystickSpd);
                }
            }
            if (cjz > 0.53 | cjz < 0.47)
            {
                z -= (int)((cjz - 0.5) * joystickSpd);
                txtWarning.Text = "";
                if (posOK(x,y,z) == false)
                {
                    txtWarning.Text = "범위 이상의 모터 각도";
                    z += (int)((cjz - 0.5) * joystickSpd);
                }
            }

            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true)
            {
                lblB.ForeColor = Color.Red;
                grabOK2 = false;
            }
            else
            {
                lblB.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
            {
                lblA.ForeColor = Color.Red;
                grabOK2 = true;
            }
            else
            {
                lblA.ForeColor = Color.Black;
            }
            if (grabOK2)
            {
                m.Set_Angle(5, gripperGrab);
                m.Send_Motor(500);
            }
            else
            {
                m.Set_Angle(5, gripperUngrab);
                m.Send_Motor(500);
            }

            txtGamepadDisp.Text = "X = " + m_CJoy.dX0 + "\r\nY = " + m_CJoy.dY0 + "\r\nZ = " + m_CJoy.dY1;

            radioButton1.Location = new Point((int)(187 * m_CJoy.dX0), (int)(187 * m_CJoy.dY0));
            radioButton2.Location = new Point(10, (int)(186 * m_CJoy.dY1));

            InverseKinematicsMove(x, y, z, 300, 0);
        }

            private void FJoystick_Check_Alive()
        {
            #region Joystick Check

            Color m_colorLive = Color.Green; // 살았을 경우의 색
            Color m_colorDead = Color.Gray; // 죽었을 경우의 색
            if (m_CJoy.IsValid == false)
            {
                #region 조이스틱이 연결되지 않았음을 표시
                if (lbJoystick.ForeColor != m_colorDead)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = m_colorDead;
                }
                #endregion 조이스틱이 연결되지 않았음을 표시

                #region 3초마다 다시 재연결을 하려고 시도
                if (m_CTmr_Joystick.Get() > 3000) // Joystic 이 죽어있다면 체크(3초단위)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set(); // 타이머의 카운터를 다시 초기화 한다.
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
                #endregion 3초마다 다시 재연결을 하려고 시도
            }
            else
            {
                #region 연결 되었음을 표시
                if (lbJoystick.ForeColor != m_colorLive)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = m_colorLive;
                }
                #endregion 연결 되었음을 표시
            }
            #endregion Joystick Check
        }

        /*
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (z < 50)
            {
                z = 50;
                InverseKinematicsMove(x, y, z, 1200, 1200);
            }
            x = 200;
            y = 0;
            InverseKinematicsMove(x, y, z, 1200, 1200);
            InverseKinematicsMove(x, y, -30, 1200, 1200);
            m.SetTorque(false, false);
            m.Close();
            this.Dispose();
            //DInitMyo();
        }*/

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            float fMulti = 1.0f;
            float[] afAngle = new float[3];
            //afAngle[0] = (float)Ojw.CMath.R2D((double)m_afAcc[0]);//(float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2]));
            //afAngle[1] = (float)Ojw.CMath.R2D((double)m_afAcc[1]);//(float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0]));
            //afAngle[2] = (float)Ojw.CMath.R2D((double)m_afAcc[2]);//(float)Math.Atan(m_afAcc[2] / (float)Math.Sqrt(m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1]));
#if false
            float fTmp;
            fTmp = ((m_afAcc[2] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[2]);
            afAngle[0] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[1] / fTmp));
            fTmp = ((m_afAcc[0] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[0]);
            afAngle[1] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[2] / fTmp));
            fTmp = ((m_afAcc[1] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[1]);
            afAngle[2] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[0] / fTmp));
#else
            float fTmp = m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2];
            if (fTmp == 0.0f) fTmp = (float)Ojw.CMath.Zero();
            afAngle[0] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(fTmp)));
            fTmp = m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0];
            if (fTmp == 0.0f) fTmp = (float)Ojw.CMath.Zero();
            afAngle[1] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(fTmp)));
            fTmp = m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1];
            float fTmp2 = m_afAcc[2];
            if (fTmp2 == 0.0f) fTmp2 = (float)Ojw.CMath.Zero();
            afAngle[2] = (float)Ojw.CMath.R2D((float)Math.Atan((float)Math.Sqrt(fTmp) / fTmp2));
#endif
            m_CGrap.Push(
                (int)Math.Round(afAngle[0] * fMulti), (int)Math.Round(afAngle[1] * fMulti), (int)Math.Round(afAngle[2] * fMulti),
                //(int)Math.Round(m_afAcc[0] * fMulti), (int)Math.Round(m_afAcc[1] * fMulti), (int)Math.Round(m_afAcc[2] * fMulti),
                (int)Math.Round(m_afGyro[0] * fMulti), (int)Math.Round(m_afGyro[1] * fMulti), (int)Math.Round(m_afGyro[2] * fMulti)
                );
            m_CGrap.OjwDraw();
        }

        void MyoMover(float aaa, float bbb, string ppose)
        {
            if (aaa < -50)
            {
                x += 17;
                txtDisp.Text = "앞으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    x -= 17;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (aaa < -25)
            {
                x += 7;
                txtDisp.Text = "앞으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    x -= 7;
                    txtWarning.Text = "***범위 이상의 모터 각도***";
                }
            }
            else if (aaa > 50)
            {
                x -= 17;
                txtDisp.Text = "뒤로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    x += 17;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (aaa > 25)
            {
                x -= 7;
                txtDisp.Text = "뒤로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    x += 7;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (bbb < -50)
            {
                y += 14;
                txtDisp.Text = "왼쪽으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    y -= 17;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (bbb < -22)
            {
                y += 7;
                txtDisp.Text = "왼쪽으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    y -= 7;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (bbb > 50)
            {
                y -= 17;
                txtDisp.Text = "오른쪽으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    y += 17;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else if (bbb > 25)
            {
                y -= 7;
                txtDisp.Text = "오른쪽으로 이동";
                txtWarning.Text = "";
                if (!posOK(x, y, z))
                {
                    y += 7;
                    txtWarning.Text = " ***범위 이상의 모터 각도***";
                }
            }
            else
            {
                txtDisp.Text = "";
            }
            txtPose.Text = ppose;
            switch (ppose)
            {
                case "WaveOut":
                    z += 11;
                    txtDisp.Text += "위로 이동";
                    txtWarning.Text = "";
                    if (!posOK(x, y, z))
                    {
                        z -= 11;
                        txtWarning.Text = " ***범위 이상의 모터 각도***";
                    }
                    break;
                case "WaveIn":
                    z -= 11;
                    txtDisp.Text += "아래로 이동";
                    txtWarning.Text = "";
                    if (!posOK(x, y, z))
                    {
                        z += 11;
                        txtWarning.Text = " ***범위 이상의 모터 각도***";
                    }
                    break;
                case "Fist":
                    isGrab = true;
                    break;
                case "FingersSpread":
                    isGrab = false;
                    break;
            }
            gripperMove(isGrab);
            InverseKinematicsMove(x, y, z, moveTime, delayTime);

        }
    }
}
