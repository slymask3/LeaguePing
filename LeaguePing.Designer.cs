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
            this.labelPing = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxServers = new System.Windows.Forms.GroupBox();
            this.radioButtonNA = new System.Windows.Forms.RadioButton();
            this.radioButtonEUW = new System.Windows.Forms.RadioButton();
            this.labelLowest = new System.Windows.Forms.Label();
            this.labelHighest = new System.Windows.Forms.Label();
            this.groupBoxServers.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPing.Location = new System.Drawing.Point(13, 13);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(69, 13);
            this.labelPing.TabIndex = 0;
            this.labelPing.Text = "Ping = 0ms";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 43);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(113, 43);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
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
            this.groupBoxServers.Size = new System.Drawing.Size(200, 155);
            this.groupBoxServers.TabIndex = 5;
            this.groupBoxServers.TabStop = false;
            this.groupBoxServers.Text = "Servers";
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
            // labelLowest
            // 
            this.labelLowest.AutoSize = true;
            this.labelLowest.Location = new System.Drawing.Point(16, 136);
            this.labelLowest.Name = "labelLowest";
            this.labelLowest.Size = new System.Drawing.Size(178, 13);
            this.labelLowest.TabIndex = 6;
            this.labelLowest.Text = "Lowest Ping in Current Session: 0ms";
            // 
            // labelHighest
            // 
            this.labelHighest.AutoSize = true;
            this.labelHighest.Location = new System.Drawing.Point(16, 164);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(180, 13);
            this.labelHighest.TabIndex = 7;
            this.labelHighest.Text = "Highest Ping in Current Session: 0ms";
            // 
            // LeaguePing
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(452, 266);
            this.Controls.Add(this.labelHighest);
            this.Controls.Add(this.labelLowest);
            this.Controls.Add(this.groupBoxServers);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelPing);
            this.MaximizeBox = false;
            this.Name = "LeaguePing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends Ping Checker";
            this.Load += new System.EventHandler(this.LeaguePing_Load);
            this.groupBoxServers.ResumeLayout(false);
            this.groupBoxServers.PerformLayout();
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
    }
}

