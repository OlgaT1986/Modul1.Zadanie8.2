using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul1.Zadanie8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string path = "E:/!!! ОБУЧЕНИЕ 2021/Project/Lab8/Lab8.2/Кзадаче8.txt";  
                using (StreamWriter sw = new StreamWriter(path, false)) 
                {
                    int[] array = new int[10];
                    Random random = new Random();

                    for (int i = 1; i < 10; i++)
                    {
                        array[i] = random.Next(0, 10);       
                        sw.WriteLine(array[i]);
                        Console.Write("{0}; ", array[i]);
                    }
                }
                int sum = 0;
                string[] lines = File.ReadAllLines(path);    
                foreach (string s in lines)    

                {
                    sum += Convert.ToInt32(s);  
                }
                Console.WriteLine();
                Console.WriteLine("Сумма = {0}", sum);
                Console.ReadKey();

            }
        }
    }
}

