namespace FACE_THEME_NEW
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.aboutText1 = new System.Windows.Forms.Label();
            this.aboutText2 = new System.Windows.Forms.Label();
            this.aboutText3 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.aboutText4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutText1
            // 
            this.aboutText1.AutoSize = true;
            this.aboutText1.Location = new System.Drawing.Point(41, 30);
            this.aboutText1.Name = "aboutText1";
            this.aboutText1.Size = new System.Drawing.Size(95, 12);
            this.aboutText1.TabIndex = 0;
            this.aboutText1.Text = "FACE 主题编辑器";
            this.aboutText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aboutText2
            // 
            this.aboutText2.AutoSize = true;
            this.aboutText2.Location = new System.Drawing.Point(41, 51);
            this.aboutText2.Name = "aboutText2";
            this.aboutText2.Size = new System.Drawing.Size(29, 12);
            this.aboutText2.TabIndex = 1;
            this.aboutText2.Text = "版本";
            this.aboutText2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // aboutText3
            // 
            this.aboutText3.AutoSize = true;
            this.aboutText3.Location = new System.Drawing.Point(41, 72);
            this.aboutText3.Name = "aboutText3";
            this.aboutText3.Size = new System.Drawing.Size(179, 12);
            this.aboutText3.TabIndex = 2;
            this.aboutText3.Text = "By P && Z && S 大一年度项目作品";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(76, 51);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(101, 12);
            this.Version.TabIndex = 3;
            this.Version.Text = "v1.1 20210520 01";
            this.Version.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // aboutText4
            // 
            this.aboutText4.AutoSize = true;
            this.aboutText4.Location = new System.Drawing.Point(41, 93);
            this.aboutText4.Name = "aboutText4";
            this.aboutText4.Size = new System.Drawing.Size(101, 12);
            this.aboutText4.TabIndex = 4;
            this.aboutText4.Text = "感谢各位老师指导";
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 143);
            this.Controls.Add(this.aboutText4);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.aboutText3);
            this.Controls.Add(this.aboutText2);
            this.Controls.Add(this.aboutText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于 FACE 主题编辑器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutText1;
        private System.Windows.Forms.Label aboutText2;
        private System.Windows.Forms.Label aboutText3;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label aboutText4;
    }
}