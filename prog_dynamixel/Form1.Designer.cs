namespace prog_dynamixel
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.servoDesired = new prog_dynamixel.ServoSettings();
            this.servoActual = new prog_dynamixel.ServoSettings();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Searching for USB2Dynamixel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "no servo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // servoDesired
            // 
            this.servoDesired.Baud = 0;
            this.servoDesired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servoDesired.Delay = 5;
            this.servoDesired.ID = 1;
            this.servoDesired.Location = new System.Drawing.Point(339, 105);
            this.servoDesired.Name = "servoDesired";
            this.servoDesired.Response = 1;
            this.servoDesired.Shutdown = 4;
            this.servoDesired.Size = new System.Drawing.Size(303, 196);
            this.servoDesired.TabIndex = 4;
            // 
            // servoActual
            // 
            this.servoActual.Baud = 0;
            this.servoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servoActual.Delay = 0;
            this.servoActual.ID = 1;
            this.servoActual.Location = new System.Drawing.Point(13, 105);
            this.servoActual.Name = "servoActual";
            this.servoActual.Response = 0;
            this.servoActual.Shutdown = 0;
            this.servoActual.Size = new System.Drawing.Size(303, 196);
            this.servoActual.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.servoDesired);
            this.Controls.Add(this.servoActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dynamixel Setter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private ServoSettings servoActual;
        private ServoSettings servoDesired;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
    }
}

