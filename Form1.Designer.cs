namespace IoTRobotWorldUDPServer
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.LocalIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UDPMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendUDPMessageButton = new System.Windows.Forms.Button();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.StartStopUDPClientButton = new System.Windows.Forms.Button();
            this.UDPRegularSenderTimer = new System.Windows.Forms.Timer(this.components);
            this.RegularUDPSendCheckBox = new System.Windows.Forms.CheckBox();
            this.AppendLFSymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox_control = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label_control = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.up_N = new System.Windows.Forms.NumericUpDown();
            this.up_M = new System.Windows.Forms.NumericUpDown();
            this.up_F = new System.Windows.Forms.NumericUpDown();
            this.up_B = new System.Windows.Forms.NumericUpDown();
            this.up_T = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_T)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Port";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(72, 6);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoteIPTextBox.TabIndex = 2;
            this.RemoteIPTextBox.Text = "127.0.0.1";
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(72, 38);
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemotePortTextBox.TabIndex = 3;
            this.RemotePortTextBox.Text = "8888";
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(240, 38);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocalPortTextBox.TabIndex = 7;
            this.LocalPortTextBox.Text = "7777";
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(240, 6);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocalIPTextBox.TabIndex = 6;
            this.LocalIPTextBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message";
            // 
            // UDPMessageTextBox
            // 
            this.UDPMessageTextBox.Location = new System.Drawing.Point(60, 73);
            this.UDPMessageTextBox.Name = "UDPMessageTextBox";
            this.UDPMessageTextBox.Size = new System.Drawing.Size(249, 20);
            this.UDPMessageTextBox.TabIndex = 9;
            this.UDPMessageTextBox.Text = "{\"N\":1, \"M\":0, \"F\":50, \"B\":10, \"T\":0}";
            // 
            // SendUDPMessageButton
            // 
            this.SendUDPMessageButton.Location = new System.Drawing.Point(60, 99);
            this.SendUDPMessageButton.Name = "SendUDPMessageButton";
            this.SendUDPMessageButton.Size = new System.Drawing.Size(75, 28);
            this.SendUDPMessageButton.TabIndex = 10;
            this.SendUDPMessageButton.Text = "Send";
            this.SendUDPMessageButton.UseVisualStyleBackColor = true;
            this.SendUDPMessageButton.Click += new System.EventHandler(this.SendUDPMessageButton_Click);
            // 
            // ReportListBox
            // 
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.Location = new System.Drawing.Point(12, 143);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.ScrollAlwaysVisible = true;
            this.ReportListBox.Size = new System.Drawing.Size(377, 121);
            this.ReportListBox.TabIndex = 11;
            // 
            // StartStopUDPClientButton
            // 
            this.StartStopUDPClientButton.Location = new System.Drawing.Point(347, 11);
            this.StartStopUDPClientButton.Name = "StartStopUDPClientButton";
            this.StartStopUDPClientButton.Size = new System.Drawing.Size(54, 42);
            this.StartStopUDPClientButton.TabIndex = 12;
            this.StartStopUDPClientButton.Text = "Start";
            this.StartStopUDPClientButton.UseVisualStyleBackColor = true;
            this.StartStopUDPClientButton.Click += new System.EventHandler(this.StartStopUDPClientButton_Click);
            // 
            // UDPRegularSenderTimer
            // 
            this.UDPRegularSenderTimer.Interval = 1000;
            this.UDPRegularSenderTimer.Tick += new System.EventHandler(this.UDPRegularSenderTimer_Tick);
            // 
            // RegularUDPSendCheckBox
            // 
            this.RegularUDPSendCheckBox.AutoSize = true;
            this.RegularUDPSendCheckBox.Location = new System.Drawing.Point(184, 106);
            this.RegularUDPSendCheckBox.Name = "RegularUDPSendCheckBox";
            this.RegularUDPSendCheckBox.Size = new System.Drawing.Size(134, 17);
            this.RegularUDPSendCheckBox.TabIndex = 13;
            this.RegularUDPSendCheckBox.Text = "Send message regular ";
            this.RegularUDPSendCheckBox.UseVisualStyleBackColor = true;
            this.RegularUDPSendCheckBox.CheckedChanged += new System.EventHandler(this.RegularUDPSendCheckBox_CheckedChanged);
            // 
            // AppendLFSymbolCheckBox
            // 
            this.AppendLFSymbolCheckBox.AutoSize = true;
            this.AppendLFSymbolCheckBox.Checked = true;
            this.AppendLFSymbolCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendLFSymbolCheckBox.Location = new System.Drawing.Point(315, 75);
            this.AppendLFSymbolCheckBox.Name = "AppendLFSymbolCheckBox";
            this.AppendLFSymbolCheckBox.Size = new System.Drawing.Size(78, 17);
            this.AppendLFSymbolCheckBox.TabIndex = 14;
            this.AppendLFSymbolCheckBox.Text = "Append LF";
            this.AppendLFSymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox_control
            // 
            this.pictureBox_control.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_control.Location = new System.Drawing.Point(799, 12);
            this.pictureBox_control.Name = "pictureBox_control";
            this.pictureBox_control.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_control.TabIndex = 15;
            this.pictureBox_control.TabStop = false;
            this.pictureBox_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label_control
            // 
            this.label_control.AutoSize = true;
            this.label_control.Location = new System.Drawing.Point(407, 6);
            this.label_control.Name = "label_control";
            this.label_control.Size = new System.Drawing.Size(15, 13);
            this.label_control.TabIndex = 16;
            this.label_control.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "T";
            // 
            // up_N
            // 
            this.up_N.Location = new System.Drawing.Point(428, 2);
            this.up_N.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_N.Name = "up_N";
            this.up_N.Size = new System.Drawing.Size(43, 20);
            this.up_N.TabIndex = 30;
            // 
            // up_M
            // 
            this.up_M.Location = new System.Drawing.Point(428, 28);
            this.up_M.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_M.Name = "up_M";
            this.up_M.Size = new System.Drawing.Size(43, 20);
            this.up_M.TabIndex = 31;
            // 
            // up_F
            // 
            this.up_F.Location = new System.Drawing.Point(428, 54);
            this.up_F.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_F.Name = "up_F";
            this.up_F.Size = new System.Drawing.Size(43, 20);
            this.up_F.TabIndex = 32;
            // 
            // up_B
            // 
            this.up_B.Location = new System.Drawing.Point(428, 80);
            this.up_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_B.Name = "up_B";
            this.up_B.Size = new System.Drawing.Size(43, 20);
            this.up_B.TabIndex = 33;
            // 
            // up_T
            // 
            this.up_T.Location = new System.Drawing.Point(428, 106);
            this.up_T.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_T.Name = "up_T";
            this.up_T.Size = new System.Drawing.Size(43, 20);
            this.up_T.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 275);
            this.Controls.Add(this.up_T);
            this.Controls.Add(this.up_B);
            this.Controls.Add(this.up_F);
            this.Controls.Add(this.up_M);
            this.Controls.Add(this.up_N);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_control);
            this.Controls.Add(this.pictureBox_control);
            this.Controls.Add(this.AppendLFSymbolCheckBox);
            this.Controls.Add(this.RegularUDPSendCheckBox);
            this.Controls.Add(this.StartStopUDPClientButton);
            this.Controls.Add(this.ReportListBox);
            this.Controls.Add(this.SendUDPMessageButton);
            this.Controls.Add(this.UDPMessageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.LocalIPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemotePortTextBox);
            this.Controls.Add(this.RemoteIPTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IoTRobotWorldUDPServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UDPMessageTextBox;
        private System.Windows.Forms.Button SendUDPMessageButton;
        private System.Windows.Forms.ListBox ReportListBox;
        private System.Windows.Forms.Button StartStopUDPClientButton;
        private System.Windows.Forms.Timer UDPRegularSenderTimer;
        private System.Windows.Forms.CheckBox RegularUDPSendCheckBox;
        private System.Windows.Forms.CheckBox AppendLFSymbolCheckBox;
        private System.Windows.Forms.PictureBox pictureBox_control;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label_control;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown up_N;
        private System.Windows.Forms.NumericUpDown up_M;
        private System.Windows.Forms.NumericUpDown up_F;
        private System.Windows.Forms.NumericUpDown up_B;
        private System.Windows.Forms.NumericUpDown up_T;
    }
}

