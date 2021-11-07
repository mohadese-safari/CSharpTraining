using System;
using System.Collections.Generic;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = File.ReadAllText(@"U:\VLC\uninstall.log");
            ReadMethodExample();
        }

        public static void ReadMethodExample()
        {
            using (StreamReader streamReader = File.OpenText(@"U:\UniConverter\Log\DownloadRes\sniffer.log"))
            {
                List<char> list = new List<char>();
                for (int ch = streamReader.Read(); ch != -1; ch = streamReader.Read())
                {
                    list.Add((char)ch);
                }
                Console.WriteLine();   
            }
        }
    }
}
