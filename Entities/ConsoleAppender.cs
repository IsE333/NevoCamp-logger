using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public class ConsoleAppender : IAppender
    {
        public int ReportLevel { get; set; } = 0;
        ILayout Layout;
        
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public void append(string date, string error, int reportLevel)
        {
            Console.WriteLine(Layout.formattedMessage(date, error, reportLevel));
        }
    }
}
