using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasion
{
    public class student
    {
        public string Name;
        public int Age;
        public int Donation;

        public student(string name, int age, int donation)
        {
            this.Name = name;
            this.Age = age;
            this.Donation = donation;
        }
    }
}
