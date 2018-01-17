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
        
        public static List<string> InitHref(string reader)
        {
            Match m;
            try
            {
                List<string> arr = new List<string>();
                string regHref = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";
                

                m = Regex.Match(reader, regHref, RegexOptions.Compiled, TimeSpan.FromSeconds(1));
                while(m.Success)
                {
                    //Console.WriteLine("Found href " + m.Groups[1] + " at " + m.Groups[1].Index);
                    arr.Add(m.Groups[1].ToString());
                    m = m.NextMatch();
                    
                }
                return arr;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<string> Correct(List<string> array, string pattern)
        {
            List<string> arr = new List<string>();
            foreach (string elm in array)
            {
                if (elm.StartsWith(pattern, StringComparison.OrdinalIgnoreCase))
                {
                    arr.Add(elm);
                }
                else
                {
                    arr.Add(pattern + elm);
                }
            }
            return arr;
        }
        public static List<string> Remove(List<string> array, string remove)
        {
            List<string> arr = new List<string>();
            foreach (string elm in array)
            {
                if (!elm.StartsWith(remove, StringComparison.OrdinalIgnoreCase))
                {
                    arr.Add(elm);
                }
            }
            return arr;
        }
        public static string Correct(string name)
        {
            string value = null;

            if (name.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {

                value = name.Replace("http://","");
                value = value.Replace("/", "_");
                value = value.Replace(":","_");
                value = value.Replace("?", "_");
            }


            return value;
        }


    }
}
