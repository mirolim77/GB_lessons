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
            Console.WriteLine("Input some text for text");
            File.WriteAllText("text.txt", Console.ReadLine()); // записываем в файл строку
            //end task 1

            //start task 2
            File.WriteAllText("startup.txt", DateTime.Now.ToString());
            //end task2

            //start task 3
            Console.WriteLine("Input some text for bytes.bin");
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


            //start task 4
            Employees person = new Employees("Pupkin", "8-85-885-88-89", "pupkin@mail.ru", "Developer", 1000, 44);
            person.GetEmployersToConsole();


            Employees[] persons = new Employees[8];
            persons[0] = new Employees("Pupkin", "8-85-885-88-89", "pupkin@mail.ru", "Developer", 1000, 50);
            persons[1] = new Employees("Aupkin", "8-85-885-88-89", "dutkin@mail.ru", "Developer", 1000, 18);
            persons[2] = new Employees("Bupkin", "8-85-885-88-89", "butkin@mail.ru", "Developer", 1000, 45);
            persons[3] = new Employees("Hupkin", "8-85-885-88-89", "hupkin@mail.ru", "Developer", 1000, 44);
            persons[4] = new Employees("Nupkin", "8-85-885-88-89", "nupkin@mail.ru", "Developer", 1000, 44);
            persons[5] = new Employees("Yupkin", "8-85-885-88-89", "yupkin@mail.ru", "Developer", 1000, 33);
            persons[6] = new Employees("Lupkin", "8-85-885-88-89", "lupkin@mail.ru", "Developer", 1000, 22);
            persons[7] = new Employees("Kupkin", "8-85-885-88-89", "kupkin@mail.ru", "Developer", 1000, 31);



            EmployeesArrray e = new EmployeesArrray();
            e.SortEmployersByAgeToConsole(persons, 40);
 


            
            


        }



    }
}
