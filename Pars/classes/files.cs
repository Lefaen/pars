﻿using System;
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
                    Strings.href.Add(stringFile);//href -> domain
                }
                classes.Strings st = new classes.Strings();
                st.Correct();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
            
    }
}
