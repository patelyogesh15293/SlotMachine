namespace SlotMachine
{
    partial class SlotMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachineForm));
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.BetFiftyPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ReelTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelThreePictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JackPotLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.TotalCreditsLabel = new System.Windows.Forms.Label();
            this.WinnerPaidLabel = new System.Windows.Forms.Label();
            this.BetFiveHundredPictureBox = new System.Windows.Forms.PictureBox();
            this.BetHundredPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.PowerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetFiftyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetFiveHundredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHundredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(296, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(50, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // BetFiftyPictureBox
            // 
            this.BetFiftyPictureBox.Image = global::SlotMachine.Properties.Resources.bet50;
            this.BetFiftyPictureBox.Location = new System.Drawing.Point(129, 436);
            this.BetFiftyPictureBox.Name = "BetFiftyPictureBox";
            this.BetFiftyPictureBox.Size = new System.Drawing.Size(46, 50);
            this.BetFiftyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetFiftyPictureBox.TabIndex = 7;
            this.BetFiftyPictureBox.TabStop = false;
            this.BetFiftyPictureBox.Click += new System.EventHandler(this.BetFiftyPictureBox_Click);
            // 
            // ReelOnePictureBox
            // 
            this.ReelOnePictureBox.Image = global::SlotMachine.Properties.Resources.cherry;
            this.ReelOnePictureBox.Location = new System.Drawing.Point(77, 230);
            this.ReelOnePictureBox.Name = "ReelOnePictureBox";
            this.ReelOnePictureBox.Size = new System.Drawing.Size(81, 122);
            this.ReelOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelOnePictureBox.TabIndex = 8;
            this.ReelOnePictureBox.TabStop = false;
            // 
            // ReelTwoPictureBox
            // 
            this.ReelTwoPictureBox.Image = global::SlotMachine.Properties.Resources.bar;
            this.ReelTwoPictureBox.Location = new System.Drawing.Point(190, 230);
            this.ReelTwoPictureBox.Name = "ReelTwoPictureBox";
            this.ReelTwoPictureBox.Size = new System.Drawing.Size(81, 122);
            this.ReelTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelTwoPictureBox.TabIndex = 9;
            this.ReelTwoPictureBox.TabStop = false;
            // 
            // ReelThreePictureBox
            // 
            this.ReelThreePictureBox.Image = global::SlotMachine.Properties.Resources.orange;
            this.ReelThreePictureBox.Location = new System.Drawing.Point(302, 230);
            this.ReelThreePictureBox.Name = "ReelThreePictureBox";
            this.ReelThreePictureBox.Size = new System.Drawing.Size(81, 122);
            this.ReelThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelThreePictureBox.TabIndex = 10;
            this.ReelThreePictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // JackPotLabel
            // 
            this.JackPotLabel.BackColor = System.Drawing.Color.Black;
            this.JackPotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackPotLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JackPotLabel.Location = new System.Drawing.Point(182, 164);
            this.JackPotLabel.Name = "JackPotLabel";
            this.JackPotLabel.Size = new System.Drawing.Size(101, 21);
            this.JackPotLabel.TabIndex = 13;
            this.JackPotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetLabel
            // 
            this.BetLabel.BackColor = System.Drawing.Color.Black;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BetLabel.Location = new System.Drawing.Point(201, 373);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(56, 21);
            this.BetLabel.TabIndex = 14;
            this.BetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCreditsLabel
            // 
            this.TotalCreditsLabel.BackColor = System.Drawing.Color.Black;
            this.TotalCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalCreditsLabel.Location = new System.Drawing.Point(74, 373);
            this.TotalCreditsLabel.Name = "TotalCreditsLabel";
            this.TotalCreditsLabel.Size = new System.Drawing.Size(101, 21);
            this.TotalCreditsLabel.TabIndex = 16;
            this.TotalCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinnerPaidLabel
            // 
            this.WinnerPaidLabel.BackColor = System.Drawing.Color.Black;
            this.WinnerPaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerPaidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WinnerPaidLabel.Location = new System.Drawing.Point(282, 373);
            this.WinnerPaidLabel.Name = "WinnerPaidLabel";
            this.WinnerPaidLabel.Size = new System.Drawing.Size(101, 21);
            this.WinnerPaidLabel.TabIndex = 17;
            this.WinnerPaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetFiveHundredPictureBox
            // 
            this.BetFiveHundredPictureBox.Image = global::SlotMachine.Properties.Resources.bet500;
            this.BetFiveHundredPictureBox.Location = new System.Drawing.Point(237, 436);
            this.BetFiveHundredPictureBox.Name = "BetFiveHundredPictureBox";
            this.BetFiveHundredPictureBox.Size = new System.Drawing.Size(46, 50);
            this.BetFiveHundredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetFiveHundredPictureBox.TabIndex = 18;
            this.BetFiveHundredPictureBox.TabStop = false;
            this.BetFiveHundredPictureBox.Click += new System.EventHandler(this.BetFiveHundredPictureBox_Click);
            // 
            // BetHundredPictureBox
            // 
            this.BetHundredPictureBox.Image = global::SlotMachine.Properties.Resources.bet100;
            this.BetHundredPictureBox.Location = new System.Drawing.Point(185, 436);
            this.BetHundredPictureBox.Name = "BetHundredPictureBox";
            this.BetHundredPictureBox.Size = new System.Drawing.Size(46, 50);
            this.BetHundredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetHundredPictureBox.TabIndex = 19;
            this.BetHundredPictureBox.TabStop = false;
            this.BetHundredPictureBox.Click += new System.EventHandler(this.BetHundredPictureBox_Click);
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetPictureBox.Location = new System.Drawing.Point(77, 436);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(46, 50);
            this.ResetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResetPictureBox.TabIndex = 21;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // PowerPictureBox
            // 
            this.PowerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PowerPictureBox.Image")));
            this.PowerPictureBox.Location = new System.Drawing.Point(352, 436);
            this.PowerPictureBox.Name = "PowerPictureBox";
            this.PowerPictureBox.Size = new System.Drawing.Size(46, 50);
            this.PowerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PowerPictureBox.TabIndex = 20;
            this.PowerPictureBox.TabStop = false;
            this.PowerPictureBox.Click += new System.EventHandler(this.PowerPictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.PowerPictureBox);
            this.Controls.Add(this.BetHundredPictureBox);
            this.Controls.Add(this.BetFiveHundredPictureBox);
            this.Controls.Add(this.WinnerPaidLabel);
            this.Controls.Add(this.TotalCreditsLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.JackPotLabel);
            this.Controls.Add(this.ReelThreePictureBox);
            this.Controls.Add(this.ReelTwoPictureBox);
            this.Controls.Add(this.ReelOnePictureBox);
            this.Controls.Add(this.BetFiftyPictureBox);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetFiftyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetFiveHundredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHundredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox BetFiftyPictureBox;
        private System.Windows.Forms.PictureBox ReelOnePictureBox;
        private System.Windows.Forms.PictureBox ReelTwoPictureBox;
        private System.Windows.Forms.PictureBox ReelThreePictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label JackPotLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label TotalCreditsLabel;
        private System.Windows.Forms.Label WinnerPaidLabel;
        private System.Windows.Forms.PictureBox BetFiveHundredPictureBox;
        private System.Windows.Forms.PictureBox BetHundredPictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox PowerPictureBox;
    }
}