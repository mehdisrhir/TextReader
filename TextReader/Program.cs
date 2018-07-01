using System;
using System.IO;

namespace TextReader
{
    class Program
    {
        public static void read(string path)
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            read(@"c:\data.txt");
            Console.ReadLine();
        }
    }
}
