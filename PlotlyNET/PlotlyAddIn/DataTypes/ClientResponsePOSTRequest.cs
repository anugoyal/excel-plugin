using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlyAddIn.Ribbon.DataTypes
{
    public class ClientResponsePOSTRequest
    {
        public string un { get; set; }
        public string key { get; set; }
        public string origin {get; set;}
        public string platform {get; set;}
        public Kwargs kwargs {get; set;}
        public string args {get; set;}

        public override string ToString()
        {
            string temp = System.Web.HttpUtility.UrlEncode(args);
            //string args = "%5B%5B0%2C+1%2C+2%5D%2C+%5B3%2C+4%2C+5%5D%2C+%5B1%2C+2%2C+3%5D%2C+%5B6%2C+6%2C+5%5D%5D";
            string completeParamsTemplate = "un={0}&key={1}&origin={2}&platform={3}&args={4}&kwargs={5}";
            return string.Format(completeParamsTemplate, un, key, origin, platform, temp, kwargs.ToString());
        }
    }

    public class Kwargs
    {
        public string filename {get; set;}
        public string fileopt {get; set;}

        public override string ToString()
        {
            //string kwargs = "%7B%22filename%22%3A+%22test%22%2C+%22fileopt%22%3A+%22overwrite%22%7D";
            string kwargs = "%7B%22filename%22%3A+%22{0}%22%2C+%22fileopt%22%3A+%22{1}%22%7D";
            //string completeParamsTemplate = "filename={0}&fileopt={1}";
            return string.Format(kwargs, filename, fileopt);
        }
    }

}
