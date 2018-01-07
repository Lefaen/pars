using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pars.classes
{
    class Manage
    {
        Regex pattern = new Regex("[0-9]");
        public string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                if (pattern.IsMatch(Path))
                {
                    Console.WriteLine("Путь не может начинаться с цифры");
                    path = null;
                }
                else
                {
                    path = value;
                }
            }
        }

        private void Sort()
        {

        }
        private void Rec()
        {

        }
        public void Enter()
        {
            Console.WriteLine("Для ввода доменов через файл нажмите 1");
            Console.WriteLine("Для ввода доменов вручную нажмите 2");
            int read = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (read == 1)
            {
               
                Console.WriteLine("Введите путь");
                path = "../../testArray.txt";               //test path
                classes.Files file = new classes.Files();
                file.StreamDomain(Path);
            }
            else
            {
                if (read == 2) 
                {
                    Console.WriteLine("ручной'ввод");
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
                            Program.arrDomain.Add(line);
                        }
                    }
                }
            }
        }
        public void View(List<string> arr)
        {
            foreach(string elm in arr)
            {
                Console.WriteLine(elm);
            }
        }
    }
}
