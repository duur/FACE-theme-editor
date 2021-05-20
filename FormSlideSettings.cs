using System;
using System.Windows.Forms;

namespace FACE_THEME_NEW
{
    public partial class FormSlideSettings : Form
    {
        public FormSlideSettings()
        {
            InitializeComponent();
            if (Files.tShuffle == "1")
            {
                checkBox_SlideSettings_Interval.Checked = true;
            }
            else
            {
                checkBox_SlideSettings_Interval.Checked = false;
            }

            switch (Files.tInterval)
            {
                case "60000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 0;
                        break;
                    }
                case "600000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 1;
                        break;
                    }
                case "1800000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 2;
                        break;
                    }
                case "3600000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 3;
                        break;
                    }
                case "21600000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 4;
                        break;
                    }
                case "86400000":
                    {
                        comboBox_SlideSettings_Interval.SelectedIndex = 5;
                        break;
                    }
            }

            if (Files.tImageRootPath != string.Empty && Files.tRSSFeed == string.Empty)
            {
                textBox_SlideSettings_Path.Text = Files.tImageRootPath;
            }
            else if (Files.tImageRootPath == string.Empty && Files.tRSSFeed != string.Empty)
            {
                textBox_SlideSettings_Path.Text = Files.tRSSFeed;
            }
            else;

        }

        private void button_SlideSettings_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SlideSettings_Save_Click(object sender, EventArgs e)
        {
            if (radioButton_SlideSettings_Path3.Checked == true)
            {
                Files.tRSSFeed = textBox_SlideSettings_Path.Text;
                Files.tImageRootPath = string.Empty;
            }
            else
            {
                Files.tRSSFeed = string.Empty;
                Files.tImageRootPath = textBox_SlideSettings_Path.Text;
            }

            switch (comboBox_SlideSettings_Interval.SelectedIndex)
            {
                case 0:
                    {
                        Files.tInterval = "60000";
                        break;
                    }
                case 1:
                    {
                        Files.tInterval = "600000";
                        break;
                    }
                case 2:
                    {
                        Files.tInterval = "1800000";
                        break;
                    }
                case 3:
                    {
                        Files.tInterval = "3600000";
                        break;
                    }
                case 4:
                    {
                        Files.tInterval = "21600000";
                        break;
                    }
                case 5:
                    {
                        Files.tInterval = "86400000";
                        break;
                    }
            }

            if (checkBox_SlideSettings_Interval.Checked == true)
            {
                Files.tShuffle = "1";
            }
            else
            {
                Files.tShuffle = "0";
            }
            this.Close();
        }

        private void checkBox_SlideSettings_Interval_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SlideSettings_Interval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_SlideSettings_Interval_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_SlideSettings_Path_Enter(object sender, EventArgs e)
        {

        }

        private void button_SlideSettings_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                if (openFolder.SelectedPath == Files.currentFile + "\\DesktopBackground")
                {
                    textBox_SlideSettings_Path.Text = "DesktopBackground";
                    radioButton_SlideSettings_Path2.Checked = false;
                    radioButton_SlideSettings_Path3.Checked = false;
                    radioButton_SlideSettings_Path1.Checked = true;
                }
                else
                {
                    textBox_SlideSettings_Path.Text = openFolder.SelectedPath;
                    radioButton_SlideSettings_Path1.Checked = false;
                    radioButton_SlideSettings_Path3.Checked = false;
                    radioButton_SlideSettings_Path2.Checked = true;
                }
            }
        }

        private void textBox_SlideSettings_Path_TextChanged(object sender, EventArgs e)
        {
            button_SlideSettings_Path.Enabled = true;
            if (textBox_SlideSettings_Path.Text == "DesktopBackground")
            {
                radioButton_SlideSettings_Path2.Checked = false;
                radioButton_SlideSettings_Path3.Checked = false;
                radioButton_SlideSettings_Path1.Checked = true;
            }
            else if (textBox_SlideSettings_Path.Text.Length >= 7)
            {
                if (textBox_SlideSettings_Path.Text.Substring(0, 7) == "http://" || textBox_SlideSettings_Path.Text.Substring(0, 7) == "https:/")
                {
                    radioButton_SlideSettings_Path2.Checked = false;
                    radioButton_SlideSettings_Path1.Checked = false;
                    radioButton_SlideSettings_Path3.Checked = true;
                    button_SlideSettings_Path.Enabled = false;
                }
                else
                {
                    radioButton_SlideSettings_Path1.Checked = false;
                    radioButton_SlideSettings_Path3.Checked = false;
                    radioButton_SlideSettings_Path2.Checked = true;
                }
            }
            else if (textBox_SlideSettings_Path.Text == string.Empty) ;
            else
            {
                radioButton_SlideSettings_Path1.Checked = false;
                radioButton_SlideSettings_Path3.Checked = false;
                radioButton_SlideSettings_Path2.Checked = true;
            }
        }

        private void label_SlideSettings_Path_Click(object sender, EventArgs e)
        {

        }

        public static void LoadSlideSettings()
        {

        }

        private void radioButton_SlideSettings_Path1_Click(object sender, EventArgs e)
        {
            textBox_SlideSettings_Path.Text = "DesktopBackground";
            button_SlideSettings_Path.Enabled = true;
        }

        private void radioButton_SlideSettings_Path2_Click(object sender, EventArgs e)
        {
            button_SlideSettings_Path.Enabled = true;
            textBox_SlideSettings_Path.Text = string.Empty;
        }

        private void radioButton_SlideSettings_Path3_Click(object sender, EventArgs e)
        {
            button_SlideSettings_Path.Enabled = false;
            textBox_SlideSettings_Path.Text = string.Empty;
        }

        private void radioButton_SlideSettings_Path1_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
