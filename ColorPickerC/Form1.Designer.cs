namespace ColorPickerC
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blueServer = new System.Windows.Forms.TextBox();
            this.greenServer = new System.Windows.Forms.TextBox();
            this.redServer = new System.Windows.Forms.TextBox();
            this.panelServer = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.IPServer = new System.Windows.Forms.TextBox();
            this.portServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKirim = new System.Windows.Forms.Button();
            this.btnPilih = new System.Windows.Forms.Button();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.blueClient = new System.Windows.Forms.TextBox();
            this.greenClient = new System.Windows.Forms.TextBox();
            this.redClient = new System.Windows.Forms.TextBox();
            this.IPClient = new System.Windows.Forms.TextBox();
            this.portClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelWarnaClient = new System.Windows.Forms.Panel();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.timerClient = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.blueServer);
            this.tabPage1.Controls.Add(this.greenServer);
            this.tabPage1.Controls.Add(this.redServer);
            this.tabPage1.Controls.Add(this.panelServer);
            this.tabPage1.Controls.Add(this.btnListen);
            this.tabPage1.Controls.Add(this.IPServer);
            this.tabPage1.Controls.Add(this.portServer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // blueServer
            // 
            this.blueServer.Enabled = false;
            this.blueServer.Location = new System.Drawing.Point(380, 316);
            this.blueServer.Name = "blueServer";
            this.blueServer.Size = new System.Drawing.Size(100, 20);
            this.blueServer.TabIndex = 9;
            // 
            // greenServer
            // 
            this.greenServer.Enabled = false;
            this.greenServer.Location = new System.Drawing.Point(234, 316);
            this.greenServer.Name = "greenServer";
            this.greenServer.Size = new System.Drawing.Size(100, 20);
            this.greenServer.TabIndex = 8;
            // 
            // redServer
            // 
            this.redServer.Enabled = false;
            this.redServer.Location = new System.Drawing.Point(89, 316);
            this.redServer.Name = "redServer";
            this.redServer.Size = new System.Drawing.Size(100, 20);
            this.redServer.TabIndex = 7;
            // 
            // panelServer
            // 
            this.panelServer.Location = new System.Drawing.Point(89, 79);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(391, 206);
            this.panelServer.TabIndex = 6;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(405, 23);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // IPServer
            // 
            this.IPServer.Location = new System.Drawing.Point(279, 25);
            this.IPServer.Name = "IPServer";
            this.IPServer.Size = new System.Drawing.Size(100, 20);
            this.IPServer.TabIndex = 4;
            this.IPServer.Text = "192.168.1";
            // 
            // portServer
            // 
            this.portServer.Location = new System.Drawing.Point(118, 25);
            this.portServer.Name = "portServer";
            this.portServer.Size = new System.Drawing.Size(69, 20);
            this.portServer.TabIndex = 3;
            this.portServer.Text = "16375";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKirim);
            this.tabPage2.Controls.Add(this.btnPilih);
            this.tabPage2.Controls.Add(this.trackBlue);
            this.tabPage2.Controls.Add(this.trackGreen);
            this.tabPage2.Controls.Add(this.trackRed);
            this.tabPage2.Controls.Add(this.blueClient);
            this.tabPage2.Controls.Add(this.greenClient);
            this.tabPage2.Controls.Add(this.redClient);
            this.tabPage2.Controls.Add(this.IPClient);
            this.tabPage2.Controls.Add(this.portClient);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.panelWarnaClient);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(494, 339);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 12;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnPilih
            // 
            this.btnPilih.Location = new System.Drawing.Point(337, 339);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(75, 23);
            this.btnPilih.TabIndex = 11;
            this.btnPilih.Text = "Set Color";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // trackBlue
            // 
            this.trackBlue.Location = new System.Drawing.Point(331, 261);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(245, 45);
            this.trackBlue.TabIndex = 10;
            // 
            // trackGreen
            // 
            this.trackGreen.Location = new System.Drawing.Point(331, 182);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(245, 45);
            this.trackGreen.TabIndex = 9;
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(331, 96);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(245, 45);
            this.trackRed.TabIndex = 8;
            // 
            // blueClient
            // 
            this.blueClient.Location = new System.Drawing.Point(240, 339);
            this.blueClient.Name = "blueClient";
            this.blueClient.Size = new System.Drawing.Size(69, 20);
            this.blueClient.TabIndex = 7;
            // 
            // greenClient
            // 
            this.greenClient.Location = new System.Drawing.Point(142, 339);
            this.greenClient.Name = "greenClient";
            this.greenClient.Size = new System.Drawing.Size(68, 20);
            this.greenClient.TabIndex = 6;
            // 
            // redClient
            // 
            this.redClient.Location = new System.Drawing.Point(35, 339);
            this.redClient.Name = "redClient";
            this.redClient.Size = new System.Drawing.Size(67, 20);
            this.redClient.TabIndex = 5;
            // 
            // IPClient
            // 
            this.IPClient.Location = new System.Drawing.Point(494, 49);
            this.IPClient.Name = "IPClient";
            this.IPClient.Size = new System.Drawing.Size(82, 20);
            this.IPClient.TabIndex = 4;
            this.IPClient.Text = "192.168.1";
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(360, 49);
            this.portClient.Name = "portClient";
            this.portClient.Size = new System.Drawing.Size(52, 20);
            this.portClient.TabIndex = 3;
            this.portClient.Text = "16375";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // panelWarnaClient
            // 
            this.panelWarnaClient.Location = new System.Drawing.Point(35, 52);
            this.panelWarnaClient.Name = "panelWarnaClient";
            this.panelWarnaClient.Size = new System.Drawing.Size(274, 270);
            this.panelWarnaClient.TabIndex = 0;
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // timerClient
            // 
            this.timerClient.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox blueServer;
        private System.Windows.Forms.TextBox greenServer;
        private System.Windows.Forms.TextBox redServer;
        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox IPServer;
        private System.Windows.Forms.TextBox portServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelWarnaClient;
        private System.Windows.Forms.TextBox IPClient;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Button btnPilih;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TextBox blueClient;
        private System.Windows.Forms.TextBox greenClient;
        private System.Windows.Forms.TextBox redClient;
        private System.Windows.Forms.Timer timerServer;
        private System.Windows.Forms.Timer timerClient;
    }
}

