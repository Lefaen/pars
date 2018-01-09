using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Threading.Tasks;

namespace Pars
{
    class Program
    {
        public static List<string> arrDomain = new List<string>();
        public static List<string> href = new List<string>();
        //public static List<string> domainHref = new List<string>();
        public static string path;
        public static string pathSave;


        static void Main(string[] args)
        {
            classes.Manage manage = new classes.Manage();
            classes.Files file = new classes.Files();
            StreamReader reader;
            StreamReader domainReader;

            manage.Enter();                                                 //получение списка доменов

            arrDomain = classes.Strings.Correct(arrDomain, "http://");      //коррекция имени
            manage.Rec();
            //manage.View(arrDomain);
            
            foreach (string elm in arrDomain)
            {

                reader = classes.Download.Connect(elm);                 //test domain -> elm
                pathSave = Path.Combine("d:/", classes.Strings.Correct(elm));
                Directory.CreateDirectory(pathSave);
                
                href = classes.Strings.InitHref(reader.ReadToEnd());    //отбор ссылок
                href = classes.Strings.Correct(href, elm);              //Коррекция
                href = classes.Strings.Remove(href, elm+"http");        //удаление лишних доменнов

                

                foreach (string elm2 in href)
                {
                    try
                    {
                        List<string> array = new List<string>();
                        
                        domainReader = classes.Download.Connect(elm2);
                        array = classes.Strings.InitHref(reader.ReadToEnd());    //отбор ссылок
                        array = classes.Strings.Correct(href, elm);              //Коррекция
                        array = classes.Strings.Remove(href, elm + "http");      //удаление лишних доменнов

                        file.WriteFile(pathSave + "/", classes.Strings.Correct(elm2), domainReader.ReadToEnd());
                        //domainHref.AddRange(array.Distinct<string>().ToList<string>());
                        //domainHref = domainHref.Distinct<string>().ToList<string>();


                        domainReader.Close();
                        Console.WriteLine(elm2);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                
                
                reader.Close();
            }
            //manage.View(domainHref);

            //запись

            
            
            

            Console.WriteLine();
            Console.WriteLine("press key for exit");
            Console.ReadKey();
        }
    }
}
