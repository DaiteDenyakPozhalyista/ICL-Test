using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace _3._1._3
{
    class Program
    {
        static void GetFilesAndFolders(string path)
        {
            try
            {
                var files = Directory.EnumerateFiles(path);
                var folders = Directory.EnumerateDirectories(path);
                foreach (string folder in folders)
                {
                    Console.WriteLine(string.Format("folder: {0}", folder));
                    foreach (string file in files)
                    {
                        Console.WriteLine(string.Format("\t file: {0}", file));
                    }
                    GetFilesAndFolders(folder);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            GetFilesAndFolders(@"C:\Users\gogle\OneDrive\Рабочий стол\ICL\C#\1");
            Console.ReadKey();
        }
    }
}
