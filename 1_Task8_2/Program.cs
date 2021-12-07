using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/dowsr/Desktop/Dima/ITMO/1/Task8/1_Task8_2/1_Task8_2/bin/Debug/Blocknot.txt";
            if (!Directory.Exists(path))
            {
                StreamWriter sw = new StreamWriter(path);
                Random chisla10 = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.Write("{0} ", chisla10.Next(-10, 10));
                }
                sw.Close();

                using (StreamReader sr = new StreamReader("C:/Users/dowsr/Desktop/Dima/ITMO/1/Task8/1_Task8_2/1_Task8_2/bin/Debug/Blocknot.txt"))
                {
                    string s = sr.ReadToEnd().Trim();
                    string[] sArray = s.Split();
                    int sum = 0;
                    sr.Close();

                    foreach (string kusochek in sArray)
                    {
                        sum += Int32.Parse(kusochek);
                    }


                    Console.WriteLine(s);
                    Console.WriteLine(sum);
                }
                Console.ReadKey();
            }
            
        }
    }
}
