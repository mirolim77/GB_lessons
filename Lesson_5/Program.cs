using System;
using System.IO;
using System.Linq;

namespace Lesson_5
{
    class Program
    {
       




        static void Main(string[] args)
        {
           
            //start task 1            
            File.WriteAllText("text.txt", Console.ReadLine()); // записываем в файл строку
            //end task 1

            //start task 2
            File.WriteAllText("startup.txt", DateTime.Now.ToString());
            //end task2

            //start task 3
            string input_binary=Console.ReadLine();
            byte[] binary_array = new byte[input_binary.Length];

            byte[] array = { 1, 2, 3, 5, 7, 9, 11 };
            foreach (var item in input_binary)
            {
                if(Char.IsDigit(item))
                {
                    binary_array.Append(Convert.ToByte(item));
                }
            }
            File.WriteAllBytes("bytes.bin", binary_array);
           //end task 3


 

        }
        

       
    }
}
