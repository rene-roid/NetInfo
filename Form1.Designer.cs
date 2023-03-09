namespace NetSpy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            iphost = new Label();
            ipgateway = new Label();
            ssid = new Label();
            ssidstatus = new Label();
            macaddress = new Label();
            internetconnection = new Label();
            username = new Label();
            hostname = new Label();
            virtualbox = new Label();
            virtualboxversion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 50);
            label1.TabIndex = 0;
            label1.Text = "Net Info \U0001f919";
            label1.Click += label1_Click;
            // 
            // iphost
            // 
            iphost.AutoSize = true;
            iphost.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iphost.Location = new Point(12, 107);
            iphost.Name = "iphost";
            iphost.Size = new Size(80, 25);
            iphost.TabIndex = 1;
            iphost.Text = "Ip Host: ";
            iphost.Click += iphost_Click;
            // 
            // ipgateway
            // 
            ipgateway.AutoSize = true;
            ipgateway.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ipgateway.Location = new Point(12, 167);
            ipgateway.Name = "ipgateway";
            ipgateway.Size = new Size(104, 25);
            ipgateway.TabIndex = 2;
            ipgateway.Text = "Ip Gateway:";
            // 
            // ssid
            // 
            ssid.AutoSize = true;
            ssid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ssid.Location = new Point(12, 224);
            ssid.Name = "ssid";
            ssid.Size = new Size(54, 25);
            ssid.TabIndex = 3;
            ssid.Text = "SSID:";
            // 
            // ssidstatus
            // 
            ssidstatus.AutoSize = true;
            ssidstatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ssidstatus.Location = new Point(12, 276);
            ssidstatus.Name = "ssidstatus";
            ssidstatus.Size = new Size(107, 25);
            ssidstatus.TabIndex = 4;
            ssidstatus.Text = "SSID Status:";
            // 
            // macaddress
            // 
            macaddress.AutoSize = true;
            macaddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            macaddress.Location = new Point(12, 330);
            macaddress.Name = "macaddress";
            macaddress.Size = new Size(119, 25);
            macaddress.TabIndex = 5;
            macaddress.Text = "Mac Address:";
            // 
            // internetconnection
            // 
            internetconnection.AutoSize = true;
            internetconnection.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            internetconnection.Location = new Point(12, 380);
            internetconnection.Name = "internetconnection";
            internetconnection.Size = new Size(172, 25);
            internetconnection.TabIndex = 6;
            internetconnection.Text = "Internet Connection:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(389, 107);
            username.Name = "username";
            username.Size = new Size(100, 25);
            username.TabIndex = 7;
            username.Text = "Username: ";
            username.Click += label2_Click;
            // 
            // hostname
            // 
            hostname.AutoSize = true;
            hostname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            hostname.Location = new Point(391, 167);
            hostname.Name = "hostname";
            hostname.Size = new Size(98, 25);
            hostname.TabIndex = 8;
            hostname.Text = "Hostname:";
            // 
            // virtualbox
            // 
            virtualbox.AutoSize = true;
            virtualbox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            virtualbox.Location = new Point(389, 224);
            virtualbox.Name = "virtualbox";
            virtualbox.Size = new Size(136, 25);
            virtualbox.TabIndex = 9;
            virtualbox.Text = "Has Virtualbox: ";
            // 
            // virtualboxversion
            // 
            virtualboxversion.AutoSize = true;
            virtualboxversion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            virtualboxversion.Location = new Point(389, 276);
            virtualboxversion.Name = "virtualboxversion";
            virtualboxversion.Size = new Size(159, 25);
            virtualboxversion.TabIndex = 10;
            virtualboxversion.Text = "Virtualbox Version:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(virtualboxversion);
            Controls.Add(virtualbox);
            Controls.Add(hostname);
            Controls.Add(username);
            Controls.Add(internetconnection);
            Controls.Add(macaddress);
            Controls.Add(ssidstatus);
            Controls.Add(ssid);
            Controls.Add(ipgateway);
            Controls.Add(iphost);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label iphost;
        private Label ipgateway;
        private Label ssid;
        private Label ssidstatus;
        private Label macaddress;
        private Label internetconnection;
        private Label username;
        private Label hostname;
        private Label virtualbox;
        private Label virtualboxversion;
    }
}