using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasion
{
    public class Messages
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Messages(string type, string text, string date, string time)
        {
            this.Type = type;
            this.Text = text;
            this.Date = date;
            this.Time = time;
        }
    }
}
