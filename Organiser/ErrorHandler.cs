using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Organiser
{
    public static class ErrorHandler
    {
        //Write error to file
        public static void ThrowError(Exception error, [CallerMemberName] string callerName = "")
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            var path = $@"D:\ProjectOrganiser\ErrorLog.log";

            Trace.WriteLine($"[{dateTime}] Error occured from ({callerName}): {error.Message}");

            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine($"[{dateTime}] Error occured - ({callerName}): {error.Message}");
            }

            throw error;
        }
    }
}
