using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pars.classes
{
    class Files
    {
        public void StreamDomain(string name)
        {
            try
            {
                StreamReader fileDomain = new StreamReader(name,Encoding.UTF8);
                string stringFile;
                while ((stringFile = fileDomain.ReadLine()) != null)
                    
                {
                    Program.arrDomain.Add(stringFile);
                }
                //classes.Strings st = new classes.Strings();
                //classes.Strings.Correct(classes.Strings.arrDomain);
                fileDomain.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
            
    }
}
