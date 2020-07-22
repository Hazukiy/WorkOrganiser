using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserV2.Database
{
    public static class DatabaseSettings
    {
        public static string DatabaseName = "ProjectOrganiser";

        public static string DatabasePath => $@"{Directory.GetCurrentDirectory()}\{DatabaseName}.db";

        public static string DatabaseBackupPath => $@"{Directory.GetCurrentDirectory()}\Backups\{DateTime.Now:dd-MM-yyyy}\";
    }
}
