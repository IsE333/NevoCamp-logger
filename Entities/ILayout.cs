using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface ILayout
    {
        string formattedMessage(string date, string message, int reportLevel);
    }
}
