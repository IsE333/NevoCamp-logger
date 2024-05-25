using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public class FileAppender : IAppender
    {
        private ILayout simpleLayout;
        public LogFile File { get; set; }
        public int ReportLevel { get; set; } = 0;

        public FileAppender(ILayout simpleLayout)
        {
            this.simpleLayout = simpleLayout;
        }

        public void append(string date, string error, int reportLevel)
        {
            if (!System.IO.File.Exists(File.filePath))
            {
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/Logs");
                System.IO.File.Create(File.filePath).Close();
            }

            System.IO.File.AppendAllText(File.filePath, simpleLayout.formattedMessage(date, error, reportLevel) +"\n");
        }
    }
}
