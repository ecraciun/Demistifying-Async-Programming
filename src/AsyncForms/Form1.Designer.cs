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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Enabled = false;
            this.outputTxtBox.Location = new System.Drawing.Point(374, 14);
            this.outputTxtBox.Multiline = true;
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTxtBox.Size = new System.Drawing.Size(414, 424);
            this.outputTxtBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox outputTxtBox;
    }
}

