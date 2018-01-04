using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars.classes
{
    class Manage
    {
        public string Path { get; set; }

        private void Sort()
        {

        }
        private void Rec()
        {

        }
        public void Enter(string fileName)
        {
            Console.WriteLine("Для ввода доменов через файл нажмите 1");
            Console.WriteLine("Для ввода доменов вручную нажмите 2");
            int read = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (read == 1)
            {
                classes.Files file = new classes.Files();
                file.StreamDomain(fileName);
            }
            else
            {
                if (read == 2) 
                {
                    Console.WriteLine("ручной");
                    Console.WriteLine("'0' для завершения");
                    string line;
                    bool a = true;
                    while (a == true)
                    {
                        if ((line = Convert.ToString(Console.ReadLine())) == "0")
                        {
                            Console.WriteLine("Был введен 0");
                            break;
                        }
                        else
                        {
                            Strings.arrDomain.Add(line);
                        }

                    }
                    
                }
            }

            
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
        public void Conc(List<string> arr)
        {
            Strings.arrDomain.ForEach(Print);
            
        }
        

    }
}
