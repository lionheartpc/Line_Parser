using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LineParserClass
{
    public class LineParser
    {
        /// <summary>
        /// Reads file from a given location, if path does not exist returns an error
        /// </summary>
        /// <param name="path"> path to a file to be read</param>
        /// <returns>contents of a string read from a file</returns>
        public string ReadFile(string path)
        {
            //Dont believe in pointless error handling, unless there is a need to hide/log errors. Keep it simple
            string contents = System.IO.File.ReadAllText(@path);

            return contents;
        }

        /// <summary>
        /// Writes to a file at a location
        /// </summary>
        /// <param name="path"> path of a file to write on</param>
        /// <param name="contents"> contents to be written to a file at a path location</param>
        public void WriteFile(string path, string contents)
        {
            System.IO.File.WriteAllText(@path, contents);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string RemoveLineBreaks(string content)
        {
            string formated = Regex.Replace(content, @"\r\n?|\n", " "); ;
            return formated;
        }

        public string LimitCharacters(string content, int rowLength)
        {

            string line = "";
            StringBuilder result = new StringBuilder();

            Queue<string> queue = new Queue<string>(content.Split(' '));

            while (queue.Count > 0 )
            {
                var word = queue.Dequeue().Trim();


                if (word.Length >= rowLength)
                {
                    result.Append(line + System.Environment.NewLine);
                    line = "";
                    result.Append(word + System.Environment.NewLine);
                }
                else
                {
                    if ((line + word).Length > rowLength-1)
                    {
                        result.Append(line + System.Environment.NewLine);
                        line = word;
                    }
                    else
                    {
                        line =line.Trim() +" "+ word.Trim();
                    }
                }

                if (queue.Count == 0 && word.Length < rowLength)
                {
                    result.Append(line);
                }


            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            string content;
            LineParser obj = new LineParser();
            content = obj.ReadFile("D:\\c.txt");
            content = obj.RemoveLineBreaks(content);
            content = obj.LimitCharacters(content, 10);
            obj.WriteFile("D:\\d.txt", content);
        }
    }
}
