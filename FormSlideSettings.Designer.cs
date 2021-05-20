namespace FACE_THEME_NEW
{
    partial class FormSlideSettings
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
            this.label_SlideSettings_Path = new System.Windows.Forms.Label();
            this.textBox_SlideSettings_Path = new System.Windows.Forms.TextBox();
            this.button_SlideSettings_Path = new System.Windows.Forms.Button();
            this.groupBox_SlideSettings_Path = new System.Windows.Forms.GroupBox();
            this.radioButton_SlideSettings_Path3 = new System.Windows.Forms.RadioButton();
            this.radioButton_SlideSettings_Path2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SlideSettings_Path1 = new System.Windows.Forms.RadioButton();
            this.label_SlideSettings_Interval = new System.Windows.Forms.Label();
            this.comboBox_SlideSettings_Interval = new System.Windows.Forms.ComboBox();
            this.checkBox_SlideSettings_Interval = new System.Windows.Forms.CheckBox();
            this.button_SlideSettings_Save = new System.Windows.Forms.Button();
            this.button_SlideSettings_Cancel = new System.Windows.Forms.Button();
            this.groupBox_SlideSettings_Path.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SlideSettings_Path
            // 
            this.label_SlideSettings_Path.AutoSize = true;
            this.label_SlideSettings_Path.Font = new System.Drawing.Font("宋体", 10F);
            this.label_SlideSettings_Path.Location = new System.Drawing.Point(38, 29);
            this.label_SlideSettings_Path.Name = "label_SlideSettings_Path";
            this.label_SlideSettings_Path.Size = new System.Drawing.Size(161, 14);
            this.label_SlideSettings_Path.TabIndex = 0;
            this.label_SlideSettings_Path.Text = "图片文件夹路径/RSS URL";
            this.label_SlideSettings_Path.Click += new System.EventHandler(this.label_SlideSettings_Path_Click);
            // 
            // textBox_SlideSettings_Path
            // 
            this.textBox_SlideSettings_Path.Location = new System.Drawing.Point(215, 26);
            this.textBox_SlideSettings_Path.Name = "textBox_SlideSettings_Path";
            this.textBox_SlideSettings_Path.Size = new System.Drawing.Size(256, 21);
            this.textBox_SlideSettings_Path.TabIndex = 1;
            this.textBox_SlideSettings_Path.TextChanged += new System.EventHandler(this.textBox_SlideSettings_Path_TextChanged);
            // 
            // button_SlideSettings_Path
            // 
            this.button_SlideSettings_Path.Location = new System.Drawing.Point(490, 26);
            this.button_SlideSettings_Path.Name = "button_SlideSettings_Path";
            this.button_SlideSettings_Path.Size = new System.Drawing.Size(59, 21);
            this.button_SlideSettings_Path.TabIndex = 2;
            this.button_SlideSettings_Path.Text = "浏览";
            this.button_SlideSettings_Path.UseVisualStyleBackColor = true;
            this.button_SlideSettings_Path.Click += new System.EventHandler(this.button_SlideSettings_Path_Click);
            // 
            // groupBox_SlideSettings_Path
            // 
            this.groupBox_SlideSettings_Path.Controls.Add(this.radioButton_SlideSettings_Path3);
            this.groupBox_SlideSettings_Path.Controls.Add(this.radioButton_SlideSettings_Path2);
            this.groupBox_SlideSettings_Path.Controls.Add(this.radioButton_SlideSettings_Path1);
            this.groupBox_SlideSettings_Path.Location = new System.Drawing.Point(215, 56);
            this.groupBox_SlideSettings_Path.Name = "groupBox_SlideSettings_Path";
            this.groupBox_SlideSettings_Path.Size = new System.Drawing.Size(299, 37);
            this.groupBox_SlideSettings_Path.TabIndex = 3;
            this.groupBox_SlideSettings_Path.TabStop = false;
            this.groupBox_SlideSettings_Path.Enter += new System.EventHandler(this.groupBox_SlideSettings_Path_Enter);
            // 
            // radioButton_SlideSettings_Path3
            // 
            this.radioButton_SlideSettings_Path3.AutoSize = true;
            this.radioButton_SlideSettings_Path3.Location = new System.Drawing.Point(229, 15);
            this.radioButton_SlideSettings_Path3.Name = "radioButton_SlideSettings_Path3";
            this.radioButton_SlideSettings_Path3.Size = new System.Drawing.Size(53, 16);
            this.radioButton_SlideSettings_Path3.TabIndex = 2;
            this.radioButton_SlideSettings_Path3.TabStop = true;
            this.radioButton_SlideSettings_Path3.Text = "RSS源";
            this.radioButton_SlideSettings_Path3.UseVisualStyleBackColor = true;
            this.radioButton_SlideSettings_Path3.Click += new System.EventHandler(this.radioButton_SlideSettings_Path3_Click);
            // 
            // radioButton_SlideSettings_Path2
            // 
            this.radioButton_SlideSettings_Path2.AutoSize = true;
            this.radioButton_SlideSettings_Path2.Location = new System.Drawing.Point(130, 15);
            this.radioButton_SlideSettings_Path2.Name = "radioButton_SlideSettings_Path2";
            this.radioButton_SlideSettings_Path2.Size = new System.Drawing.Size(71, 16);
            this.radioButton_SlideSettings_Path2.TabIndex = 1;
            this.radioButton_SlideSettings_Path2.TabStop = true;
            this.radioButton_SlideSettings_Path2.Text = "绝对路径";
            this.radioButton_SlideSettings_Path2.UseVisualStyleBackColor = true;
            this.radioButton_SlideSettings_Path2.Click += new System.EventHandler(this.radioButton_SlideSettings_Path2_Click);
            // 
            // radioButton_SlideSettings_Path1
            // 
            this.radioButton_SlideSettings_Path1.AutoSize = true;
            this.radioButton_SlideSettings_Path1.Location = new System.Drawing.Point(7, 15);
            this.radioButton_SlideSettings_Path1.Name = "radioButton_SlideSettings_Path1";
            this.radioButton_SlideSettings_Path1.Size = new System.Drawing.Size(95, 16);
            this.radioButton_SlideSettings_Path1.TabIndex = 0;
            this.radioButton_SlideSettings_Path1.TabStop = true;
            this.radioButton_SlideSettings_Path1.Text = "主题图片目录";
            this.radioButton_SlideSettings_Path1.UseVisualStyleBackColor = true;
            this.radioButton_SlideSettings_Path1.CheckedChanged += new System.EventHandler(this.radioButton_SlideSettings_Path1_CheckedChanged);
            this.radioButton_SlideSettings_Path1.Click += new System.EventHandler(this.radioButton_SlideSettings_Path1_Click);
            // 
            // label_SlideSettings_Interval
            // 
            this.label_SlideSettings_Interval.AutoSize = true;
            this.label_SlideSettings_Interval.Font = new System.Drawing.Font("宋体", 10F);
            this.label_SlideSettings_Interval.Location = new System.Drawing.Point(41, 123);
            this.label_SlideSettings_Interval.Name = "label_SlideSettings_Interval";
            this.label_SlideSettings_Interval.Size = new System.Drawing.Size(63, 14);
            this.label_SlideSettings_Interval.TabIndex = 4;
            this.label_SlideSettings_Interval.Text = "切换间隔";
            this.label_SlideSettings_Interval.Click += new System.EventHandler(this.label_SlideSettings_Interval_Click);
            // 
            // comboBox_SlideSettings_Interval
            // 
            this.comboBox_SlideSettings_Interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SlideSettings_Interval.FormattingEnabled = true;
            this.comboBox_SlideSettings_Interval.Items.AddRange(new object[] {
            "1 分钟",
            "10 分钟",
            "30 分钟",
            "1 小时",
            "6 小时",
            "1 天"});
            this.comboBox_SlideSettings_Interval.Location = new System.Drawing.Point(133, 121);
            this.comboBox_SlideSettings_Interval.Name = "comboBox_SlideSettings_Interval";
            this.comboBox_SlideSettings_Interval.Size = new System.Drawing.Size(100, 20);
            this.comboBox_SlideSettings_Interval.TabIndex = 5;
            this.comboBox_SlideSettings_Interval.SelectedIndexChanged += new System.EventHandler(this.comboBox_SlideSettings_Interval_SelectedIndexChanged);
            // 
            // checkBox_SlideSettings_Interval
            // 
            this.checkBox_SlideSettings_Interval.AutoSize = true;
            this.checkBox_SlideSettings_Interval.Location = new System.Drawing.Point(260, 123);
            this.checkBox_SlideSettings_Interval.Name = "checkBox_SlideSettings_Interval";
            this.checkBox_SlideSettings_Interval.Size = new System.Drawing.Size(48, 16);
            this.checkBox_SlideSettings_Interval.TabIndex = 6;
            this.checkBox_SlideSettings_Interval.Text = "乱序";
            this.checkBox_SlideSettings_Interval.UseVisualStyleBackColor = true;
            this.checkBox_SlideSettings_Interval.CheckedChanged += new System.EventHandler(this.checkBox_SlideSettings_Interval_CheckedChanged);
            // 
            // button_SlideSettings_Save
            // 
            this.button_SlideSettings_Save.Location = new System.Drawing.Point(380, 118);
            this.button_SlideSettings_Save.Name = "button_SlideSettings_Save";
            this.button_SlideSettings_Save.Size = new System.Drawing.Size(75, 25);
            this.button_SlideSettings_Save.TabIndex = 7;
            this.button_SlideSettings_Save.Text = "确定";
            this.button_SlideSettings_Save.UseVisualStyleBackColor = true;
            this.button_SlideSettings_Save.Click += new System.EventHandler(this.button_SlideSettings_Save_Click);
            // 
            // button_SlideSettings_Cancel
            // 
            this.button_SlideSettings_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SlideSettings_Cancel.Location = new System.Drawing.Point(474, 118);
            this.button_SlideSettings_Cancel.Name = "button_SlideSettings_Cancel";
            this.button_SlideSettings_Cancel.Size = new System.Drawing.Size(75, 25);
            this.button_SlideSettings_Cancel.TabIndex = 8;
            this.button_SlideSettings_Cancel.Text = "取消";
            this.button_SlideSettings_Cancel.UseVisualStyleBackColor = true;
            this.button_SlideSettings_Cancel.Click += new System.EventHandler(this.button_SlideSettings_Cancel_Click);
            // 
            // FormSlideSettings
            // 
            this.AcceptButton = this.button_SlideSettings_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_SlideSettings_Cancel;
            this.ClientSize = new System.Drawing.Size(598, 170);
            this.ControlBox = false;
            this.Controls.Add(this.button_SlideSettings_Cancel);
            this.Controls.Add(this.button_SlideSettings_Save);
            this.Controls.Add(this.checkBox_SlideSettings_Interval);
            this.Controls.Add(this.comboBox_SlideSettings_Interval);
            this.Controls.Add(this.label_SlideSettings_Interval);
            this.Controls.Add(this.groupBox_SlideSettings_Path);
            this.Controls.Add(this.button_SlideSettings_Path);
            this.Controls.Add(this.textBox_SlideSettings_Path);
            this.Controls.Add(this.label_SlideSettings_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSlideSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "幻灯片设置";
            this.TopMost = true;
            this.groupBox_SlideSettings_Path.ResumeLayout(false);
            this.groupBox_SlideSettings_Path.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SlideSettings_Path;
        private System.Windows.Forms.TextBox textBox_SlideSettings_Path;
        private System.Windows.Forms.Button button_SlideSettings_Path;
        private System.Windows.Forms.GroupBox groupBox_SlideSettings_Path;
        private System.Windows.Forms.RadioButton radioButton_SlideSettings_Path3;
        private System.Windows.Forms.RadioButton radioButton_SlideSettings_Path2;
        private System.Windows.Forms.RadioButton radioButton_SlideSettings_Path1;
        private System.Windows.Forms.Label label_SlideSettings_Interval;
        private System.Windows.Forms.ComboBox comboBox_SlideSettings_Interval;
        private System.Windows.Forms.CheckBox checkBox_SlideSettings_Interval;
        private System.Windows.Forms.Button button_SlideSettings_Save;
        private System.Windows.Forms.Button button_SlideSettings_Cancel;
    }
}