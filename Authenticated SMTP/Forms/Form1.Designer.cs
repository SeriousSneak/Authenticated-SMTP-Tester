namespace Authenticated_SMTP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bSend = new System.Windows.Forms.Button();
            this.checkForceTLS = new System.Windows.Forms.CheckBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textReceivingServer = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textBody = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMessageID = new System.Windows.Forms.TextBox();
            this.bLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDifferentAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDifferentSender = new System.Windows.Forms.CheckBox();
            this.textFromName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bLogLocation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.SystemColors.Window;
            this.bSend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSend.Location = new System.Drawing.Point(165, 397);
            this.bSend.Margin = new System.Windows.Forms.Padding(4);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(164, 28);
            this.bSend.TabIndex = 11;
            this.bSend.Text = "Send message";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // checkForceTLS
            // 
            this.checkForceTLS.AutoSize = true;
            this.checkForceTLS.Checked = true;
            this.checkForceTLS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForceTLS.Location = new System.Drawing.Point(19, 370);
            this.checkForceTLS.Margin = new System.Windows.Forms.Padding(4);
            this.checkForceTLS.Name = "checkForceTLS";
            this.checkForceTLS.Size = new System.Drawing.Size(310, 21);
            this.checkForceTLS.TabIndex = 10;
            this.checkForceTLS.Text = "Force TLS (required for smtp.office365.com)";
            this.checkForceTLS.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(125, 55);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(319, 22);
            this.textPassword.TabIndex = 2;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(125, 23);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(319, 22);
            this.textUserName.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 58);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 26);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(77, 17);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "User name";
            // 
            // textReceivingServer
            // 
            this.textReceivingServer.Location = new System.Drawing.Point(144, 8);
            this.textReceivingServer.Margin = new System.Windows.Forms.Padding(4);
            this.textReceivingServer.Name = "textReceivingServer";
            this.textReceivingServer.Size = new System.Drawing.Size(199, 22);
            this.textReceivingServer.TabIndex = 0;
            this.textReceivingServer.Text = "smtp.office365.com";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(16, 11);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(116, 17);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Receiving Server";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(15, 280);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 17);
            this.labelSubject.TabIndex = 8;
            this.labelSubject.Text = "Subject";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(15, 312);
            this.labelBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(40, 17);
            this.labelBody.TabIndex = 9;
            this.labelBody.Text = "Body";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(142, 277);
            this.textSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(337, 22);
            this.textSubject.TabIndex = 8;
            this.textSubject.Text = "Authenticated SMTP test";
            // 
            // textBody
            // 
            this.textBody.Location = new System.Drawing.Point(142, 309);
            this.textBody.Margin = new System.Windows.Forms.Padding(4);
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(337, 22);
            this.textBody.TabIndex = 9;
            this.textBody.Text = "Testing authenticated SMTP.";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(383, 11);
            this.labelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 17);
            this.labelPort.TabIndex = 12;
            this.labelPort.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(425, 8);
            this.textPort.Margin = new System.Windows.Forms.Padding(4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(53, 22);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "587";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(142, 245);
            this.textTo.Margin = new System.Windows.Forms.Padding(4);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(336, 22);
            this.textTo.TabIndex = 7;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(15, 248);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 17);
            this.labelTo.TabIndex = 14;
            this.labelTo.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Last Message-ID";
            // 
            // textMessageID
            // 
            this.textMessageID.Location = new System.Drawing.Point(142, 338);
            this.textMessageID.Margin = new System.Windows.Forms.Padding(4);
            this.textMessageID.Name = "textMessageID";
            this.textMessageID.ReadOnly = true;
            this.textMessageID.Size = new System.Drawing.Size(336, 22);
            this.textMessageID.TabIndex = 16;
            this.textMessageID.TabStop = false;
            this.textMessageID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMessageID_KeyDown);
            // 
            // bLog
            // 
            this.bLog.BackColor = System.Drawing.Color.White;
            this.bLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLog.Location = new System.Drawing.Point(345, 397);
            this.bLog.Margin = new System.Windows.Forms.Padding(4);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(134, 28);
            this.bLog.TabIndex = 12;
            this.bLog.TabStop = false;
            this.bLog.Text = "Open SMTP log";
            this.bLog.UseVisualStyleBackColor = false;
            this.bLog.Click += new System.EventHandler(this.BLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDifferentAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkDifferentSender);
            this.groupBox1.Location = new System.Drawing.Point(19, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textDifferentAddress
            // 
            this.textDifferentAddress.Enabled = false;
            this.textDifferentAddress.Location = new System.Drawing.Point(125, 27);
            this.textDifferentAddress.Name = "textDifferentAddress";
            this.textDifferentAddress.Size = new System.Drawing.Size(319, 22);
            this.textDifferentAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "From address";
            // 
            // checkDifferentSender
            // 
            this.checkDifferentSender.AutoSize = true;
            this.checkDifferentSender.Location = new System.Drawing.Point(15, 0);
            this.checkDifferentSender.Name = "checkDifferentSender";
            this.checkDifferentSender.Size = new System.Drawing.Size(345, 21);
            this.checkDifferentSender.TabIndex = 4;
            this.checkDifferentSender.Text = "Specify a different sender than the above account";
            this.checkDifferentSender.UseVisualStyleBackColor = true;
            this.checkDifferentSender.CheckedChanged += new System.EventHandler(this.checkDifferentSender_CheckedChanged);
            // 
            // textFromName
            // 
            this.textFromName.Location = new System.Drawing.Point(165, 214);
            this.textFromName.Name = "textFromName";
            this.textFromName.Size = new System.Drawing.Size(313, 22);
            this.textFromName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "From name (optional)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelUserName);
            this.groupBox2.Controls.Add(this.textPassword);
            this.groupBox2.Controls.Add(this.textUserName);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Location = new System.Drawing.Point(19, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication credentials";
            // 
            // bLogLocation
            // 
            this.bLogLocation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bLogLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogLocation.Location = new System.Drawing.Point(345, 365);
            this.bLogLocation.Name = "bLogLocation";
            this.bLogLocation.Size = new System.Drawing.Size(134, 28);
            this.bLogLocation.TabIndex = 21;
            this.bLogLocation.TabStop = false;
            this.bLogLocation.Text = "Open log location";
            this.bLogLocation.UseVisualStyleBackColor = true;
            this.bLogLocation.Click += new System.EventHandler(this.bLogLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(491, 434);
            this.Controls.Add(this.bLogLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFromName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.textMessageID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.textReceivingServer);
            this.Controls.Add(this.checkForceTLS);
            this.Controls.Add(this.bSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Supa Awesome Auth SMTP Tester v2.1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.CheckBox checkForceTLS;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textReceivingServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textBody;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMessageID;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDifferentAddress;
        private System.Windows.Forms.TextBox textFromName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkDifferentSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bLogLocation;
    }
}

