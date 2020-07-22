using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserV2.Utils
{
    public static class ErrorHandler
    {
        private static string ErrorDirectory => $@"{Directory.GetCurrentDirectory()}\ErrorLogs\";

        //Write error to file
        public static void CatchError(Exception error, [CallerMemberName] string callerName = "")
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

            #if DEBUG
                Trace.WriteLine($"[{dateTime}] Error occured from ({callerName}): {error.Message}");
            #endif

            if (!Directory.Exists(ErrorDirectory))
            {
                Directory.CreateDirectory(ErrorDirectory);
            }

            using (StreamWriter writer = File.CreateText(Path.Combine(ErrorDirectory, "ErrorLog.log")))
            {
                writer.WriteLine($"[{dateTime}] Error occured - ({callerName}): {error.Message}");
            }

            throw error;
        }

    }
}
