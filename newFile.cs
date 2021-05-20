using System;
using System.IO;
using System.Windows.Forms;

namespace FACE_THEME_NEW
{
    public partial class newFile : Form
    {
        public newFile()
        {
            InitializeComponent();
            textBox1.Text = "";
        }

        private void newFile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Files.newReturn = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Files.systemDrive = Environment.GetEnvironmentVariable("SystemDrive");
                if (!Directory.Exists(Files.systemDrive + "\\ThemeFiles"))
                {
                    Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles");
                }

                if (!Directory.Exists(Files.systemDrive + "\\ThemeFiles\\" + textBox1.Text + "_files"))
                {
                    Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles\\" + textBox1.Text + "_files");
                    Files.fileName = textBox1.Text;
                    Files.currentSafeFile = textBox1.Text + "_files";
                    Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                    Dispose();
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("该项目已存在。直接打开项目吗？\n点击“确定”直接打开项目。\n点击“取消”新建一个项目。", "项目存在", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (result2 == DialogResult.OK)
                    {
                        Files.fileName = textBox1.Text;
                        Files.currentSafeFile = Files.fileName + "_files";
                        Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                    }
                    else
                    {
                        Files.fileName = textBox1.Text + "_new";
                        while (Directory.Exists(Files.systemDrive + "\\ThemeFiles\\" + Files.fileName + "_files"))
                        {
                            Files.fileName += "_new";
                        }
                        Files.currentSafeFile = Files.fileName + "_files";
                        Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile);
                        Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                    }
                    Dispose();
                }
                Files.newReturn = 0;
                if (!Directory.Exists(Files.currentFile + "\\DesktopBackground"))
                {
                    Directory.CreateDirectory(Files.currentFile + "\\DesktopBackground");
                }

                if (!Directory.Exists(Files.currentFile + "\\ThemeCursors"))
                {
                    Directory.CreateDirectory(Files.currentFile + "\\ThemeCursors");
                }

                if (!Directory.Exists(Files.currentFile + "\\ThemeIcons"))
                {
                    Directory.CreateDirectory(Files.currentFile + "\\ThemeIcons");
                }
                //复制模板文件
                if(!File.Exists(Files.currentFile + "\\" + Files.fileName + ".theme"))
                {
                    File.Copy("Res\\Default.theme", Files.currentFile + "\\" + Files.fileName + ".theme");
                }
                if (!File.Exists(Files.currentFile + "\\DesktopBackground\\1.jpg"))
                {
                    File.Copy("Res\\1.jpg", Files.currentFile + "\\DesktopBackground\\1.jpg");
                }
            }
            else
            {
                MessageBox.Show("文件名不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}











