using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Organiser
{
    public static class ErrorHandler
    {
        public static void ThrowError(Exception error, [CallerMemberName] string callerName = "")
        {
            var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

            Trace.WriteLine($"[{dateTime}] Error occured from ({callerName}): {error.Message}");

            using (StreamWriter writer = File.CreateText(Constants.ErrorLogLocation))
            {
                writer.WriteLine($"[{dateTime}] Error occured - ({callerName}): {error.Message}");
            }

            throw error;
        }
    }
}
