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
            manage.Enter("../../testArray.txt");
            manage.Conc(classes.Strings.arrDomain);

            Console.WriteLine();
            Console.WriteLine("press key for exit");
            Console.ReadKey();
        }
    }
}
