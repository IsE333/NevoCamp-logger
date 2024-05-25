using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public static class ReportLevel
    {
        public static int INFO = 0;
        public static int WARNING = 1;
        public static int ERROR = 2;
        public static int CRITICAL = 3;
        public static int FATAL = 4;
        public static string[] stirngs = { "INFO", "WARNING", "ERROR", "CRITICAL", "FATAL" };
    }
}
