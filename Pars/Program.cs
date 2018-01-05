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
            //manage.Enter();
            classes.Download Connect = new classes.Download();
            Connect.Connect("http://mycsharp.ru");

            Console.WriteLine();
            Console.WriteLine("press key for exit");
            Console.ReadKey();
        }
    }
}
