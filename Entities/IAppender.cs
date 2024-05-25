using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface IAppender
    {
        int ReportLevel { get; set; }

        void append(string date, string error, int reportLevel);
    }
}
