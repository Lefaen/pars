using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pars.classes
{
    class Strings
    {
        public static List<string> arrDomain = new List<string>();
        public static List<string> href = new List<string>();

        public static void InitHref(string txt)
        {
            Match m;
            try
            {
                List<string> arr = new List<string>();
                string regHref = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";

                m = Regex.Match(txt, regHref, RegexOptions.Compiled, TimeSpan.FromSeconds(1));
                while(m.Success)
                {
                    //Console.WriteLine("Found href " + m.Groups[1] + " at " + m.Groups[1].Index);
                    arr.Add(m.Groups[1].ToString());
                    m = m.NextMatch();
                    href = Correct(arr);
                }
 
                foreach(string elm in href)
                {
                    Console.WriteLine(elm);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<string> Correct(List<string> array)
        {
            string pattern = "http://";
            List<string> arr = new List<string>();
            foreach (string elm in array)
            {
                if (elm.StartsWith(pattern))
                {
                    arr.Add(elm);
                } else
                {
                    arr.Add(pattern + elm);
                }
            }
            
            array = arr;
            return array;
        }
    }
}
