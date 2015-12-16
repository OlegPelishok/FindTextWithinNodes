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
            List<string> list = new List<string>();
            while (s != null)
            {
                s = fs.ReadLine();
                list.Add(s);
            }
            foreach (var str in list)
            {
                if (str != null)
                {
                    string match = Regex.Match(str, "(?<=<value>)(.*)(?=</value>)").ToString();
                    Console.WriteLine(match);
                }
                else
                {
                    Console.WriteLine("The END");
                }
                
            }
        }
    }
}
