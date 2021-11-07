using System;
using System.Collections.Generic;
using System.IO;
namespace FindFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the root directory for search:");
            string directoryPath = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            //Console.WriteLine(directoryInfo.GetFiles()[0]);
            List<string> searchResult = SearchFileInDirectory(directoryInfo, fileName);
            foreach(string str in searchResult)
            {
                Console.WriteLine(str);
            }
        }
        static List<string> SearchFileInDirectory(DirectoryInfo directoryInfo, string fileName)
        {
            List<string> res = new List<string>();

            foreach (FileInfo fi in directoryInfo.GetFiles())
            {
                if (fi.Name.Contains(fileName))
                {
                    res.Add(fi.FullName);
                }
            }

            if (directoryInfo.GetDirectories().Length != 0)
            {
                foreach (DirectoryInfo df in directoryInfo.GetDirectories())
                {
                    res.AddRange(SearchFileInDirectory(df, fileName));
                }
            }

            return res;
        }

    }
}

/*
 What made useful :

 lists
 foreach
 directory info
 recursion

 debugging :
  1. step into
  2. step over
  3. step out
  4. watch
 
 */