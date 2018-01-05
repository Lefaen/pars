using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars.classes
{
    class Strings
    {
        public static List<string> arrDomain = new List<string>();

        public void ReadString()
        {

        }

        public void Correct()
        {
            string pattern = "http://";
            List<string> arr = new List<string>();
            foreach (string elm in arrDomain)
            {
                if (elm.StartsWith(pattern))
                {
                    arr.Add(elm);
                } else
                {
                    arr.Add(pattern + elm);
                }
            }
            
            arrDomain = arr;
            foreach (string elm in arrDomain)
            {
                Console.WriteLine(elm);
            }
        }
    }
}
