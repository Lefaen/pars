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
                fileDomain.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Введите путь еще раз");
                Program.path = "../../testArray.txt";               //test path
                Program.path = Console.ReadLine();
                classes.Files file = new classes.Files();
                file.StreamDomain(Program.path);
            }
        }


        public void WriteFile(string path, string name, string txt)
        {
            try
            {
                if(!File.Exists(path + name + ".txt"))
                {
                    FileStream file = new FileStream(path + name + ".txt", FileMode.Create);
                    StreamWriter writer = new StreamWriter(file);
                    writer.Write(txt);
                    writer.Close();
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


            
    }
}
