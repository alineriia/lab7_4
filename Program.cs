using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вирішити з використанням колекції Stack:
Дано файл, в якому записаний набір чисел. Переписати в інший файл всі числа в
зворотному порядку. */
namespace lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line, file1 = "text.txt",file2 ="text2.txt";
            Stack <int> numbers = new Stack<int>(); Console.WriteLine("READING...");
            using (StreamReader MyFile = new StreamReader(file1))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    String[] data = line.Split('\n');
                    for (int i = 0; i < data.Length; i++)
                    {
                        numbers.Push(int.Parse(data[i]));
                        Console.WriteLine(data[i]);
                    }
                      
                }
            }
            Console.WriteLine("WRITING...");
            using (StreamWriter MyFile = new StreamWriter(file2))
            {
                while (numbers.Count != 0)
                {
                    int numbers2 = numbers.Pop();
                    MyFile.Write(numbers2);
                    Console.Write(numbers2);
                }
            }
            Console.ReadKey();
        }
    }
}
