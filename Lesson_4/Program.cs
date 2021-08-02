using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] fulNames = new string[2, 3];

            for (int i = 0; i < fulNames.Length / 3; i++)
            {
                (fulNames[i, 0], fulNames[i, 1], fulNames[i, 2]) = InputGetName();
            }

            Console.WriteLine();

            for (int i = 0; i < fulNames.Length / 3; i++)
            {
                Console.WriteLine(GetFullName(fulNames[i, 0], fulNames[i, 1], fulNames[i, 2]));
            }


            //start task 2
            Console.WriteLine("Start task #2");
            string filter_tekst = "";
            filter_tekst=Console.ReadLine();
            int space = 0; int digitels = 0;
            foreach (var item in filter_tekst)
            {
                    if(item==' ')
                    {
                    space++;
                    }
                 else  if(Char.IsDigit(item)){
                    digitels++;
                    }
            }

            Console.WriteLine("Tekst lenght is: " + filter_tekst.Length+'\n'+ " space simbols in tekst: " +  space+ '\n' +
                " Count Digit simbols in tekst is: "  + digitels + '\n' + "Tekst lenght is: "+ filter_tekst.Length + '\n');
            //end task 2

            //stat task 3
            Console.WriteLine("Start task #3");
            string Seasons_number = Console.ReadLine();
            Console.WriteLine("Session name is: "+  GetSeasonsName(Seasons_number));
            //end task 3

            //start task 4
            Console.WriteLine("start task 4:  Please enter for Fibonacci  number");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonachi(0, 1, 1, number);
            //end task 4


            //start task4
            Console.WriteLine("Start task #5");
            String str1 = " Предложение один Теперь предложение два Предложение три";
            String correctString = str1.Replace("один", "один.").Replace("два", "два.").Replace("три", "три.");
            Console.WriteLine(correctString);


        }



        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return "Firstname: " + firstName + " LastName: " + lastName + " patronymic: " + patronymic;

        }

        public static (string firstName, string lastName, string patronymic) InputGetName()
        {
            Console.WriteLine("Input FirsName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input patronymic");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }


        public static string GetSeasonsName(string id)
        {
            
            try
            {
                int reult = 0;
               // int mNum = 0;
                var isNumeric = int.TryParse(id, out  reult);
                Mounths m = (Mounths)reult;
                 if(reult<=12)
                {
                    if (reult <= 3)
                    {
                        Seasons s = (Seasons)1;
                        return s.ToString()+ " mounth: "+m.ToString();
                    }else if (reult >= 3 && reult<=6)
                    {
                        Seasons s = (Seasons)2;
                        return s.ToString() + " mounth: " + m.ToString();
                    }
                    else if (reult >= 6 && reult <= 9)
                    {
                        Seasons s = (Seasons)3;
                        return s.ToString() + " mounth: " + m.ToString();
                    }
                    else
                    {
                        Seasons s = (Seasons)4;
                        return s.ToString();
                    }



                }
                else
                {
                    Console.WriteLine("Error: Please enter a number between 1 and 12");
                }
                   
                 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Please enter a number between 1 and 12");
            }

            return null;
        }

        enum Mounths
        {            
            jenuary=1,fevral=2,mart=3,april=4,may=5,june=6,july=7,
            avgust=8,september=9,octamber=10,november=11,december=12
        }
        enum Seasons
        {
            Winter=1,
            Spring=2,
            Summer=3,
            Autumn=4
        }


        public static void Fibonachi(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonachi(b, a + b, counter + 1, number);
        }
    }


}
