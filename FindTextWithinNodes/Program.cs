using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindTextWithinNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fs = new StreamReader(@"C:\1.txt");
            string s = string.Empty;
            string TheEnd = string.Empty;
            List<string> list = new List<string>();

            while (s != null)
            {
                s = fs.ReadLine();
                list.Add(s);
                if (s!=null)
                {
                    string match = Regex.Match(s, "(?<=<value>)(.*)(?=</value>)").ToString();
                    Console.WriteLine(match);
                }
                else
                {
                    Console.WriteLine(TheEnd);
                }
            }

        }
    }
}
