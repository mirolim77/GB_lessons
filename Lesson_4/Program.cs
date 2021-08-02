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


            //star task 2
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

            Console.WriteLine("Tekst lenght is: " + filter_tekst.Length+ "\n  space simbols in tekst: "+ space+ 
                " Count Digit simbols in tekst is: " + digitels);
            //end task 2

            //stat task 3
            string Seasons_number = Console.ReadLine();
            Console.WriteLine("Session name is: "+  GetSeasonsName(Seasons_number));
            //end task 3


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
                var isNumeric = int.TryParse(id, out  reult);               
                    Seasons s = (Seasons)reult;
                    return s.ToString();
                 
            }
            catch (Exception e)
            {
                Console.WriteLine("Input symbol is not digitel!");
            }

            return null;
        }
        enum Seasons
        {
            Winter=1,
            Spring=2,
            Summer=3,
            Autumn=4
        }

    }


}
