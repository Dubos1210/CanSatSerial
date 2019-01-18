namespace CanSatSerial
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.phaseLblLabel = new System.Windows.Forms.Label();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.gps2Label = new System.Windows.Forms.Label();
            this.gps1Label = new System.Windows.Forms.Label();
            this.gpsLblLabel = new System.Windows.Forms.Label();
            this.heightbarLabel = new System.Windows.Forms.Label();
            this.heightbarLblLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLblLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.speedLblLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phaseLblLabel
            // 
            this.phaseLblLabel.AutoSize = true;
            this.phaseLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phaseLblLabel.Location = new System.Drawing.Point(9, 59);
            this.phaseLblLabel.Name = "phaseLblLabel";
            this.phaseLblLabel.Size = new System.Drawing.Size(48, 17);
            this.phaseLblLabel.TabIndex = 17;
            this.phaseLblLabel.Text = "Фаза:";
            // 
            // phaseLabel
            // 
            this.phaseLabel.AutoSize = true;
            this.phaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phaseLabel.Location = new System.Drawing.Point(6, 79);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(29, 31);
            this.phaseLabel.TabIndex = 16;
            this.phaseLabel.Text = "0";
            // 
            // gps2Label
            // 
            this.gps2Label.AutoSize = true;
            this.gps2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gps2Label.Location = new System.Drawing.Point(227, 92);
            this.gps2Label.Name = "gps2Label";
            this.gps2Label.Size = new System.Drawing.Size(88, 17);
            this.gps2Label.TabIndex = 15;
            this.gps2Label.Text = "0000000000";
            // 
            // gps1Label
            // 
            this.gps1Label.AutoSize = true;
            this.gps1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gps1Label.Location = new System.Drawing.Point(227, 78);
            this.gps1Label.Name = "gps1Label";
            this.gps1Label.Size = new System.Drawing.Size(88, 17);
            this.gps1Label.TabIndex = 14;
            this.gps1Label.Text = "0000000000";
            // 
            // gpsLblLabel
            // 
            this.gpsLblLabel.AutoSize = true;
            this.gpsLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpsLblLabel.Location = new System.Drawing.Point(227, 63);
            this.gpsLblLabel.Name = "gpsLblLabel";
            this.gpsLblLabel.Size = new System.Drawing.Size(32, 13);
            this.gpsLblLabel.TabIndex = 13;
            this.gpsLblLabel.Text = "GPS:";
            // 
            // heightbarLabel
            // 
            this.heightbarLabel.AutoSize = true;
            this.heightbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightbarLabel.Location = new System.Drawing.Point(6, 26);
            this.heightbarLabel.Name = "heightbarLabel";
            this.heightbarLabel.Size = new System.Drawing.Size(29, 31);
            this.heightbarLabel.TabIndex = 12;
            this.heightbarLabel.Text = "0";
            // 
            // heightbarLblLabel
            // 
            this.heightbarLblLabel.AutoSize = true;
            this.heightbarLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightbarLblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heightbarLblLabel.Location = new System.Drawing.Point(9, 9);
            this.heightbarLblLabel.Name = "heightbarLblLabel";
            this.heightbarLblLabel.Size = new System.Drawing.Size(61, 17);
            this.heightbarLblLabel.TabIndex = 11;
            this.heightbarLblLabel.Text = "Высота:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(133, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(29, 31);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "0";
            // 
            // timeLblLabel
            // 
            this.timeLblLabel.AutoSize = true;
            this.timeLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLblLabel.Location = new System.Drawing.Point(136, 9);
            this.timeLblLabel.Name = "timeLblLabel";
            this.timeLblLabel.Size = new System.Drawing.Size(54, 17);
            this.timeLblLabel.TabIndex = 9;
            this.timeLblLabel.Text = "Время:";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.ForeColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(230, 61);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(92, 48);
            this.reset.TabIndex = 18;
            this.reset.Text = "Сброс графика";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // speedLblLabel
            // 
            this.speedLblLabel.AutoSize = true;
            this.speedLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLblLabel.Location = new System.Drawing.Point(136, 59);
            this.speedLblLabel.Name = "speedLblLabel";
            this.speedLblLabel.Size = new System.Drawing.Size(40, 17);
            this.speedLblLabel.TabIndex = 19;
            this.speedLblLabel.Text = "Vсп.:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(115, 78);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(29, 31);
            this.speedLabel.TabIndex = 20;
            this.speedLabel.Text = "0";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 111);
            this.ControlBox = false;
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedLblLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.phaseLblLabel);
            this.Controls.Add(this.phaseLabel);
            this.Controls.Add(this.gps2Label);
            this.Controls.Add(this.gps1Label);
            this.Controls.Add(this.gpsLblLabel);
            this.Controls.Add(this.heightbarLabel);
            this.Controls.Add(this.heightbarLblLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeLblLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phaseLblLabel;
        private System.Windows.Forms.Label gpsLblLabel;
        private System.Windows.Forms.Label heightbarLblLabel;
        private System.Windows.Forms.Label timeLblLabel;
        public System.Windows.Forms.Label phaseLabel;
        public System.Windows.Forms.Label gps2Label;
        public System.Windows.Forms.Label gps1Label;
        public System.Windows.Forms.Label heightbarLabel;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label speedLblLabel;
        public System.Windows.Forms.Label speedLabel;
    }
}