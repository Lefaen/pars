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
        public void Rec()
        {
            Console.WriteLine("Введите путь для сохранения фалов");
            //Program.pathSave = Console.ReadLine();
            //Files.WriteFile(Program.pathSave);
        }
        public void Enter()
        {

            Console.WriteLine("Для ввода доменов через файл нажмите 1");
            Console.WriteLine("Для ввода доменов вручную нажмите 2");

            

            int read = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (read == 1)
            {
                Console.WriteLine("Введите путь для считывания доменнов из файла");
                Program.path = "../../testArray.txt";               //test path
                //Program.path = Console.ReadLine();
                classes.Files file = new classes.Files();
                file.StreamDomain(Program.path);
                
                
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
                            a = false;
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
