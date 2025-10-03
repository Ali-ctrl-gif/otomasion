using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasion
{
    public class Personals
    {
        public string Name { get; set; }
        public string Post { get; set; }
        private int pid { get; set; }
        public int PID
        {
            get { return pid; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("input is invalid");
                }
                else
                {
                    pid = value;
                }
            }
        }
        public Personals(string name, string post, int pid)
        {
            this.Name = name;
            this.Post = post;
            this.PID = pid;
        }
    }
}
