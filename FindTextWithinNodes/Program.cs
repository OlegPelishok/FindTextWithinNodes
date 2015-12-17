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
            Console.WriteLine("Enter file path/name:");
            string source;
            source = Console.ReadLine();
            Console.WriteLine("Enter sestination file path/name");
            string destination;
            destination = Console.ReadLine();
            StreamReader fs = new StreamReader(source);
            string s = string.Empty;
            string TheEnd = string.Empty;
            List<string> list = new List<string>();

            while (s != null)
            {
                s = fs.ReadLine();
                if (s!=null)
                {
                    string match = Regex.Match(s, "(?<=<value>)(.*)(?=</value>)").ToString();
                    list.Add(match);
                    Console.WriteLine(match);
                }
                else
                {
                    Console.WriteLine(TheEnd);
                }

            }

            using (StreamWriter sw = new StreamWriter(destination))
            {
                foreach (var l in list)
                {
                    sw.WriteLine(l);
                }
            }
        }
    }
}
