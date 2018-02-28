namespace Manipulator_v02
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFront = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDonw = new System.Windows.Forms.Button();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIVMove = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnMyo = new System.Windows.Forms.Button();
            this.btnAngleReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMonitoring = new System.Windows.Forms.TextBox();
            this.btnMyoMove = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPose = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDisp = new System.Windows.Forms.Label();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnUngrab = new System.Windows.Forms.Button();
            this.btnPoseReset = new System.Windows.Forms.Button();
            this.btnTorqueOn = new System.Windows.Forms.Button();
            this.btnTorqueOff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnJoystickStart = new System.Windows.Forms.Button();
            this.bntJoystickStop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbJoystick = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtGamepadDisp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFront
            // 
            this.btnFront.Location = new System.Drawing.Point(136, 14);
            this.btnFront.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(80, 80);
            this.btnFront.TabIndex = 0;
            this.btnFront.Text = "앞";
            this.btnFront.UseVisualStyleBackColor = true;
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(56, 94);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 80);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "왼쪽";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(216, 94);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 80);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "오른쪽";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(136, 174);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 80);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "뒤";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(325, 35);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 80);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "위";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDonw
            // 
            this.btnDonw.Location = new System.Drawing.Point(325, 119);
            this.btnDonw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDonw.Name = "btnDonw";
            this.btnDonw.Size = new System.Drawing.Size(80, 80);
            this.btnDonw.TabIndex = 5;
            this.btnDonw.Text = "아래";
            this.btnDonw.UseVisualStyleBackColor = true;
            this.btnDonw.Click += new System.EventHandler(this.btnDonw_Click);
            // 
            // tmrDraw
            // 
            this.tmrDraw.Enabled = true;
            this.tmrDraw.Interval = 20;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(432, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 302);
            this.textBox1.TabIndex = 7;
            // 
            // btnIVMove
            // 
            this.btnIVMove.Location = new System.Drawing.Point(142, 298);
            this.btnIVMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIVMove.Name = "btnIVMove";
            this.btnIVMove.Size = new System.Drawing.Size(74, 93);
            this.btnIVMove.TabIndex = 8;
            this.btnIVMove.Text = "인버스 무브";
            this.btnIVMove.UseVisualStyleBackColor = true;
            this.btnIVMove.Click += new System.EventHandler(this.btnIVMove_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(33, 298);
            this.txtX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(101, 27);
            this.txtX.TabIndex = 9;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(33, 331);
            this.txtY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(101, 27);
            this.txtY.TabIndex = 10;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(33, 364);
            this.txtZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(101, 27);
            this.txtZ.TabIndex = 11;
            // 
            // btnMyo
            // 
            this.btnMyo.Location = new System.Drawing.Point(432, 14);
            this.btnMyo.Name = "btnMyo";
            this.btnMyo.Size = new System.Drawing.Size(124, 35);
            this.btnMyo.TabIndex = 15;
            this.btnMyo.Text = "마이오 연결";
            this.btnMyo.UseVisualStyleBackColor = true;
            this.btnMyo.Click += new System.EventHandler(this.btnMyo_Click);
            // 
            // btnAngleReset
            // 
            this.btnAngleReset.Location = new System.Drawing.Point(740, 14);
            this.btnAngleReset.Name = "btnAngleReset";
            this.btnAngleReset.Size = new System.Drawing.Size(157, 35);
            this.btnAngleReset.TabIndex = 16;
            this.btnAngleReset.Text = "초기 각도 초기화";
            this.btnAngleReset.UseVisualStyleBackColor = true;
            this.btnAngleReset.Click += new System.EventHandler(this.btnAngleReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMonitoring
            // 
            this.txtMonitoring.Location = new System.Drawing.Point(672, 89);
            this.txtMonitoring.Multiline = true;
            this.txtMonitoring.Name = "txtMonitoring";
            this.txtMonitoring.Size = new System.Drawing.Size(225, 56);
            this.txtMonitoring.TabIndex = 17;
            // 
            // btnMyoMove
            // 
            this.btnMyoMove.Location = new System.Drawing.Point(562, 14);
            this.btnMyoMove.Name = "btnMyoMove";
            this.btnMyoMove.Size = new System.Drawing.Size(172, 35);
            this.btnMyoMove.TabIndex = 18;
            this.btnMyoMove.Text = "마이오로 움직이기";
            this.btnMyoMove.UseVisualStyleBackColor = true;
            this.btnMyoMove.Click += new System.EventHandler(this.btnMyoMove_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(19, 425);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(878, 212);
            this.txtMessage.TabIndex = 14;
            // 
            // txtPose
            // 
            this.txtPose.Location = new System.Drawing.Point(672, 178);
            this.txtPose.Margin = new System.Windows.Forms.Padding(0);
            this.txtPose.Multiline = true;
            this.txtPose.Name = "txtPose";
            this.txtPose.Size = new System.Drawing.Size(225, 45);
            this.txtPose.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(432, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "역기구학 모니터";
            // 
            // txtDisp
            // 
            this.txtDisp.Location = new System.Drawing.Point(672, 254);
            this.txtDisp.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisp.Multiline = true;
            this.txtDisp.Name = "txtDisp";
            this.txtDisp.Size = new System.Drawing.Size(225, 45);
            this.txtDisp.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(672, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "동작 모니터";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(672, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "손동작 모니터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(672, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "기울기 모니터";
            // 
            // lbDisp
            // 
            this.lbDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisp.Location = new System.Drawing.Point(916, 592);
            this.lbDisp.Name = "lbDisp";
            this.lbDisp.Size = new System.Drawing.Size(250, 45);
            this.lbDisp.TabIndex = 26;
            this.lbDisp.Text = "label5";
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(225, 225);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(87, 37);
            this.btnGrab.TabIndex = 27;
            this.btnGrab.Text = "집게 잡기";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // btnUngrab
            // 
            this.btnUngrab.Location = new System.Drawing.Point(318, 225);
            this.btnUngrab.Name = "btnUngrab";
            this.btnUngrab.Size = new System.Drawing.Size(87, 37);
            this.btnUngrab.TabIndex = 28;
            this.btnUngrab.Text = "집게 풀기";
            this.btnUngrab.UseVisualStyleBackColor = true;
            this.btnUngrab.Click += new System.EventHandler(this.btnUngrab_Click);
            // 
            // btnPoseReset
            // 
            this.btnPoseReset.Location = new System.Drawing.Point(223, 298);
            this.btnPoseReset.Name = "btnPoseReset";
            this.btnPoseReset.Size = new System.Drawing.Size(89, 93);
            this.btnPoseReset.TabIndex = 30;
            this.btnPoseReset.Text = "위치\r\n초기화";
            this.btnPoseReset.UseVisualStyleBackColor = true;
            this.btnPoseReset.Click += new System.EventHandler(this.btnPoseReset_Click);
            // 
            // btnTorqueOn
            // 
            this.btnTorqueOn.Location = new System.Drawing.Point(318, 298);
            this.btnTorqueOn.Name = "btnTorqueOn";
            this.btnTorqueOn.Size = new System.Drawing.Size(87, 43);
            this.btnTorqueOn.TabIndex = 31;
            this.btnTorqueOn.Text = "토크 온";
            this.btnTorqueOn.UseVisualStyleBackColor = true;
            this.btnTorqueOn.Click += new System.EventHandler(this.btnTorqueOn_Click);
            // 
            // btnTorqueOff
            // 
            this.btnTorqueOff.Location = new System.Drawing.Point(318, 348);
            this.btnTorqueOff.Name = "btnTorqueOff";
            this.btnTorqueOff.Size = new System.Drawing.Size(87, 43);
            this.btnTorqueOff.TabIndex = 32;
            this.btnTorqueOff.Text = "토크 오프";
            this.btnTorqueOff.UseVisualStyleBackColor = true;
            this.btnTorqueOff.Click += new System.EventHandler(this.btnTorqueOff_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(672, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "경고 모니터";
            // 
            // txtWarning
            // 
            this.txtWarning.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(672, 346);
            this.txtWarning.Multiline = true;
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(225, 45);
            this.txtWarning.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(920, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 35;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblA.Location = new System.Drawing.Point(1020, 147);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 30);
            this.lblA.TabIndex = 38;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblB.Location = new System.Drawing.Point(1053, 147);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(25, 30);
            this.lblB.TabIndex = 39;
            this.lblB.Text = "B";
            // 
            // btnJoystickStart
            // 
            this.btnJoystickStart.Location = new System.Drawing.Point(920, 14);
            this.btnJoystickStart.Name = "btnJoystickStart";
            this.btnJoystickStart.Size = new System.Drawing.Size(124, 35);
            this.btnJoystickStart.TabIndex = 40;
            this.btnJoystickStart.Text = "조이스틱 사용";
            this.btnJoystickStart.UseVisualStyleBackColor = true;
            this.btnJoystickStart.Click += new System.EventHandler(this.btnJoystickStart_Click);
            // 
            // bntJoystickStop
            // 
            this.bntJoystickStop.Location = new System.Drawing.Point(1050, 14);
            this.bntJoystickStop.Name = "bntJoystickStop";
            this.bntJoystickStop.Size = new System.Drawing.Size(116, 35);
            this.bntJoystickStop.TabIndex = 41;
            this.bntJoystickStop.Text = "조이스틱 중지";
            this.bntJoystickStop.UseVisualStyleBackColor = true;
            this.bntJoystickStop.Click += new System.EventHandler(this.bntJoystickStop_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Location = new System.Drawing.Point(954, 102);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(73, 20);
            this.lbJoystick.TabIndex = 42;
            this.lbJoystick.Text = "lbJoystick";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(1132, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 199);
            this.panel2.TabIndex = 43;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtGamepadDisp
            // 
            this.txtGamepadDisp.Location = new System.Drawing.Point(920, 425);
            this.txtGamepadDisp.Multiline = true;
            this.txtGamepadDisp.Name = "txtGamepadDisp";
            this.txtGamepadDisp.Size = new System.Drawing.Size(246, 115);
            this.txtGamepadDisp.TabIndex = 44;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 31);
            this.btnConnect.TabIndex = 45;
            this.btnConnect.Text = "포트 연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(8, 5);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 27);
            this.textBoxPort.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 659);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtGamepadDisp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbJoystick);
            this.Controls.Add(this.bntJoystickStop);
            this.Controls.Add(this.btnJoystickStart);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTorqueOff);
            this.Controls.Add(this.btnTorqueOn);
            this.Controls.Add(this.btnPoseReset);
            this.Controls.Add(this.btnUngrab);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.lbDisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPose);
            this.Controls.Add(this.btnMyoMove);
            this.Controls.Add(this.txtMonitoring);
            this.Controls.Add(this.btnAngleReset);
            this.Controls.Add(this.btnMyo);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnIVMove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDonw);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnFront);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Manipulaotr Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFront;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDonw;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIVMove;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnMyo;
        private System.Windows.Forms.Button btnAngleReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMonitoring;
        private System.Windows.Forms.Button btnMyoMove;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDisp;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnUngrab;
        private System.Windows.Forms.Button btnPoseReset;
        private System.Windows.Forms.Button btnTorqueOn;
        private System.Windows.Forms.Button btnTorqueOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnJoystickStart;
        private System.Windows.Forms.Button bntJoystickStop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtGamepadDisp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxPort;
    }
}

