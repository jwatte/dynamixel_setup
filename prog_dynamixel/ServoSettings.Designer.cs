namespace prog_dynamixel
{
    partial class ServoSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.numBaud = new System.Windows.Forms.NumericUpDown();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.txtShutdown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numResponse = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResponse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(147, 42);
            this.numID.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 22);
            this.numID.TabIndex = 1;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaud
            // 
            this.numBaud.Location = new System.Drawing.Point(147, 70);
            this.numBaud.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numBaud.Name = "numBaud";
            this.numBaud.Size = new System.Drawing.Size(120, 22);
            this.numBaud.TabIndex = 3;
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(147, 99);
            this.numDelay.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(120, 22);
            this.numDelay.TabIndex = 4;
            // 
            // txtShutdown
            // 
            this.txtShutdown.Location = new System.Drawing.Point(147, 127);
            this.txtShutdown.MaxLength = 3;
            this.txtShutdown.Name = "txtShutdown";
            this.txtShutdown.Size = new System.Drawing.Size(100, 22);
            this.txtShutdown.TabIndex = 5;
            this.txtShutdown.TextChanged += new System.EventHandler(this.txtShutdown_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shutdown";
            // 
            // numResponse
            // 
            this.numResponse.Location = new System.Drawing.Point(147, 156);
            this.numResponse.Name = "numResponse";
            this.numResponse.Size = new System.Drawing.Size(120, 22);
            this.numResponse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Response Level";
            // 
            // ServoSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShutdown);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.numBaud);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.lblTitle);
            this.Name = "ServoSettings";
            this.Size = new System.Drawing.Size(303, 200);
            this.Load += new System.EventHandler(this.ServoSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.NumericUpDown numBaud;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.TextBox txtShutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numResponse;
        private System.Windows.Forms.Label label5;
    }
}
