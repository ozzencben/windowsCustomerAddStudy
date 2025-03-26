using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControl
{
    public class database
    {
        public static List<customer> customers {  get; set; }
     
        static database()
        {
            customers = new List<customer>();
        }
    }
}
