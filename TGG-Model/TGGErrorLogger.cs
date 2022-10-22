using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace TGG_Model
{
    public static class TGGErrorLogger
    {
        //log error to errorLogs.txt file
        public static void WriteLogToFile(Exception exception)
        {
            string filepath = ConfigurationManager.AppSettings["ErrorlogPath"];
            StreamWriter errorLogger = new StreamWriter(filepath, true);
            errorLogger.WriteLine($"[{DateTime.Now}] : {exception.Message} {exception.StackTrace}");
            errorLogger.Close();
        }
    }
}
