using System;
using System.Windows.Forms;

namespace FACE_THEME_NEW
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Files.newReturn = 1;
            Files.currentFile = string.Empty;
            Files.currentSafeFile = string.Empty;
            Files.systemDrive = string.Empty;
            Files.fileName = string.Empty;
            Files.themeFilename = string.Empty;
            Files.colorAlpha = 255;
            Files.colorRed = 255;
            Files.colorGreen = 255;
            Files.colorBlue = 255;
        }
    }

    public class Files
    {
        public static string currentFile;
        public static string currentSafeFile;
        public static string systemDrive;
        public static string fileName;
        public static string themeFilename;
        public static int newReturn;
        public static int colorAlpha;
        public static int colorRed;
        public static int colorGreen;
        public static int colorBlue;


        public static string tDisplayName, tBrandImage;

        public static string tWallpaper, tTileWallpaper, tWallpaperStyle, tMultimonBackgrounds, tPicturePosition;

        public static string tInterval, tShuffle, tRSSFeed, tImageRootPath;

        public static string tPath, tColorizationColor, tTransparency, tAutoColorization, tAppMode, tSystemMode, tColorStyle, tSize;

        public static string tComputer, tUsers, tNetwork, tBinEmpty, tBinFull;

        public static string tAppStarting, tArrow, tCrosshair, tHand, tHelp, tIBeam, tNo, tNWPen, tSizeAll, tSizeNESW, tSizeNS, tSizeNWSE, tSizeWE, tUpArrow, tWait;

        public static string tSCRNSAVE_EXE, tSchemeName;






    }
}
