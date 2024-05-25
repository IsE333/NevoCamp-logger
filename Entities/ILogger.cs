using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface ILogger
    {
        void Critical(string date, string error);
        void Error(string date, string error);
        void Fatal(string date, string error);
        void Info(string date, string info);
        void Warn(string date, string warn);
    }
}
