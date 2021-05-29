
namespace RefactoredCoffeeBrewer
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
            this.startTimer = new System.Windows.Forms.Button();
            this.timeRemaining = new System.Windows.Forms.TextBox();
            this.brewingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startTimer.Location = new System.Drawing.Point(206, 253);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(75, 46);
            this.startTimer.TabIndex = 0;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // timeRemaining
            // 
            this.timeRemaining.Enabled = false;
            this.timeRemaining.Location = new System.Drawing.Point(91, 179);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(287, 22);
            this.timeRemaining.TabIndex = 2;
            this.timeRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brewingDate
            // 
            this.brewingDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.brewingDate.Location = new System.Drawing.Point(146, 98);
            this.brewingDate.Name = "brewingDate";
            this.brewingDate.Size = new System.Drawing.Size(200, 22);
            this.brewingDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick a time to brew";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time remaining until brewing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brewingDate);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.startTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.TextBox timeRemaining;
        private System.Windows.Forms.DateTimePicker brewingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

