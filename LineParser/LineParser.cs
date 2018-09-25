using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LineParser
{
    class LineParser
    {

        private string ReadFile(string path)
        {
            //Dont believe in pointless error handling, unless there is a need to hide/log errors. Keep it simple
            string contents = System.IO.File.ReadAllText(@path);

            return contents;
        }

        private void WriteFile(string path, string contents)
        {
            System.IO.File.WriteAllText(@path, contents);
        }

        private string RemoveLineBreaks(string content)
        {
            string formated = Regex.Replace(content, @"\r\n?|\n", ""); ;
            return formated;
        }

        private string LimitCharacters(string content)
        {
            string returnValue = "";
            return returnValue;
        }

        static void Main(string[] args)
        {
        }
    }
}
