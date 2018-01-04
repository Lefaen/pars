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
                StreamReader fileDomain = new StreamReader(name);
                string stringFile;
                while ((stringFile = fileDomain.ReadLine()) != null)
                {
                    Strings.arrDomain.Add(stringFile);
                    Console.WriteLine(Strings.arrDomain.Last<String>());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
            
    }
}