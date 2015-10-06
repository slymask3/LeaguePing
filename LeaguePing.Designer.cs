namespace LeaguePing
{
    partial class LeaguePing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaguePing));
            this.labelPing = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxServers = new System.Windows.Forms.GroupBox();
            this.radioButtonEUW = new System.Windows.Forms.RadioButton();
            this.radioButtonNA = new System.Windows.Forms.RadioButton();
            this.labelLowest = new System.Windows.Forms.Label();
            this.labelHighest = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.groupBoxPingHistory = new System.Windows.Forms.GroupBox();
            this.labelPing9 = new System.Windows.Forms.Label();
            this.labelPing8 = new System.Windows.Forms.Label();
            this.labelPing7 = new System.Windows.Forms.Label();
            this.labelPing6 = new System.Windows.Forms.Label();
            this.labelPing5 = new System.Windows.Forms.Label();
            this.labelPing4 = new System.Windows.Forms.Label();
            this.labelPing3 = new System.Windows.Forms.Label();
            this.labelPing2 = new System.Windows.Forms.Label();
            this.labelPing1 = new System.Windows.Forms.Label();
            this.labelPing0 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxPing = new System.Windows.Forms.PictureBox();
            this.groupBoxServers.SuspendLayout();
            this.groupBoxPingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPing)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPing.Location = new System.Drawing.Point(12, 9);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(235, 13);
            this.labelPing.TabIndex = 0;
            this.labelPing.Text = "Currently not sending any ping requests.";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 43);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(82, 43);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(61, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxServers
            // 
            this.groupBoxServers.Controls.Add(this.radioButtonEUW);
            this.groupBoxServers.Controls.Add(this.radioButtonNA);
            this.groupBoxServers.Location = new System.Drawing.Point(240, 43);
            this.groupBoxServers.Name = "groupBoxServers";
            this.groupBoxServers.Size = new System.Drawing.Size(153, 273);
            this.groupBoxServers.TabIndex = 5;
            this.groupBoxServers.TabStop = false;
            this.groupBoxServers.Text = "Servers";
            // 
            // radioButtonEUW
            // 
            this.radioButtonEUW.AutoSize = true;
            this.radioButtonEUW.Location = new System.Drawing.Point(7, 44);
            this.radioButtonEUW.Name = "radioButtonEUW";
            this.radioButtonEUW.Size = new System.Drawing.Size(87, 17);
            this.radioButtonEUW.TabIndex = 1;
            this.radioButtonEUW.TabStop = true;
            this.radioButtonEUW.Text = "Europe West";
            this.radioButtonEUW.UseVisualStyleBackColor = true;
            this.radioButtonEUW.CheckedChanged += new System.EventHandler(this.radioButtonEUW_CheckedChanged);
            // 
            // radioButtonNA
            // 
            this.radioButtonNA.AutoSize = true;
            this.radioButtonNA.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNA.Name = "radioButtonNA";
            this.radioButtonNA.Size = new System.Drawing.Size(92, 17);
            this.radioButtonNA.TabIndex = 0;
            this.radioButtonNA.TabStop = true;
            this.radioButtonNA.Text = "North America";
            this.radioButtonNA.UseVisualStyleBackColor = true;
            this.radioButtonNA.CheckedChanged += new System.EventHandler(this.radioButtonNA_CheckedChanged);
            // 
            // labelLowest
            // 
            this.labelLowest.AutoSize = true;
            this.labelLowest.Location = new System.Drawing.Point(12, 87);
            this.labelLowest.Name = "labelLowest";
            this.labelLowest.Size = new System.Drawing.Size(178, 13);
            this.labelLowest.TabIndex = 6;
            this.labelLowest.Text = "Lowest Ping in Current Session: 0ms";
            // 
            // labelHighest
            // 
            this.labelHighest.AutoSize = true;
            this.labelHighest.Location = new System.Drawing.Point(12, 109);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(180, 13);
            this.labelHighest.TabIndex = 7;
            this.labelHighest.Text = "Highest Ping in Current Session: 0ms";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(12, 131);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(184, 13);
            this.labelAverage.TabIndex = 9;
            this.labelAverage.Text = "Average Ping in Current Session: 0ms";
            // 
            // groupBoxPingHistory
            // 
            this.groupBoxPingHistory.Controls.Add(this.labelPing9);
            this.groupBoxPingHistory.Controls.Add(this.labelPing8);
            this.groupBoxPingHistory.Controls.Add(this.labelPing7);
            this.groupBoxPingHistory.Controls.Add(this.labelPing6);
            this.groupBoxPingHistory.Controls.Add(this.labelPing5);
            this.groupBoxPingHistory.Controls.Add(this.labelPing4);
            this.groupBoxPingHistory.Controls.Add(this.labelPing3);
            this.groupBoxPingHistory.Controls.Add(this.labelPing2);
            this.groupBoxPingHistory.Controls.Add(this.labelPing1);
            this.groupBoxPingHistory.Controls.Add(this.labelPing0);
            this.groupBoxPingHistory.Location = new System.Drawing.Point(15, 158);
            this.groupBoxPingHistory.Name = "groupBoxPingHistory";
            this.groupBoxPingHistory.Size = new System.Drawing.Size(203, 158);
            this.groupBoxPingHistory.TabIndex = 10;
            this.groupBoxPingHistory.TabStop = false;
            this.groupBoxPingHistory.Text = "Ping History";
            // 
            // labelPing9
            // 
            this.labelPing9.AutoSize = true;
            this.labelPing9.Location = new System.Drawing.Point(7, 137);
            this.labelPing9.Name = "labelPing9";
            this.labelPing9.Size = new System.Drawing.Size(0, 13);
            this.labelPing9.TabIndex = 9;
            // 
            // labelPing8
            // 
            this.labelPing8.AutoSize = true;
            this.labelPing8.Location = new System.Drawing.Point(7, 124);
            this.labelPing8.Name = "labelPing8";
            this.labelPing8.Size = new System.Drawing.Size(0, 13);
            this.labelPing8.TabIndex = 8;
            // 
            // labelPing7
            // 
            this.labelPing7.AutoSize = true;
            this.labelPing7.Location = new System.Drawing.Point(7, 111);
            this.labelPing7.Name = "labelPing7";
            this.labelPing7.Size = new System.Drawing.Size(0, 13);
            this.labelPing7.TabIndex = 7;
            // 
            // labelPing6
            // 
            this.labelPing6.AutoSize = true;
            this.labelPing6.Location = new System.Drawing.Point(7, 98);
            this.labelPing6.Name = "labelPing6";
            this.labelPing6.Size = new System.Drawing.Size(0, 13);
            this.labelPing6.TabIndex = 6;
            // 
            // labelPing5
            // 
            this.labelPing5.AutoSize = true;
            this.labelPing5.Location = new System.Drawing.Point(7, 85);
            this.labelPing5.Name = "labelPing5";
            this.labelPing5.Size = new System.Drawing.Size(0, 13);
            this.labelPing5.TabIndex = 5;
            // 
            // labelPing4
            // 
            this.labelPing4.AutoSize = true;
            this.labelPing4.Location = new System.Drawing.Point(7, 72);
            this.labelPing4.Name = "labelPing4";
            this.labelPing4.Size = new System.Drawing.Size(0, 13);
            this.labelPing4.TabIndex = 4;
            // 
            // labelPing3
            // 
            this.labelPing3.AutoSize = true;
            this.labelPing3.Location = new System.Drawing.Point(7, 59);
            this.labelPing3.Name = "labelPing3";
            this.labelPing3.Size = new System.Drawing.Size(0, 13);
            this.labelPing3.TabIndex = 3;
            // 
            // labelPing2
            // 
            this.labelPing2.AutoSize = true;
            this.labelPing2.Location = new System.Drawing.Point(7, 46);
            this.labelPing2.Name = "labelPing2";
            this.labelPing2.Size = new System.Drawing.Size(0, 13);
            this.labelPing2.TabIndex = 2;
            // 
            // labelPing1
            // 
            this.labelPing1.AutoSize = true;
            this.labelPing1.Location = new System.Drawing.Point(7, 33);
            this.labelPing1.Name = "labelPing1";
            this.labelPing1.Size = new System.Drawing.Size(0, 13);
            this.labelPing1.TabIndex = 1;
            // 
            // labelPing0
            // 
            this.labelPing0.AutoSize = true;
            this.labelPing0.Location = new System.Drawing.Point(7, 20);
            this.labelPing0.Name = "labelPing0";
            this.labelPing0.Size = new System.Drawing.Size(0, 13);
            this.labelPing0.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(149, 43);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(61, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBoxPing
            // 
            this.pictureBoxPing.Image = global::LeaguePing.Properties.Resources.pingGray;
            this.pictureBoxPing.Location = new System.Drawing.Point(380, 6);
            this.pictureBoxPing.Name = "pictureBoxPing";
            this.pictureBoxPing.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxPing.TabIndex = 12;
            this.pictureBoxPing.TabStop = false;
            // 
            // LeaguePing
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(408, 327);
            this.Controls.Add(this.pictureBoxPing);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBoxPingHistory);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelHighest);
            this.Controls.Add(this.labelLowest);
            this.Controls.Add(this.groupBoxServers);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LeaguePing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends Ping Checker";
            this.Load += new System.EventHandler(this.LeaguePing_Load);
            this.groupBoxServers.ResumeLayout(false);
            this.groupBoxServers.PerformLayout();
            this.groupBoxPingHistory.ResumeLayout(false);
            this.groupBoxPingHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxServers;
        private System.Windows.Forms.RadioButton radioButtonEUW;
        private System.Windows.Forms.RadioButton radioButtonNA;
        private System.Windows.Forms.Label labelLowest;
        private System.Windows.Forms.Label labelHighest;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.GroupBox groupBoxPingHistory;
        private System.Windows.Forms.Label labelPing0;
        private System.Windows.Forms.Label labelPing9;
        private System.Windows.Forms.Label labelPing8;
        private System.Windows.Forms.Label labelPing7;
        private System.Windows.Forms.Label labelPing6;
        private System.Windows.Forms.Label labelPing5;
        private System.Windows.Forms.Label labelPing4;
        private System.Windows.Forms.Label labelPing3;
        private System.Windows.Forms.Label labelPing2;
        private System.Windows.Forms.Label labelPing1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBoxPing;
    }
}

