using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pars
{
    class Program
    {

        static void Main(string[] args)
        {
            classes.Manage manage = new classes.Manage();
            classes.Strings st = new classes.Strings();
            classes.Download Connect = new classes.Download();

            //manage.Enter();
            
            Connect.Connect("http://mycsharp.ru/");
            
            
            
            //classes.Files file = new classes.Files();
            //file.StreamDomain("../../testHref.txt");
            //foreach (string elm in classes.Strings.href)
          //  {
            //    st.InitHef(elm);
            //}




            Console.WriteLine();
            Console.WriteLine("press key for exit");
            Console.ReadKey();
        }
    }
}
