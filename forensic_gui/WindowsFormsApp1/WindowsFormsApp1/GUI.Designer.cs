namespace WindowsFormsApp1
{
    partial class GUI
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
            this.apPassBTN = new System.Windows.Forms.Button();
            this.prefetchBTN = new System.Windows.Forms.Button();
            this.regRecentBTN = new System.Windows.Forms.Button();
            this.timelineBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apPassBTN
            // 
            this.apPassBTN.Location = new System.Drawing.Point(68, 86);
            this.apPassBTN.Name = "apPassBTN";
            this.apPassBTN.Size = new System.Drawing.Size(117, 49);
            this.apPassBTN.TabIndex = 0;
            this.apPassBTN.Text = "AP User i Password";
            this.apPassBTN.UseVisualStyleBackColor = true;
            this.apPassBTN.Click += new System.EventHandler(this.apPassBTN_Click);
            // 
            // prefetchBTN
            // 
            this.prefetchBTN.Location = new System.Drawing.Point(281, 86);
            this.prefetchBTN.Name = "prefetchBTN";
            this.prefetchBTN.Size = new System.Drawing.Size(117, 49);
            this.prefetchBTN.TabIndex = 2;
            this.prefetchBTN.Text = "Prefetch";
            this.prefetchBTN.UseVisualStyleBackColor = true;
            this.prefetchBTN.Click += new System.EventHandler(this.prefetchBTN_Click);
            // 
            // regRecentBTN
            // 
            this.regRecentBTN.Location = new System.Drawing.Point(68, 186);
            this.regRecentBTN.Name = "regRecentBTN";
            this.regRecentBTN.Size = new System.Drawing.Size(117, 48);
            this.regRecentBTN.TabIndex = 3;
            this.regRecentBTN.Text = "Registry Recent Docs";
            this.regRecentBTN.UseVisualStyleBackColor = true;
            this.regRecentBTN.Click += new System.EventHandler(this.regRecentBTN_Click);
            // 
            // timelineBTN
            // 
            this.timelineBTN.Location = new System.Drawing.Point(281, 186);
            this.timelineBTN.Name = "timelineBTN";
            this.timelineBTN.Size = new System.Drawing.Size(117, 48);
            this.timelineBTN.TabIndex = 4;
            this.timelineBTN.Text = "Timeline";
            this.timelineBTN.UseVisualStyleBackColor = true;
            this.timelineBTN.Click += new System.EventHandler(this.timelineBTN_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 357);
            this.Controls.Add(this.timelineBTN);
            this.Controls.Add(this.regRecentBTN);
            this.Controls.Add(this.prefetchBTN);
            this.Controls.Add(this.apPassBTN);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apPassBTN;
        private System.Windows.Forms.Button prefetchBTN;
        private System.Windows.Forms.Button regRecentBTN;
        private System.Windows.Forms.Button timelineBTN;
    }
}

