using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
 
namespace Pars.classes
{
    class Download
    {
        public static StreamReader Connect(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader;
            
            //Strings.InitHref(reader.ReadToEnd());
        }
    }
}
