namespace Forensic_gui
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
            this.ap_credentialsBTN = new System.Windows.Forms.Button();
            this.prefetchBTN = new System.Windows.Forms.Button();
            this.reg_recentDocsBTN = new System.Windows.Forms.Button();
            this.timelineBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ap_credentialsBTN
            // 
            this.ap_credentialsBTN.Location = new System.Drawing.Point(68, 132);
            this.ap_credentialsBTN.Name = "ap_credentialsBTN";
            this.ap_credentialsBTN.Size = new System.Drawing.Size(95, 38);
            this.ap_credentialsBTN.TabIndex = 0;
            this.ap_credentialsBTN.Text = "AP Credentials";
            this.ap_credentialsBTN.UseVisualStyleBackColor = true;
            this.ap_credentialsBTN.Click += new System.EventHandler(this.ap_credentialsBTN_Click);
            // 
            // prefetchBTN
            // 
            this.prefetchBTN.Location = new System.Drawing.Point(231, 132);
            this.prefetchBTN.Name = "prefetchBTN";
            this.prefetchBTN.Size = new System.Drawing.Size(95, 38);
            this.prefetchBTN.TabIndex = 1;
            this.prefetchBTN.Text = "Prefetch";
            this.prefetchBTN.UseVisualStyleBackColor = true;
            this.prefetchBTN.Click += new System.EventHandler(this.prefetchBTN_Click);
            // 
            // reg_recentDocsBTN
            // 
            this.reg_recentDocsBTN.Location = new System.Drawing.Point(68, 223);
            this.reg_recentDocsBTN.Name = "reg_recentDocsBTN";
            this.reg_recentDocsBTN.Size = new System.Drawing.Size(95, 38);
            this.reg_recentDocsBTN.TabIndex = 3;
            this.reg_recentDocsBTN.Text = "Reg. Recent Docs";
            this.reg_recentDocsBTN.UseVisualStyleBackColor = true;
            this.reg_recentDocsBTN.Click += new System.EventHandler(this.reg_recentDocsBTN_Click);
            // 
            // timelineBTN
            // 
            this.timelineBTN.Location = new System.Drawing.Point(231, 223);
            this.timelineBTN.Name = "timelineBTN";
            this.timelineBTN.Size = new System.Drawing.Size(95, 38);
            this.timelineBTN.TabIndex = 2;
            this.timelineBTN.Text = "Timeline";
            this.timelineBTN.UseVisualStyleBackColor = true;
            this.timelineBTN.Click += new System.EventHandler(this.timelineBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 350);
            this.Controls.Add(this.reg_recentDocsBTN);
            this.Controls.Add(this.timelineBTN);
            this.Controls.Add(this.prefetchBTN);
            this.Controls.Add(this.ap_credentialsBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ap_credentialsBTN;
        private System.Windows.Forms.Button prefetchBTN;
        private System.Windows.Forms.Button reg_recentDocsBTN;
        private System.Windows.Forms.Button timelineBTN;
    }
}

