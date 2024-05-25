using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface IMessage
    {
        string Date { get; set; }
        string Text { get; set; }
    }
}
