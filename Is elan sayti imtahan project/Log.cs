using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Log
    {
        public Log(string text, DateTime date)
        {
            Text = text;
            this.date = date;
        }

        public string Text { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return $"Text: {Text}\nDate: {DateTime.Now.ToString()}";
        }
    }
}
