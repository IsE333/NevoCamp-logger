using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public class SimpleLayout : ILayout
    {
        public string formattedMessage(string date, string message, int reportLevel)
        {
            return ""+ date +" - "+ ReportLevel.stirngs[reportLevel] +" - <"+ message +">";
        }
    }
}
