using System;

namespace Lesson_5
{
    class Employees
    {
        String FullName;
        String Phonenumber;
        String Mailbox;
        String Position;
        int Salary;
        int Age;



        public Employees(string _FullName, string _phonenumber, string _mailbox, string _position, int _salary, int _age)
        {
            FullName = _FullName;
            Phonenumber = _phonenumber;
            Mailbox = _mailbox;
            Position = _position;
            Salary = _salary;
            Age = _age;
        }

        public int GetEmploerAge()
        {
            return this.Age;
        }
        public void GetEmployersToConsole()
        {
            Console.WriteLine("Full name: " + FullName + "Position: " + Position + " Phonenumber: " + Phonenumber + " Mailbox: " + Mailbox +
                " Salary: " + Salary.ToString() + " Age: " + Age.ToString());
        }



    }
}
