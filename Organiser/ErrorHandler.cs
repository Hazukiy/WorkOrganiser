using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

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
