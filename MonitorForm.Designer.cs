namespace ConcurrentTransSimulator
{
    partial class Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulator));
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.pnlbottom.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbottom
            // 
            this.pnlbottom.Controls.Add(this.rtbMessage);
            this.pnlbottom.Location = new System.Drawing.Point(-1, 245);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(856, 336);
            this.pnlbottom.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.cbPort);
            this.pnlTopLeft.Controls.Add(this.lblPort);
            this.pnlTopLeft.Controls.Add(this.lblDatabase);
            this.pnlTopLeft.Controls.Add(this.txbPassword);
            this.pnlTopLeft.Controls.Add(this.btnNew);
            this.pnlTopLeft.Controls.Add(this.btnCancel);
            this.pnlTopLeft.Controls.Add(this.btnConnect);
            this.pnlTopLeft.Controls.Add(this.txbLogin);
            this.pnlTopLeft.Controls.Add(this.txbDatabase);
            this.pnlTopLeft.Controls.Add(this.lblLogin);
            this.pnlTopLeft.Controls.Add(this.lblPassword);
            this.pnlTopLeft.Controls.Add(this.txbServer);
            this.pnlTopLeft.Controls.Add(this.lblServer);
            this.pnlTopLeft.Location = new System.Drawing.Point(-1, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(504, 239);
            this.pnlTopLeft.TabIndex = 1;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatabase.Location = new System.Drawing.Point(13, 62);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(68, 19);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Database:";
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.Location = new System.Drawing.Point(109, 147);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(251, 25);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNew.Location = new System.Drawing.Point(38, 199);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(285, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Location = new System.Drawing.Point(166, 199);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLogin.Location = new System.Drawing.Point(109, 102);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(251, 25);
            this.txbLogin.TabIndex = 3;
            // 
            // txbDatabase
            // 
            this.txbDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDatabase.Location = new System.Drawing.Point(109, 59);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(251, 25);
            this.txbDatabase.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogin.Location = new System.Drawing.Point(13, 104);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 19);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Location = new System.Drawing.Point(13, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txbServer
            // 
            this.txbServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbServer.Location = new System.Drawing.Point(109, 16);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(251, 25);
            this.txbServer.TabIndex = 0;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServer.Location = new System.Drawing.Point(13, 18);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(89, 19);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server Name:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(366, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 17);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port:";
            // 
            // cbPort
            // 
            this.cbPort.FormatString = "N0";
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "1433"});
            this.cbPort.Location = new System.Drawing.Point(408, 16);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(80, 25);
            this.cbPort.Sorted = true;
            this.cbPort.TabIndex = 1;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbMessage.Location = new System.Drawing.Point(0, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(856, 332);
            this.rtbMessage.TabIndex = 8;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 581);
            this.Controls.Add(this.pnlTopLeft);
            this.Controls.Add(this.pnlbottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulator";
            this.Text = "Multiple Concurrent Transactions Monitor";
            this.Load += new System.EventHandler(this.Simulator_Load);
            this.pnlbottom.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

