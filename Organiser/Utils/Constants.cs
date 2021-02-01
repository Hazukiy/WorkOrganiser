using System;
using System.Drawing;
using System.IO;

namespace Organiser
{
    public static class Constants
    {
        public const string SavePath = @"D:\Development\Git Repo\WorkOrganiser\Database\";
        public const string DatabaseName = @"ProjectOrganiser.db";
        public static string DatabaseConnection = Path.Combine(SavePath, DatabaseName);
        public static string BackupLocation = Path.Combine(SavePath, "Backups", $"{DateTime.Now:dd-MM-yyyy}");
        public static string ErrorLogLocation = Path.Combine(SavePath, "ErrorLog.log"); 

        public static SolidBrush ActiveItem = new SolidBrush(Color.FromArgb(73, 232, 25)); //Green
        public static SolidBrush BlockedItem = new SolidBrush(Color.FromArgb(242, 43, 43)); //Red
        public static SolidBrush CompletedItem = new SolidBrush(Color.FromArgb(187, 187, 187)); //Grey
        public static SolidBrush ValidationItem = new SolidBrush(Color.FromArgb(0, 206, 209)); //Blue
    }
}
