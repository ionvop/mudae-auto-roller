namespace _20220512 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.txtCountdown = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.boxRoll = new System.Windows.Forms.ComboBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDelayTimer = new System.Windows.Forms.Label();
            this.lblCountLeft = new System.Windows.Forms.Label();
            this.lblCountdownTimer = new System.Windows.Forms.Label();
            this.lblCEvent = new System.Windows.Forms.Label();
            this.lblSpaceEvent = new System.Windows.Forms.Label();
            this.txtSpaceEvent = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(3, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(110, 15);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Status: Not running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(12, 9);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(97, 15);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Countdown (ms)";
            // 
            // txtCountdown
            // 
            this.txtCountdown.Location = new System.Drawing.Point(12, 27);
            this.txtCountdown.Name = "txtCountdown";
            this.txtCountdown.Size = new System.Drawing.Size(100, 23);
            this.txtCountdown.TabIndex = 3;
            this.txtCountdown.Text = "3000";
            this.txtCountdown.TextChanged += new System.EventHandler(this.txtCountdown_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 68);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(191, 15);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count (leave blank for continuous)";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 86);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 23);
            this.txtCount.TabIndex = 5;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(12, 127);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(27, 15);
            this.lblRoll.TabIndex = 6;
            this.lblRoll.Text = "Roll";
            // 
            // boxRoll
            // 
            this.boxRoll.FormattingEnabled = true;
            this.boxRoll.Items.AddRange(new object[] {
            "/wx",
            "/wa",
            "/wg",
            "/hx",
            "/ha",
            "/hg",
            "/mx",
            "/ma",
            "/mg"});
            this.boxRoll.Location = new System.Drawing.Point(12, 145);
            this.boxRoll.Name = "boxRoll";
            this.boxRoll.Size = new System.Drawing.Size(121, 23);
            this.boxRoll.TabIndex = 7;
            this.boxRoll.Text = "/wx";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(12, 186);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(63, 15);
            this.lblDelay.TabIndex = 8;
            this.lblDelay.Text = "Delay (ms)";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(12, 204);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 23);
            this.txtDelay.TabIndex = 9;
            this.txtDelay.Text = "2500";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDelayTimer);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblCountLeft);
            this.panel1.Controls.Add(this.lblCountdownTimer);
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // lblDelayTimer
            // 
            this.lblDelayTimer.AutoSize = true;
            this.lblDelayTimer.Location = new System.Drawing.Point(3, 45);
            this.lblDelayTimer.Name = "lblDelayTimer";
            this.lblDelayTimer.Size = new System.Drawing.Size(48, 15);
            this.lblDelayTimer.TabIndex = 13;
            this.lblDelayTimer.Text = "Delay: 0";
            // 
            // lblCountLeft
            // 
            this.lblCountLeft.AutoSize = true;
            this.lblCountLeft.Location = new System.Drawing.Point(3, 30);
            this.lblCountLeft.Name = "lblCountLeft";
            this.lblCountLeft.Size = new System.Drawing.Size(52, 15);
            this.lblCountLeft.TabIndex = 12;
            this.lblCountLeft.Text = "Count: 0";
            // 
            // lblCountdownTimer
            // 
            this.lblCountdownTimer.AutoSize = true;
            this.lblCountdownTimer.Location = new System.Drawing.Point(3, 15);
            this.lblCountdownTimer.Name = "lblCountdownTimer";
            this.lblCountdownTimer.Size = new System.Drawing.Size(82, 15);
            this.lblCountdownTimer.TabIndex = 11;
            this.lblCountdownTimer.Text = "Countdown: 0";
            // 
            // lblCEvent
            // 
            this.lblCEvent.AutoSize = true;
            this.lblCEvent.Location = new System.Drawing.Point(12, 245);
            this.lblCEvent.Name = "lblCEvent";
            this.lblCEvent.Size = new System.Drawing.Size(85, 15);
            this.lblCEvent.TabIndex = 12;
            this.lblCEvent.Text = "Press C to stop";
            // 
            // lblSpaceEvent
            // 
            this.lblSpaceEvent.AutoSize = true;
            this.lblSpaceEvent.Location = new System.Drawing.Point(212, 127);
            this.lblSpaceEvent.Name = "lblSpaceEvent";
            this.lblSpaceEvent.Size = new System.Drawing.Size(112, 15);
            this.lblSpaceEvent.TabIndex = 13;
            this.lblSpaceEvent.Text = "Press space to send:";
            // 
            // txtSpaceEvent
            // 
            this.txtSpaceEvent.Location = new System.Drawing.Point(212, 145);
            this.txtSpaceEvent.Name = "txtSpaceEvent";
            this.txtSpaceEvent.Size = new System.Drawing.Size(100, 23);
            this.txtSpaceEvent.TabIndex = 14;
            this.txtSpaceEvent.Text = "+:heart:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSpaceEvent);
            this.Controls.Add(this.lblSpaceEvent);
            this.Controls.Add(this.lblCEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.boxRoll);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtCountdown);
            this.Controls.Add(this.lblCountdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblState;
        private Label label1;
        private Label lblCountdown;
        private TextBox txtCountdown;
        private Label lblCount;
        private TextBox txtCount;
        private Label lblRoll;
        private ComboBox boxRoll;
        private Label lblDelay;
        private TextBox txtDelay;
        private Panel panel1;
        private Label lblDelayTimer;
        private Label lblCountLeft;
        private Label lblCountdownTimer;
        private Label lblCEvent;
        private Label lblSpaceEvent;
        private TextBox txtSpaceEvent;
        private Button btnStart;
    }
}