namespace AsyncForms
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
            this.asyncVoidRaceBtn = new System.Windows.Forms.Button();
            this.asyncVoidCatchBtn = new System.Windows.Forms.Button();
            this.deadlockBtn = new System.Windows.Forms.Button();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.startCTBtn = new System.Windows.Forms.Button();
            this.cancelTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asyncVoidRaceBtn
            // 
            this.asyncVoidRaceBtn.Location = new System.Drawing.Point(12, 12);
            this.asyncVoidRaceBtn.Name = "asyncVoidRaceBtn";
            this.asyncVoidRaceBtn.Size = new System.Drawing.Size(218, 23);
            this.asyncVoidRaceBtn.TabIndex = 0;
            this.asyncVoidRaceBtn.Text = "Async void race condition";
            this.asyncVoidRaceBtn.UseVisualStyleBackColor = true;
            this.asyncVoidRaceBtn.Click += new System.EventHandler(this.asyncVoidRaceBtn_Click);
            // 
            // asyncVoidCatchBtn
            // 
            this.asyncVoidCatchBtn.Location = new System.Drawing.Point(12, 41);
            this.asyncVoidCatchBtn.Name = "asyncVoidCatchBtn";
            this.asyncVoidCatchBtn.Size = new System.Drawing.Size(218, 23);
            this.asyncVoidCatchBtn.TabIndex = 1;
            this.asyncVoidCatchBtn.Text = "Async void catch";
            this.asyncVoidCatchBtn.UseVisualStyleBackColor = true;
            this.asyncVoidCatchBtn.Click += new System.EventHandler(this.asyncVoidCatchBtn_Click);
            // 
            // deadlockBtn
            // 
            this.deadlockBtn.Location = new System.Drawing.Point(12, 70);
            this.deadlockBtn.Name = "deadlockBtn";
            this.deadlockBtn.Size = new System.Drawing.Size(218, 23);
            this.deadlockBtn.TabIndex = 2;
            this.deadlockBtn.Text = "Deadlock";
            this.deadlockBtn.UseVisualStyleBackColor = true;
            this.deadlockBtn.Click += new System.EventHandler(this.deadlockBtn_Click);
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Enabled = false;
            this.outputTxtBox.Location = new System.Drawing.Point(236, 14);
            this.outputTxtBox.Multiline = true;
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTxtBox.Size = new System.Drawing.Size(714, 424);
            this.outputTxtBox.TabIndex = 4;
            // 
            // startCTBtn
            // 
            this.startCTBtn.Location = new System.Drawing.Point(12, 99);
            this.startCTBtn.Name = "startCTBtn";
            this.startCTBtn.Size = new System.Drawing.Size(218, 23);
            this.startCTBtn.TabIndex = 6;
            this.startCTBtn.Text = "Start Cancellable Task";
            this.startCTBtn.UseVisualStyleBackColor = true;
            this.startCTBtn.Click += new System.EventHandler(this.startCTBtn_Click);
            // 
            // cancelTaskBtn
            // 
            this.cancelTaskBtn.Location = new System.Drawing.Point(12, 128);
            this.cancelTaskBtn.Name = "cancelTaskBtn";
            this.cancelTaskBtn.Size = new System.Drawing.Size(218, 23);
            this.cancelTaskBtn.TabIndex = 7;
            this.cancelTaskBtn.Text = "Cancel Task";
            this.cancelTaskBtn.UseVisualStyleBackColor = true;
            this.cancelTaskBtn.Click += new System.EventHandler(this.cancelTaskBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.cancelTaskBtn);
            this.Controls.Add(this.startCTBtn);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.deadlockBtn);
            this.Controls.Add(this.asyncVoidCatchBtn);
            this.Controls.Add(this.asyncVoidRaceBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asyncVoidRaceBtn;
        private System.Windows.Forms.Button asyncVoidCatchBtn;
        private System.Windows.Forms.Button deadlockBtn;
        private System.Windows.Forms.TextBox outputTxtBox;
        private System.Windows.Forms.Button startCTBtn;
        private System.Windows.Forms.Button cancelTaskBtn;
    }
}

