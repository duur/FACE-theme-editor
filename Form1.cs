using HandleINI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FACE_THEME_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void LoadTheme(string filename)
        {
            //Theme
            Files.tDisplayName = INI.Read("Theme", "DisplayName", String.Empty, filename);
            Files.tBrandImage = INI.Read("Theme", "BrandImage", String.Empty, filename);

            //Desktop
            Files.tWallpaper = INI.Read("Control Panel\\Desktop", "Wallpaper", String.Empty, filename);
            Files.tTileWallpaper = INI.Read("Control Panel\\Desktop", "TileWallpaper", String.Empty, filename);
            Files.tWallpaperStyle = INI.Read("Control Panel\\Desktop", "WallpaperStyle", String.Empty, filename);
            Files.tMultimonBackgrounds = INI.Read("Control Panel\\Desktop", "MultimonBackgrounds", String.Empty, filename);
            Files.tPicturePosition = INI.Read("Control Panel\\Desktop", "PicturePosition", String.Empty, filename);

            //Slideshow
            Files.tInterval = INI.Read("Slideshow", "Interval", String.Empty, filename);
            Files.tShuffle = INI.Read("Slideshow", "Shuffle", String.Empty, filename);
            Files.tRSSFeed = INI.Read("Slideshow", "RSSFeed", String.Empty, filename);
            Files.tImageRootPath = INI.Read("Slideshow", "ImageRootPath", String.Empty, filename);

            //VisualStyles
            Files.tPath = INI.Read("VisualStyles", "Path", String.Empty, filename);
            Files.tColorizationColor = INI.Read("VisualStyles", "ColorizationColor", String.Empty, filename);
            Files.tTransparency = INI.Read("VisualStyles", "Transparency", String.Empty, filename);
            Files.tAutoColorization = INI.Read("VisualStyles", "AutoColorization", String.Empty, filename);
            Files.tAppMode = INI.Read("VisualStyles", "AppMode", String.Empty, filename);
            Files.tSystemMode = INI.Read("VisualStyles", "SystemMode", String.Empty, filename);
            Files.tColorStyle = INI.Read("VisualStyles", "ColorStyle", String.Empty, filename);
            Files.tSize = INI.Read("VisualStyles", "Size", String.Empty, filename);

            //Cursors
            Files.tAppStarting = INI.Read("Control Panel\\Cursors", "AppStarting", String.Empty, filename);
            Files.tArrow = INI.Read("Control Panel\\Cursors", "Arrow", String.Empty, filename);
            Files.tCrosshair = INI.Read("Control Panel\\Cursors", "Crosshair", String.Empty, filename);
            Files.tHand = INI.Read("Control Panel\\Cursors", "Hand", String.Empty, filename);
            Files.tHelp = INI.Read("Control Panel\\Cursors", "Help", String.Empty, filename);
            Files.tIBeam = INI.Read("Control Panel\\Cursors", "IBeam", String.Empty, filename);
            Files.tNo = INI.Read("Control Panel\\Cursors", "No", String.Empty, filename);
            Files.tNWPen = INI.Read("Control Panel\\Cursors", "NWPen", String.Empty, filename);
            Files.tSizeAll = INI.Read("Control Panel\\Cursors", "SizeAll", String.Empty, filename);
            Files.tSizeNESW = INI.Read("Control Panel\\Cursors", "SizeNESW", String.Empty, filename);
            Files.tSizeNS = INI.Read("Control Panel\\Cursors", "SizeNS", String.Empty, filename);
            Files.tSizeNWSE = INI.Read("Control Panel\\Cursors", "SizeNWSE", String.Empty, filename);
            Files.tSizeWE = INI.Read("Control Panel\\Cursors", "SizeWE", String.Empty, filename);
            Files.tUpArrow = INI.Read("Control Panel\\Cursors", "UpArrow", String.Empty, filename);
            Files.tWait = INI.Read("Control Panel\\Cursors", "Wait", String.Empty, filename);

            //boot
            Files.tSCRNSAVE_EXE = INI.Read("boot", "SCRNSAVE.EXE", String.Empty, filename);

            //Sounds
            Files.tSchemeName = INI.Read("Sounds", "SchemeName", String.Empty, filename);

            //Icons
            Files.tComputer = INI.Read("CLSID\\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\\DefaultIcon", "DefaultValue", String.Empty, filename);
            Files.tUsers = INI.Read("CLSID\\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\\DefaultIcon", "DefaultValue", String.Empty, filename);
            Files.tNetwork = INI.Read("CLSID\\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\\DefaultIcon", "DefaultValue", String.Empty, filename);
            Files.tBinEmpty = INI.Read("CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}\\DefaultIcon", "Empty", String.Empty, filename);
            Files.tBinFull = INI.Read("CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}\\DefaultIcon", "Full", String.Empty, filename);

        }


        public void TempToSetting()
        {
            //InfoTab
            textBox_InfoTab_Name.Text = Files.tDisplayName;
            textBox_InfoTab_Preview.Text = Files.tBrandImage;





            //WallpaperTab
            textBox_WallpaperTab_DefWall.Text = Files.tWallpaper;
            if (Files.tMultimonBackgrounds == "1")
            {
                checkBox_WallpaperTab_Fill.Checked = true;
            }

            if (Files.tWallpaperStyle == "0")
            {
                if (Files.tTileWallpaper == "0")
                {
                    comboBox_WallpaperTab_Fill.SelectedIndex = 0;
                }
                else if (Files.tTileWallpaper == "1")
                {
                    comboBox_WallpaperTab_Fill.SelectedIndex = 1;
                }
            }
            else if (Files.tWallpaperStyle == "2")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 2;
            }
            else if (Files.tWallpaperStyle == "6")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 3;
            }
            else if (Files.tWallpaperStyle == "10")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 4;
            }

            if (Files.tPicturePosition == "0")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 0;
            }
            else if (Files.tPicturePosition == "1")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 1;
            }
            else if (Files.tPicturePosition == "2")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 2;
            }
            else if (Files.tPicturePosition == "3")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 3;
            }
            else if (Files.tPicturePosition == "4")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 4;
            }
            else if (Files.tPicturePosition == "5")
            {
                comboBox_WallpaperTab_Fill.SelectedIndex = 5;
            }

            //幻灯片设置
            if (Files.tInterval != string.Empty)
            {
                radioButton_WallpaperTab_Mode1.Checked = false;
                radioButton_WallpaperTab_Mode2.Checked = true;
                button_WallpaperTab_SlideSettings.Enabled = true;
            }
            else
            {
                radioButton_WallpaperTab_Mode2.Checked = false;
                radioButton_WallpaperTab_Mode1.Checked = true;
                button_WallpaperTab_SlideSettings.Enabled = false;
            }


            //CursorTab
            comboBox_CursorTab_Select.SelectedIndex = 0;
            textBox_CursorTab_Path.Text = Files.tAppStarting;


            //IconTab
            comboBox_IconTab_Select.SelectedIndex = 0;
            textBox_IconTab_Path.Text = Files.tComputer;



            //VisualTab
            textBox_VisualTab_Path.Text = Files.tPath;


            if (Files.tColorizationColor.Length == 8)
            {
                //Files.colorAlpha = 255;
                Files.colorRed = Int32.Parse(Files.tColorizationColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                Files.colorGreen = Int32.Parse(Files.tColorizationColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                Files.colorBlue = Int32.Parse(Files.tColorizationColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                textBox_VisualTab_ColorView.BackColor = Color.FromArgb(Files.colorRed, Files.colorGreen, Files.colorBlue);
                Files.tColorizationColor = "0XFF" + Files.tColorizationColor.Substring(2, 6);
            }
            else if (Files.tColorizationColor.Length == 10)
            {
                Files.colorAlpha = Int32.Parse(Files.tColorizationColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                Files.colorRed = Int32.Parse(Files.tColorizationColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                Files.colorGreen = Int32.Parse(Files.tColorizationColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                Files.colorBlue = Int32.Parse(Files.tColorizationColor.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                textBox_VisualTab_ColorView.BackColor = Color.FromArgb(Files.colorRed, Files.colorGreen, Files.colorBlue);
            }
            textBox_VisualTab_ColorView.Text = Files.tColorizationColor;
            if (textBox_VisualTab_ColorView.BackColor.GetBrightness() < 0.5)
            {
                textBox_VisualTab_ColorView.ForeColor = Color.White;
            }
            else
            {
                textBox_VisualTab_ColorView.ForeColor = Color.Black;
            }


            if (Files.tSystemMode == "Dark")
            {
                radioButton_VisualTab_DefWinColor1.Checked = true;
                radioButton_VisualTab_DefWinColor2.Checked = false;
            }
            else if (Files.tSystemMode == "Light")
            {
                radioButton_VisualTab_DefWinColor2.Checked = true;
                radioButton_VisualTab_DefWinColor1.Checked = false;
            }


            if (Files.tAppMode == "Dark")
            {
                radioButton_VisualTab_DefAppMode1.Checked = false;
                radioButton_VisualTab_DefAppMode2.Checked = true;
            }
            else if (Files.tAppMode == "Light")
            {
                radioButton_VisualTab_DefAppMode1.Checked = true;
                radioButton_VisualTab_DefAppMode2.Checked = false;
            }

            if (Files.tAutoColorization == "1")
            {
                checkBox_VisualTab_AutoColor.Checked = true;
            }

            if (Files.tTransparency == "1")
            {
                checkBox_VisualTab_Transparency.Checked = true;
            }


            //OtherTab
            textBox_OtherTab_ScrnSave.Text = Files.tSCRNSAVE_EXE;
            textBox_OtherTab_Sound.Text = Files.tSchemeName;
            textBox_OtherTab_Color.Text = Files.tColorStyle;
            textBox_OtherTab_Size.Text = Files.tSize;

        }





        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void ToolStripMenuItem_New_Click(object sender, EventArgs e)
        {
            newFile nf = new newFile();
            nf.ShowDialog();
            if (Files.newReturn == 0)
            {
                Files.themeFilename = Directory.GetFiles(Files.currentFile, "*.theme")[0];
                LoadTheme(Files.themeFilename);
                TempToSetting();
                this.Text = "FACE 主题编辑器 - " + Files.currentFile;
                this.button_SaveAll.Visible = true;
                this.EditTab.Visible = true;
            }
        }

        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Windows 桌面主题包文件|*.deskthemepack";
            Files.systemDrive = Environment.GetEnvironmentVariable("SystemDrive");
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Files.systemDrive + "\\ThemeFiles"))
                {
                    Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles");
                }
                if (!Directory.Exists(Files.systemDrive + "\\ThemeFiles\\" + Path.GetFileNameWithoutExtension(openFile.FileName) + "_files"))
                {
                    Files.fileName = Path.GetFileNameWithoutExtension(openFile.FileName);
                    Files.currentSafeFile = Files.fileName + "_files";
                    Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile);
                    Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                    ThemeExpand(openFile);
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("该项目已存在。直接打开项目吗？\n点击“确定”直接打开项目。\n点击“取消”新建一个项目。", "项目存在", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (result1 == DialogResult.OK)
                    {
                        Files.fileName = Path.GetFileNameWithoutExtension(openFile.FileName);
                        Files.currentSafeFile = Files.fileName + "_files";
                        Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                    }
                    else
                    {
                        Files.fileName = Path.GetFileNameWithoutExtension(openFile.FileName) + "_new";
                        while (Directory.Exists(Files.systemDrive + "\\ThemeFiles\\" + Files.fileName + "_files"))
                        {
                            Files.fileName += "_new";
                        }
                        Files.currentSafeFile = Files.fileName + "_files";
                        Directory.CreateDirectory(Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile);
                        Files.currentFile = Files.systemDrive + "\\ThemeFiles\\" + Files.currentSafeFile;
                        ThemeExpand(openFile);
                    }
                }

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

                Files.themeFilename = Directory.GetFiles(Files.currentFile, "*.theme")[0];
                LoadTheme(Files.themeFilename);
                TempToSetting();
                this.Text = "FACE 主题编辑器 - " + Files.currentFile;
                this.button_SaveAll.Visible = true;
                this.EditTab.Visible = true;


            }
        }



        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Files.currentSafeFile))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Windows 桌面主题包文件|*.deskthemepack";
                saveFile.FileName = Files.fileName;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ThemePackup(saveFile);
                }
            }
        }


        private static void ThemeExpand(OpenFileDialog openFile)
        {
            Process p = new Process();
            p.StartInfo.FileName = "expand.exe";
            p.StartInfo.Arguments = $"-F:* {openFile.FileName} {Files.currentFile}";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.AutoFlush = true;
            p.WaitForExit();
            p.Dispose();
        }

        private static void ThemePackup(SaveFileDialog saveFile)
        {
            Process q = new Process();
            //q.StartInfo.FileName = "TOOLS\\BIN\\CABARC.EXE";
            q.StartInfo.FileName = "cabarc.exe";
            q.StartInfo.Arguments = $"-r -p -P ThemeFiles\\{Files.currentSafeFile}\\ n {saveFile.FileName} {Files.currentFile}\\*.*";
            q.StartInfo.UseShellExecute = false;
            q.StartInfo.RedirectStandardInput = true;
            q.StartInfo.RedirectStandardOutput = true;
            q.StartInfo.RedirectStandardError = true;
            q.StartInfo.CreateNoWindow = true;
            q.Start();
            q.StandardInput.AutoFlush = true;
            q.WaitForExit();
            q.Dispose();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            formAbout fa = new formAbout();
            fa.ShowDialog();
        }

        /*
        private void ToolStripMenuItem_AddWallpaper_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Files.currentSafeFile))
            {
                OpenFileDialog openWallpaper = new OpenFileDialog();
                openWallpaper.Filter = "图片|*.jpg;*.jpeg;*.bmp;*.dib;*.png;*.jfif;*.jpe;*.gif;*.tif;*.tiff;*.wdp;*.heic;*.heif;*.heics;*.heifs;*.hif;*.avci;*.avcs;*.avif;*.avifs";
                if (openWallpaper.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(Files.currentFile + "\\DesktopBackground"))
                    {
                        File.Copy(openWallpaper.FileName, Files.currentFile + "\\DesktopBackground\\" + openWallpaper.SafeFileName);
                    }
                }
            }

        }
        */

        private void Button_EditInfo_Click(object sender, EventArgs e)
        {

        }

        private void EditTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush _Brush = new SolidBrush(Color.Black);
            RectangleF _TabTextArea = (RectangleF)EditTab.GetTabRect(e.Index);
            StringFormat _sf = new StringFormat();
            _sf.LineAlignment = StringAlignment.Center;
            _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(EditTab.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);
        }

        private void label_WallpaperTab_Fill_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_WallpaperTab_DefWall_Click(object sender, EventArgs e)
        {

        }

        private void tabPageWallpaper_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_CursorTab_Default_Click(object sender, EventArgs e)
        {
            radioButton_CursorTab_Path1.Checked = false;
            radioButton_CursorTab_Path2.Checked = true;
            switch (comboBox_CursorTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_working.ani";
                        break;
                    }
                case 1:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_arrow.cur";
                        break;
                    }
                case 2:
                    {
                        textBox_CursorTab_Path.Text = String.Empty;
                        break;
                    }
                case 3:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_link.cur";
                        break;
                    }
                case 4:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_helpsel.cur";
                        break;
                    }
                case 5:
                    {
                        textBox_CursorTab_Path.Text = String.Empty;
                        break;
                    }
                case 6:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_unavail.cur";
                        break;
                    }
                case 7:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_pen.cur";
                        break;
                    }
                case 8:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_move.cur";
                        break;
                    }
                case 9:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_nesw.cur";
                        break;
                    }
                case 10:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_ns.cur";
                        break;
                    }
                case 11:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_nwse.cur";
                        break;
                    }
                case 12:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_ew.cur";
                        break;
                    }
                case 13:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_up.cur";
                        break;
                    }
                case 14:
                    {
                        textBox_CursorTab_Path.Text = "%SystemRoot%\\cursors\\aero_busy.ani";
                        break;
                    }
            }
        }



        private void textBox_CursorTab_Path_TextChanged(object sender, EventArgs e)
        {
            if (textBox_CursorTab_Path.Text.Length >= 12)
            {
                if (textBox_CursorTab_Path.Text.Substring(0, 12) == "ThemeCursors")
                {
                    radioButton_CursorTab_Path2.Checked = false;
                    radioButton_CursorTab_Path1.Checked = true;
                }
                else
                {
                    radioButton_CursorTab_Path1.Checked = false;
                    radioButton_CursorTab_Path2.Checked = true;
                }
            }
            else
            {
                radioButton_CursorTab_Path1.Checked = false;
                radioButton_CursorTab_Path2.Checked = true;
            }

            switch (comboBox_CursorTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        Files.tAppStarting = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 1:
                    {
                        Files.tArrow = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 2:
                    {
                        Files.tCrosshair = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 3:
                    {
                        Files.tHand = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 4:
                    {
                        Files.tHelp = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 5:
                    {
                        Files.tIBeam = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 6:
                    {
                        Files.tNo = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 7:
                    {
                        Files.tNWPen = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 8:
                    {
                        Files.tSizeAll = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 9:
                    {
                        Files.tSizeNESW = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 10:
                    {
                        Files.tSizeNS = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 11:
                    {
                        Files.tSizeNWSE = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 12:
                    {
                        Files.tSizeWE = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 13:
                    {
                        Files.tUpArrow = textBox_CursorTab_Path.Text;
                        break;
                    }
                case 14:
                    {
                        Files.tWait = textBox_CursorTab_Path.Text;
                        break;
                    }
            }
        }

        private void textBox_IconTab_Path_TextChanged(object sender, EventArgs e)
        {
            if (textBox_IconTab_Path.Text.Length >= 10)
            {
                if (textBox_IconTab_Path.Text.Substring(0, 10) == "ThemeIcons")
                {
                    radioButton_IconTab_Path2.Checked = false;
                    radioButton_IconTab_Path1.Checked = true;
                }
                else
                {
                    radioButton_IconTab_Path1.Checked = false;
                    radioButton_IconTab_Path2.Checked = true;
                }
            }
            else
            {
                radioButton_IconTab_Path1.Checked = false;
                radioButton_IconTab_Path2.Checked = true;
            }


            switch (comboBox_IconTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        Files.tComputer = textBox_IconTab_Path.Text;
                        break;
                    }
                case 1:
                    {
                        Files.tUsers = textBox_IconTab_Path.Text;
                        break;
                    }
                case 2:
                    {
                        Files.tNetwork = textBox_IconTab_Path.Text;
                        break;
                    }
                case 3:
                    {
                        Files.tBinFull = textBox_IconTab_Path.Text;
                        break;
                    }
                case 4:
                    {
                        Files.tBinEmpty = textBox_IconTab_Path.Text;
                        break;
                    }
            }
        }



        private void comboBox_IconTab_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_IconTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        textBox_IconTab_Path.Text = Files.tComputer;
                        break;
                    }
                case 1:
                    {
                        textBox_IconTab_Path.Text = Files.tUsers;
                        break;
                    }
                case 2:
                    {
                        textBox_IconTab_Path.Text = Files.tNetwork;
                        break;
                    }
                case 3:
                    {
                        textBox_IconTab_Path.Text = Files.tBinFull;
                        break;
                    }
                case 4:
                    {
                        textBox_IconTab_Path.Text = Files.tBinEmpty;
                        break;
                    }
            }
        }

        private void comboBox_CursorTab_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_CursorTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        textBox_CursorTab_Path.Text = Files.tAppStarting;
                        break;
                    }
                case 1:
                    {
                        textBox_CursorTab_Path.Text = Files.tArrow;
                        break;
                    }
                case 2:
                    {
                        textBox_CursorTab_Path.Text = Files.tCrosshair;
                        break;
                    }
                case 3:
                    {
                        textBox_CursorTab_Path.Text = Files.tHand;
                        break;
                    }
                case 4:
                    {
                        textBox_CursorTab_Path.Text = Files.tHelp;
                        break;
                    }
                case 5:
                    {
                        textBox_CursorTab_Path.Text = Files.tIBeam;
                        break;
                    }
                case 6:
                    {
                        textBox_CursorTab_Path.Text = Files.tNo;
                        break;
                    }
                case 7:
                    {
                        textBox_CursorTab_Path.Text = Files.tNWPen;
                        break;
                    }
                case 8:
                    {
                        textBox_CursorTab_Path.Text = Files.tSizeAll;
                        break;
                    }
                case 9:
                    {
                        textBox_CursorTab_Path.Text = Files.tSizeNESW;
                        break;
                    }
                case 10:
                    {
                        textBox_CursorTab_Path.Text = Files.tSizeNS;
                        break;
                    }
                case 11:
                    {
                        textBox_CursorTab_Path.Text = Files.tSizeNWSE;
                        break;
                    }
                case 12:
                    {
                        textBox_CursorTab_Path.Text = Files.tSizeWE;
                        break;
                    }
                case 13:
                    {
                        textBox_CursorTab_Path.Text = Files.tUpArrow;
                        break;
                    }
                case 14:
                    {
                        textBox_CursorTab_Path.Text = Files.tWait;
                        break;
                    }
            }
        }

        private void comboBox_WallpaperTab_Fill_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox_WallpaperTab_Fill.SelectedIndex)
            {
                case 0:
                    {
                        Files.tTileWallpaper = "0";
                        Files.tWallpaperStyle = "0";
                        break;
                    }
                case 1:
                    {
                        Files.tTileWallpaper = "1";
                        Files.tWallpaperStyle = "0";
                        break;
                    }
                case 2:
                    {
                        Files.tTileWallpaper = "0";
                        Files.tWallpaperStyle = "2";
                        break;
                    }
                case 3:
                    {
                        Files.tTileWallpaper = "0";
                        Files.tWallpaperStyle = "6";
                        break;
                    }
                case 4:
                    {
                        Files.tTileWallpaper = "0";
                        Files.tWallpaperStyle = "10";
                        break;
                    }
                case 5:
                    {
                        break;
                    }
            }
            Files.tPicturePosition = Convert.ToString(comboBox_WallpaperTab_Fill.SelectedIndex);
        }


        private void button_SaveAll_Click(object sender, EventArgs e)
        {
            //Textbox值写入
            INI.Write("Theme", "DisplayName", textBox_InfoTab_Name.Text, Files.themeFilename);
            Files.tDisplayName = textBox_InfoTab_Name.Text;

            INI.Write("Theme", "BrandImage", textBox_InfoTab_Preview.Text, Files.themeFilename);
            Files.tBrandImage = textBox_InfoTab_Preview.Text;

            INI.Write("Control Panel\\Desktop", "Wallpaper", textBox_WallpaperTab_DefWall.Text, Files.themeFilename);
            Files.tWallpaper = textBox_WallpaperTab_DefWall.Text;

            INI.Write("Control Panel\\Cursors", "AppStarting", Files.tAppStarting, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "Arrow", Files.tArrow, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "Crosshair", Files.tCrosshair, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "Hand", Files.tHand, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "Help", Files.tHelp, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "IBeam", Files.tIBeam, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "No", Files.tNo, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "NWPen", Files.tNWPen, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "SizeAll", Files.tSizeAll, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "SizeNESW", Files.tSizeNESW, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "SizeNS", Files.tSizeNS, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "SizeNWSE", Files.tSizeNWSE, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "SizeWE", Files.tSizeWE, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "UpArrow", Files.tUpArrow, Files.themeFilename);
            INI.Write("Control Panel\\Cursors", "Wait", Files.tWait, Files.themeFilename);

            INI.Write("CLSID\\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\\DefaultIcon", "DefaultValue", Files.tComputer, Files.themeFilename);
            INI.Write("CLSID\\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\\DefaultIcon", "DefaultValue", Files.tUsers, Files.themeFilename);
            INI.Write("CLSID\\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\\DefaultIcon", "DefaultValue", Files.tNetwork, Files.themeFilename);
            INI.Write("CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}\\DefaultIcon", "Full", Files.tBinFull, Files.themeFilename);
            INI.Write("CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}\\DefaultIcon", "Empty", Files.tBinEmpty, Files.themeFilename);

            INI.Write("VisualStyles", "Path", textBox_VisualTab_Path.Text, Files.themeFilename);
            Files.tPath = textBox_VisualTab_Path.Text;

            INI.Write("VisualStyles", "ColorizationColor", textBox_VisualTab_ColorView.Text, Files.themeFilename);
            Files.tColorizationColor = textBox_VisualTab_ColorView.Text;

            INI.Write("boot", "SCRNSAVE.EXE", textBox_OtherTab_ScrnSave.Text, Files.themeFilename);
            Files.tSCRNSAVE_EXE = textBox_OtherTab_ScrnSave.Text;

            INI.Write("Sounds", "SchemeName", textBox_OtherTab_Sound.Text, Files.themeFilename);
            Files.tSchemeName = textBox_OtherTab_Sound.Text;

            INI.Write("VisualStyles", "ColorStyle", textBox_OtherTab_Color.Text, Files.themeFilename);
            Files.tColorStyle = textBox_OtherTab_Color.Text;

            INI.Write("VisualStyles", "Size", textBox_OtherTab_Size.Text, Files.themeFilename);
            Files.tSize = textBox_OtherTab_Size.Text;


            //comboBox值写入
            INI.Write("Control Panel\\Desktop", "TileWallpaper", Files.tTileWallpaper, Files.themeFilename);
            INI.Write("Control Panel\\Desktop", "WallpapaerStyle", Files.tWallpaperStyle, Files.themeFilename);
            INI.Write("Control Panel\\Desktop", "PicturePosition", Files.tPicturePosition, Files.themeFilename);

            //checkBox值写入
            if (checkBox_WallpaperTab_Fill.Checked == true)
            {
                INI.Write("Control Panel\\Desktop", "MultimonBackgrounds", "1", Files.themeFilename);
                Files.tMultimonBackgrounds = "1";
            }
            else
            {
                INI.Write("Control Panel\\Desktop", "MultimonBackgrounds", "0", Files.themeFilename);
                Files.tMultimonBackgrounds = "0";
            }


            if (checkBox_VisualTab_AutoColor.Checked == true)
            {
                INI.Write("VisualStyles", "AutoColorization", "1", Files.themeFilename);
                Files.tAutoColorization = "1";
            }
            else
            {
                INI.Write("VisualStyles", "AutoColorization", "0", Files.themeFilename);
                Files.tAutoColorization = "0";
            }


            if (checkBox_VisualTab_Transparency.Checked == true)
            {
                INI.Write("VisualStyles", "Transparency", "1", Files.themeFilename);
                Files.tTransparency = "1";
            }
            else
            {
                INI.Write("VisualStyles", "Transparency", "0", Files.themeFilename);
                Files.tTransparency = "0";
            }


            //radioButton值写入
            if (radioButton_VisualTab_DefWinColor1.Checked == true)
            {
                INI.Write("VisualStyles", "SystemMode", "Dark", Files.themeFilename);
                Files.tSystemMode = "Dark";
            }
            else if (radioButton_VisualTab_DefWinColor2.Checked == true)
            {
                INI.Write("VisualStyles", "SystemMode", "Light", Files.themeFilename);
                Files.tSystemMode = "Light";
            }

            if (radioButton_VisualTab_DefAppMode2.Checked == true)
            {
                INI.Write("VisualStyles", "AppMode", "Dark", Files.themeFilename);
                Files.tAppMode = "Dark";
            }
            else if (radioButton_VisualTab_DefAppMode1.Checked == true)
            {
                INI.Write("VisualStyles", "AppMode", "Light", Files.themeFilename);
                Files.tAppMode = "Light";
            }


            //幻灯片设置写入
            if (radioButton_WallpaperTab_Mode2.Checked == true)
            {
                INI.Write("Slideshow", "Interval", Files.tInterval, Files.themeFilename);
                INI.Write("Slideshow", "Shuffle", Files.tShuffle, Files.themeFilename);
                if (Files.tRSSFeed != string.Empty)
                {
                    INI.Write("Slideshow", "RSSFeed", Files.tRSSFeed, Files.themeFilename);
                }
                else if (Files.tImageRootPath != string.Empty)
                {
                    INI.Write("Slideshow", "ImageRootPath", Files.tImageRootPath, Files.themeFilename);
                }
            }
            else
            {
                INI.DeleteSection("Slideshow", Files.themeFilename);
            }

        }

        private void radioButton_WallpaperTab_Mode2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_WallpaperTab_Mode2.Checked == false)
            {
                button_WallpaperTab_SlideSettings.Enabled = false;
            }
            else
            {
                button_WallpaperTab_SlideSettings.Enabled = true;
            }
        }

        private void button_IconTab_Default_Click(object sender, EventArgs e)
        {
            radioButton_IconTab_Path1.Checked = false;
            radioButton_IconTab_Path2.Checked = true;
            switch (comboBox_IconTab_Select.SelectedIndex)
            {
                case 0:
                    {
                        textBox_IconTab_Path.Text = "%SystemRoot%\\System32\\imageres.dll,-109";
                        break;
                    }
                case 1:
                    {
                        textBox_IconTab_Path.Text = "%SystemRoot%\\System32\\imageres.dll,-123";
                        break;
                    }
                case 2:
                    {
                        textBox_IconTab_Path.Text = "%SystemRoot%\\System32\\imageres.dll,-25";
                        break;
                    }
                case 3:
                    {
                        textBox_IconTab_Path.Text = "%SystemRoot%\\System32\\imageres.dll,-54";
                        break;
                    }
                case 4:
                    {
                        textBox_IconTab_Path.Text = "%SystemRoot%\\System32\\imageres.dll,-55";
                        break;
                    }
            }
        }

        private void button_VisualTab_Default_Click(object sender, EventArgs e)
        {
            textBox_VisualTab_Path.Text = "%SystemRoot%\\resources\\themes\\Aero\\Aero.msstyles";
        }

        private void button_OtherTab_Sound_Click(object sender, EventArgs e)
        {
            textBox_OtherTab_Sound.Text = "@mmres.dll,-800";
        }

        private void button_OtherTab_Color_Click(object sender, EventArgs e)
        {
            textBox_OtherTab_Color.Text = "NormalColor";
        }

        private void button_OtherTab_Size_Click(object sender, EventArgs e)
        {
            textBox_OtherTab_Size.Text = "NormalSize";
        }



        private void button_InfoTab_Preview_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofPreview = new OpenFileDialog();
            ofPreview.Filter = "PNG 图像文件|*.png";
            if (ofPreview.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofPreview.FileName, Files.currentFile + "\\Preview.png", true);
                textBox_InfoTab_Preview.Text = "Preview.png";
            }
            else;

        }


        //连环检测
        private void button_WallpaperTab_DefWall_Click(object sender, EventArgs e)
        {
            OpenFileDialog openWallpaper = new OpenFileDialog();
            openWallpaper.Filter = "图片|*.jpg;*.jpeg;*.bmp;*.dib;*.png;*.jfif;*.jpe;*.gif;*.tif;*.tiff;*.wdp;*.heic;*.heif;*.heics;*.heifs;*.hif;*.avci;*.avcs;*.avif;*.avifs";
            if (openWallpaper.ShowDialog() == DialogResult.OK)
            {
                if (openWallpaper.FileName == Files.currentFile + "\\DesktopBackground\\" + openWallpaper.SafeFileName)
                {
                    textBox_WallpaperTab_DefWall.Text = "DesktopBackground\\" + openWallpaper.SafeFileName;
                    radioButton_WallpaperTab_DefWall2.Checked = false;
                    radioButton_WallpaperTab_DefWall1.Checked = true;
                }
                else
                {
                    textBox_WallpaperTab_DefWall.Text = openWallpaper.FileName;
                    radioButton_WallpaperTab_DefWall1.Checked = false;
                    radioButton_WallpaperTab_DefWall2.Checked = true;
                }
            }
        }

        private void textBox_WallpaperTab_DefWall_TextChanged(object sender, EventArgs e)
        {
            if (textBox_WallpaperTab_DefWall.Text.Length >= 17)
            {
                if (textBox_WallpaperTab_DefWall.Text.Substring(0, 17) == "DesktopBackground")
                {
                    radioButton_WallpaperTab_DefWall2.Checked = false;
                    radioButton_WallpaperTab_DefWall1.Checked = true;
                }
                else
                {
                    radioButton_WallpaperTab_DefWall1.Checked = false;
                    radioButton_WallpaperTab_DefWall2.Checked = true;
                }
            }
            else
            {
                radioButton_WallpaperTab_DefWall1.Checked = false;
                radioButton_WallpaperTab_DefWall2.Checked = true;
            }

        }

        /*
        private void radioButton_WallpaperTab_DefWall1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_WallpaperTab_DefWall.Text = string.Empty;
        }
        */
        //连环检测结束


        private void button_CursorTab_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCursor = new OpenFileDialog();
            openCursor.Filter = "光标文件|*.cur;*.ani";
            if (openCursor.ShowDialog() == DialogResult.OK)
            {
                if (openCursor.FileName == Files.currentFile + "\\ThemeCursors\\" + openCursor.SafeFileName)
                {
                    textBox_CursorTab_Path.Text = "ThemeCursors\\" + openCursor.SafeFileName;
                    radioButton_CursorTab_Path2.Checked = false;
                    radioButton_CursorTab_Path1.Checked = true;
                }
                else
                {
                    textBox_CursorTab_Path.Text = openCursor.FileName;
                    radioButton_CursorTab_Path1.Checked = false;
                    radioButton_CursorTab_Path2.Checked = true;
                }
            }
        }

        /*
        private void radioButton_CursorTab_Path1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_CursorTab_Path.Text = string.Empty;
        }
        */




        private void button_IconTab_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openIcon = new OpenFileDialog();
            openIcon.Filter = "图标文件|*.ico|动态链接库|*.dll|所有文件|*.*";
            if (openIcon.ShowDialog() == DialogResult.OK)
            {
                if (openIcon.FileName == Files.currentFile + "\\ThemeIcons\\" + openIcon.SafeFileName)
                {
                    textBox_IconTab_Path.Text = "ThemeIcons\\" + openIcon.SafeFileName;
                    radioButton_IconTab_Path2.Checked = false;
                    radioButton_IconTab_Path1.Checked = true;
                }
                else
                {
                    textBox_IconTab_Path.Text = openIcon.FileName;
                    radioButton_IconTab_Path1.Checked = false;
                    radioButton_IconTab_Path2.Checked = true;
                }

                if (Path.GetExtension(openIcon.FileName) != ".ico")
                {
                    textBox_IconTab_Path.Text += ",-0";
                }
            }

        }

        private void button_VisualTab_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openVis = new OpenFileDialog();
            openVis.Filter = "样式文件|*.msstyles";
            if (openVis.ShowDialog() == DialogResult.OK)
            {
                if (openVis.FileName == Files.currentFile + "\\" + openVis.SafeFileName)
                {
                    textBox_VisualTab_Path.Text = openVis.SafeFileName;
                    radioButton_VisualTab_Path2.Checked = false;
                    radioButton_VisualTab_Path1.Checked = true;
                }
                else
                {
                    textBox_VisualTab_Path.Text = openVis.FileName;
                    radioButton_VisualTab_Path1.Checked = false;
                    radioButton_VisualTab_Path2.Checked = true;
                }
            }
        }

        private void textBox_VisualTab_Path_TextChanged(object sender, EventArgs e)
        {
            if (textBox_VisualTab_Path.Text.Length >= 1)
            {
                if (textBox_VisualTab_Path.Text.Substring(0, 1) == "%")
                {
                    radioButton_VisualTab_Path1.Checked = false;
                    radioButton_VisualTab_Path2.Checked = true;
                }
                else;
            }
            if (textBox_VisualTab_Path.Text.Length >= 2)
            {
                if (textBox_VisualTab_Path.Text.Substring(1, 1) == ":")
                {
                    radioButton_VisualTab_Path1.Checked = false;
                    radioButton_VisualTab_Path2.Checked = true;
                }
                else;
            }
        }

        private void button_OtherTab_ScrnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openScrnSave = new OpenFileDialog();
            openScrnSave.Filter = "屏幕保护程序|*.scr;*.exe";
            if (openScrnSave.ShowDialog() == DialogResult.OK)
            {
                if (openScrnSave.FileName == Files.currentFile + "\\" + openScrnSave.SafeFileName)
                {
                    textBox_OtherTab_ScrnSave.Text = openScrnSave.SafeFileName;
                    radioButton_OtherTab_ScrnSave2.Checked = false;
                    radioButton_OtherTab_ScrnSave1.Checked = true;
                }
                else
                {
                    textBox_OtherTab_ScrnSave.Text = openScrnSave.FileName;
                    radioButton_OtherTab_ScrnSave1.Checked = false;
                    radioButton_OtherTab_ScrnSave2.Checked = true;
                }
            }
        }

        private void textBox_OtherTab_ScrnSave_TextChanged(object sender, EventArgs e)
        {
            if (textBox_OtherTab_ScrnSave.Text.Length >= 1)
            {
                if (textBox_OtherTab_ScrnSave.Text.Substring(0, 1) == "%")
                {
                    radioButton_OtherTab_ScrnSave1.Checked = false;
                    radioButton_OtherTab_ScrnSave2.Checked = true;
                }
                else;
            }
            if (textBox_OtherTab_ScrnSave.Text.Length >= 2)
            {
                if (textBox_OtherTab_ScrnSave.Text.Substring(1, 1) == ":")
                {
                    radioButton_OtherTab_ScrnSave1.Checked = false;
                    radioButton_OtherTab_ScrnSave2.Checked = true;
                }
                else;
            }
        }

        private void button_VisualTab_ColorSelect_Click(object sender, EventArgs e)
        {
            ColorDialog cdThemeColor = new ColorDialog();
            cdThemeColor.AnyColor = true;
            cdThemeColor.AllowFullOpen = true;
            cdThemeColor.FullOpen = true;
            cdThemeColor.Color = textBox_VisualTab_ColorView.BackColor;
            if (cdThemeColor.ShowDialog() == DialogResult.OK)
            {
                textBox_VisualTab_ColorView.BackColor = cdThemeColor.Color;
                textBox_VisualTab_ColorView.Text = "0X" + (Convert.ToString(cdThemeColor.Color.A, 16).PadLeft(2, '0') + Convert.ToString(cdThemeColor.Color.R, 16).PadLeft(2, '0') + Convert.ToString(cdThemeColor.Color.G, 16).PadLeft(2, '0') + Convert.ToString(cdThemeColor.Color.B, 16).PadLeft(2, '0')).ToUpper();
                if (textBox_VisualTab_ColorView.BackColor.GetBrightness() < 0.5)
                {
                    textBox_VisualTab_ColorView.ForeColor = Color.White;
                }
                else
                {
                    textBox_VisualTab_ColorView.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_VisualTab_ColorView_TextChanged(object sender, EventArgs e)
        {
            textBox_VisualTab_ColorView.BackColor = Color.White;
            textBox_VisualTab_ColorView.ForeColor = Color.Black;
            if (textBox_VisualTab_ColorView.Text.Length == 10)
            {
                if (textBox_VisualTab_ColorView.Text.Substring(0, 2) == "0X" && IsHexaDecimal(textBox_VisualTab_ColorView.Text.Substring(2, 8)) == true)
                {
                    Files.colorAlpha = Int32.Parse(textBox_VisualTab_ColorView.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    Files.colorRed = Int32.Parse(textBox_VisualTab_ColorView.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    Files.colorGreen = Int32.Parse(textBox_VisualTab_ColorView.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    Files.colorBlue = Int32.Parse(textBox_VisualTab_ColorView.Text.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                    textBox_VisualTab_ColorView.BackColor = Color.FromArgb(Files.colorRed, Files.colorGreen, Files.colorBlue);
                    if (textBox_VisualTab_ColorView.BackColor.GetBrightness() < 0.5)
                    {
                        textBox_VisualTab_ColorView.ForeColor = Color.White;
                    }
                    else
                    {
                        textBox_VisualTab_ColorView.ForeColor = Color.Black;
                    }
                }
            }
        }

        /*
        private void radioButton_IconTab_Path1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_IconTab_Path.Text = string.Empty;
        }
        */


        public bool IsHexaDecimal(string str)
        {
            const string PATTERN = @"([A-F0-9])+$";
            return System.Text.RegularExpressions.Regex.IsMatch(str, PATTERN);
        }








        private void button_WallpaperTab_SlideSettings_Click(object sender, EventArgs e)
        {
            FormSlideSettings fss = new FormSlideSettings();
            fss.ShowDialog();
        }

        private void ToolStripMenuItem_Cut_Click(object sender, EventArgs e)
        {


        }
    }
}
