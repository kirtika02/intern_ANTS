namespace serial_com_modbus
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxTempSet = new System.Windows.Forms.TextBox();
            this.cBoxMaxOp = new System.Windows.Forms.TextBox();
            this.cBoxProfileSet = new System.Windows.Forms.TextBox();
            this.cBoxDurLeft = new System.Windows.Forms.TextBox();
            this.cBoxDur = new System.Windows.Forms.TextBox();
            this.cBoxProfile = new System.Windows.Forms.TextBox();
            this.cBoxStartTime = new System.Windows.Forms.TextBox();
            this.cBoxRamp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxTempAct = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.cBoxTempSet);
            this.groupBox1.Controls.Add(this.cBoxMaxOp);
            this.groupBox1.Controls.Add(this.cBoxProfileSet);
            this.groupBox1.Controls.Add(this.cBoxDurLeft);
            this.groupBox1.Controls.Add(this.cBoxDur);
            this.groupBox1.Controls.Add(this.cBoxProfile);
            this.groupBox1.Controls.Add(this.cBoxStartTime);
            this.groupBox1.Controls.Add(this.cBoxRamp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxTempAct);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 413);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBoxTempSet
            // 
            this.cBoxTempSet.Location = new System.Drawing.Point(174, 64);
            this.cBoxTempSet.Name = "cBoxTempSet";
            this.cBoxTempSet.Size = new System.Drawing.Size(161, 26);
            this.cBoxTempSet.TabIndex = 35;
            // 
            // cBoxMaxOp
            // 
            this.cBoxMaxOp.Location = new System.Drawing.Point(174, 100);
            this.cBoxMaxOp.Name = "cBoxMaxOp";
            this.cBoxMaxOp.Size = new System.Drawing.Size(161, 26);
            this.cBoxMaxOp.TabIndex = 34;
            // 
            // cBoxProfileSet
            // 
            this.cBoxProfileSet.Location = new System.Drawing.Point(174, 134);
            this.cBoxProfileSet.Name = "cBoxProfileSet";
            this.cBoxProfileSet.Size = new System.Drawing.Size(161, 26);
            this.cBoxProfileSet.TabIndex = 33;
            // 
            // cBoxDurLeft
            // 
            this.cBoxDurLeft.Location = new System.Drawing.Point(174, 226);
            this.cBoxDurLeft.Name = "cBoxDurLeft";
            this.cBoxDurLeft.Size = new System.Drawing.Size(161, 26);
            this.cBoxDurLeft.TabIndex = 32;
            this.cBoxDurLeft.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cBoxDur
            // 
            this.cBoxDur.Location = new System.Drawing.Point(174, 263);
            this.cBoxDur.Name = "cBoxDur";
            this.cBoxDur.Size = new System.Drawing.Size(161, 26);
            this.cBoxDur.TabIndex = 31;
            // 
            // cBoxProfile
            // 
            this.cBoxProfile.Location = new System.Drawing.Point(174, 301);
            this.cBoxProfile.Name = "cBoxProfile";
            this.cBoxProfile.Size = new System.Drawing.Size(161, 26);
            this.cBoxProfile.TabIndex = 30;
            // 
            // cBoxStartTime
            // 
            this.cBoxStartTime.Location = new System.Drawing.Point(174, 340);
            this.cBoxStartTime.Name = "cBoxStartTime";
            this.cBoxStartTime.Size = new System.Drawing.Size(161, 26);
            this.cBoxStartTime.TabIndex = 29;
            // 
            // cBoxRamp
            // 
            this.cBoxRamp.Location = new System.Drawing.Point(174, 378);
            this.cBoxRamp.Name = "cBoxRamp";
            this.cBoxRamp.Size = new System.Drawing.Size(161, 26);
            this.cBoxRamp.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Temperature Set";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Max Power O/P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Profile Set Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Duartion Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Profile No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ramping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Temperature Actual";
            // 
            // cBoxTempAct
            // 
            this.cBoxTempAct.Location = new System.Drawing.Point(174, 26);
            this.cBoxTempAct.Name = "cBoxTempAct";
            this.cBoxTempAct.Size = new System.Drawing.Size(161, 26);
            this.cBoxTempAct.TabIndex = 18;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOK.Location = new System.Drawing.Point(177, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 30);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "T/C Okay";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cBoxTempSet;
        private System.Windows.Forms.TextBox cBoxMaxOp;
        private System.Windows.Forms.TextBox cBoxProfileSet;
        private System.Windows.Forms.TextBox cBoxDurLeft;
        private System.Windows.Forms.TextBox cBoxDur;
        private System.Windows.Forms.TextBox cBoxProfile;
        private System.Windows.Forms.TextBox cBoxStartTime;
        private System.Windows.Forms.TextBox cBoxRamp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cBoxTempAct;
        private System.Windows.Forms.Button btnOK;
    }
}