using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public class Message : IMessage
    {
        public string Date { get; set; }
        public string Text { get; set; }
        
        public Message(string date, string text)
        {
            Date = date;
            Text = text;
        }
    }
}
