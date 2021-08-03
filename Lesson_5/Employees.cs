using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Employees
    {
        String FullName;
        String Phonenumber;
        String Mailbox;
        int Salary;
        int Age;

        public Employees(string _FullName, string _phonenumber, string _mailbox, int _salary,int _age)
        {
            FullName = _FullName; 
            Phonenumber = _phonenumber;
            Mailbox = _mailbox;
            Salary=_salary;
            Age=_age;
        }

        
        public void GetEmployersToConsole()
        {
            Console.WriteLine("Full name: " + FullName + " Phonenumber: " + Phonenumber + " Mailbox: " + Mailbox +
                " Salary: " + Salary.ToString() + " Age: " + Age.ToString());
        }

        
    }
}
