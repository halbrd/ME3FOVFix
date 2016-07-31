namespace ME3FOVFix
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblInstallDirectory = new System.Windows.Forms.Label();
            this.txtInstallDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mass Effect 3 FOV Fix";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(12, 40);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(260, 23);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Yes, it\'s a mod.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstallDirectory
            // 
            this.lblInstallDirectory.AutoSize = true;
            this.lblInstallDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallDirectory.Location = new System.Drawing.Point(12, 67);
            this.lblInstallDirectory.Name = "lblInstallDirectory";
            this.lblInstallDirectory.Size = new System.Drawing.Size(241, 15);
            this.lblInstallDirectory.TabIndex = 2;
            this.lblInstallDirectory.Text = "Installation directory (\"Mass Effect 3\" folder)";
            // 
            // txtInstallDirectory
            // 
            this.txtInstallDirectory.Location = new System.Drawing.Point(13, 87);
            this.txtInstallDirectory.Name = "txtInstallDirectory";
            this.txtInstallDirectory.Size = new System.Drawing.Size(199, 20);
            this.txtInstallDirectory.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(217, 85);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(12, 126);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(259, 45);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 178);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtInstallDirectory);
            this.Controls.Add(this.lblInstallDirectory);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Will\'s ME3 FOV Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblInstallDirectory;
        private System.Windows.Forms.TextBox txtInstallDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblResult;
    }
}

