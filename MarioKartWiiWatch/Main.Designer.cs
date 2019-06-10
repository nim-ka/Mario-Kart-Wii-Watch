namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblGameID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBst = new System.Windows.Forms.Label();
            this.lblAirtime = new System.Windows.Forms.Label();
            this.lblAirtime_String = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCKPT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRaceComp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLapComp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblXpos = new System.Windows.Forms.Label();
            this.lblYpos = new System.Windows.Forms.Label();
            this.lblZpos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblYVel = new System.Windows.Forms.Label();
            this.lblXZspd = new System.Windows.Forms.Label();
            this.lblXYZspd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblXRot = new System.Windows.Forms.Label();
            this.lblYRot = new System.Windows.Forms.Label();
            this.lblZRot = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameID
            // 
            this.lblGameID.AutoSize = true;
            this.lblGameID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.Location = new System.Drawing.Point(142, 14);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(81, 19);
            this.lblGameID.TabIndex = 0;
            this.lblGameID.Text = "Game ID:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "N/A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NTSC-U",
            "PAL",
            "NTSC-J",
            "NTSC-K"});
            this.comboBox1.Location = new System.Drawing.Point(15, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(168, 370);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(36, 19);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "MT Charge:";
            // 
            // lblMT
            // 
            this.lblMT.AutoSize = true;
            this.lblMT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMT.Location = new System.Drawing.Point(168, 389);
            this.lblMT.Name = "lblMT";
            this.lblMT.Size = new System.Drawing.Size(36, 19);
            this.lblMT.TabIndex = 8;
            this.lblMT.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Boost:";
            // 
            // lblBst
            // 
            this.lblBst.AutoSize = true;
            this.lblBst.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBst.Location = new System.Drawing.Point(168, 427);
            this.lblBst.Name = "lblBst";
            this.lblBst.Size = new System.Drawing.Size(36, 19);
            this.lblBst.TabIndex = 10;
            this.lblBst.Text = "N/A";
            // 
            // lblAirtime
            // 
            this.lblAirtime.AutoSize = true;
            this.lblAirtime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirtime.Location = new System.Drawing.Point(9, 408);
            this.lblAirtime.Name = "lblAirtime";
            this.lblAirtime.Size = new System.Drawing.Size(81, 19);
            this.lblAirtime.TabIndex = 11;
            this.lblAirtime.Text = "Airtime:";
            // 
            // lblAirtime_String
            // 
            this.lblAirtime_String.AutoSize = true;
            this.lblAirtime_String.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirtime_String.Location = new System.Drawing.Point(168, 408);
            this.lblAirtime_String.Name = "lblAirtime_String";
            this.lblAirtime_String.Size = new System.Drawing.Size(36, 19);
            this.lblAirtime_String.TabIndex = 12;
            this.lblAirtime_String.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Checkpoint:";
            // 
            // lblCKPT
            // 
            this.lblCKPT.AutoSize = true;
            this.lblCKPT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCKPT.Location = new System.Drawing.Point(170, 489);
            this.lblCKPT.Name = "lblCKPT";
            this.lblCKPT.Size = new System.Drawing.Size(36, 19);
            this.lblCKPT.TabIndex = 14;
            this.lblCKPT.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Race Completion:";
            // 
            // lblRaceComp
            // 
            this.lblRaceComp.AutoSize = true;
            this.lblRaceComp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceComp.Location = new System.Drawing.Point(170, 508);
            this.lblRaceComp.Name = "lblRaceComp";
            this.lblRaceComp.Size = new System.Drawing.Size(36, 19);
            this.lblRaceComp.TabIndex = 18;
            this.lblRaceComp.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Lap Completion:";
            // 
            // lblLapComp
            // 
            this.lblLapComp.AutoSize = true;
            this.lblLapComp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapComp.Location = new System.Drawing.Point(170, 527);
            this.lblLapComp.Name = "lblLapComp";
            this.lblLapComp.Size = new System.Drawing.Size(36, 19);
            this.lblLapComp.TabIndex = 20;
            this.lblLapComp.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Z:";
            // 
            // lblXpos
            // 
            this.lblXpos.AutoSize = true;
            this.lblXpos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXpos.Location = new System.Drawing.Point(163, 14);
            this.lblXpos.Name = "lblXpos";
            this.lblXpos.Size = new System.Drawing.Size(36, 19);
            this.lblXpos.TabIndex = 24;
            this.lblXpos.Text = "N/A";
            // 
            // lblYpos
            // 
            this.lblYpos.AutoSize = true;
            this.lblYpos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYpos.Location = new System.Drawing.Point(163, 33);
            this.lblYpos.Name = "lblYpos";
            this.lblYpos.Size = new System.Drawing.Size(36, 19);
            this.lblYpos.TabIndex = 25;
            this.lblYpos.Text = "N/A";
            // 
            // lblZpos
            // 
            this.lblZpos.AutoSize = true;
            this.lblZpos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZpos.Location = new System.Drawing.Point(163, 52);
            this.lblZpos.Name = "lblZpos";
            this.lblZpos.Size = new System.Drawing.Size(36, 19);
            this.lblZpos.TabIndex = 26;
            this.lblZpos.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Y Vel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "XZ Speed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "XYZ Speed:";
            // 
            // lblYVel
            // 
            this.lblYVel.AutoSize = true;
            this.lblYVel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYVel.Location = new System.Drawing.Point(169, 78);
            this.lblYVel.Name = "lblYVel";
            this.lblYVel.Size = new System.Drawing.Size(36, 19);
            this.lblYVel.TabIndex = 30;
            this.lblYVel.Text = "N/A";
            // 
            // lblXZspd
            // 
            this.lblXZspd.AutoSize = true;
            this.lblXZspd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXZspd.Location = new System.Drawing.Point(169, 97);
            this.lblXZspd.Name = "lblXZspd";
            this.lblXZspd.Size = new System.Drawing.Size(36, 19);
            this.lblXZspd.TabIndex = 31;
            this.lblXZspd.Text = "N/A";
            // 
            // lblXYZspd
            // 
            this.lblXYZspd.AutoSize = true;
            this.lblXYZspd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXYZspd.Location = new System.Drawing.Point(169, 116);
            this.lblXYZspd.Name = "lblXYZspd";
            this.lblXYZspd.Size = new System.Drawing.Size(36, 19);
            this.lblXYZspd.TabIndex = 32;
            this.lblXYZspd.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 89);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkpoint related values";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 84);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velocity";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 112);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commonly used values";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblZpos);
            this.groupBox4.Controls.Add(this.lblYpos);
            this.groupBox4.Controls.Add(this.lblXpos);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 90);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblZRot);
            this.groupBox5.Controls.Add(this.lblYRot);
            this.groupBox5.Controls.Add(this.lblXRot);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 100);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "X:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Y:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Z:";
            // 
            // lblXRot
            // 
            this.lblXRot.AutoSize = true;
            this.lblXRot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRot.Location = new System.Drawing.Point(163, 19);
            this.lblXRot.Name = "lblXRot";
            this.lblXRot.Size = new System.Drawing.Size(36, 19);
            this.lblXRot.TabIndex = 3;
            this.lblXRot.Text = "N/A";
            // 
            // lblYRot
            // 
            this.lblYRot.AutoSize = true;
            this.lblYRot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYRot.Location = new System.Drawing.Point(163, 38);
            this.lblYRot.Name = "lblYRot";
            this.lblYRot.Size = new System.Drawing.Size(36, 19);
            this.lblYRot.TabIndex = 4;
            this.lblYRot.Text = "N/A";
            // 
            // lblZRot
            // 
            this.lblZRot.AutoSize = true;
            this.lblZRot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZRot.Location = new System.Drawing.Point(163, 57);
            this.lblZRot.Name = "lblZRot";
            this.lblZRot.Size = new System.Drawing.Size(36, 19);
            this.lblZRot.TabIndex = 5;
            this.lblZRot.Text = "N/A";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 579);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblXYZspd);
            this.Controls.Add(this.lblXZspd);
            this.Controls.Add(this.lblYVel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblLapComp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRaceComp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCKPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAirtime_String);
            this.Controls.Add(this.lblAirtime);
            this.Controls.Add(this.lblBst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Main";
            this.Text = "Mario Kart Wii Watch";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBst;
        private System.Windows.Forms.Label lblAirtime;
        private System.Windows.Forms.Label lblAirtime_String;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCKPT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRaceComp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLapComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblXpos;
        private System.Windows.Forms.Label lblYpos;
        private System.Windows.Forms.Label lblZpos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblYVel;
        private System.Windows.Forms.Label lblXZspd;
        private System.Windows.Forms.Label lblXYZspd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblZRot;
        private System.Windows.Forms.Label lblYRot;
        private System.Windows.Forms.Label lblXRot;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

