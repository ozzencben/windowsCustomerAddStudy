using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControl
{
    public class customer
    {
        public Guid ıd { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public override string ToString()
        {
            return name + " " + surname;
        }
    }
}
