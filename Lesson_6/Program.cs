using System;
using System.Diagnostics;
using System.Linq;
using System.Management;

 // dividebyzeroexception - исключение, деление на 0
// argumentexception — исключение, которое возникает, когда среди передаваемых методу аргументов есть недопустимые.
// arithmeticexception — исключение, которое возникает при ошибках операций арифметического приведения или преобразования.
// accessviolationexception — исключение, которое возникает при попытке чтения или записи в защищённую область памяти.
// unauthorizedaccessexception — исключение, которое возникает в случае запрета доступа операционной системой из - за ошибки ввода-вывода или особого типа ошибки безопасности.
// indexoutofrangeexception — исключение, возникающее при попытке обращения к элементу массива с индексом, который находится за пределами массива.
// invalidcastexception — исключение, которое возникает в случае недопустимого приведения или явного преобразования.
// nullreferenceexception — исключение, которое возникает при операциях с объектом, равным null, например при попытке получить доступ к его свойствам.
// outofmemoryexception — исключение, которое возникает при недостаточном объёме памяти для продолжения выполнения программы.
// stackOverflowException — исключение, которое возникает при переполнении стека выполнения из - за чрезмерного количества вложенных вызовов методов.

//try
//{
//    Building building = new Building(3, 1);
//  //  building.Address = "Пушкина 1";
//    string address = GetAddress(building);
//    Console.WriteLine(address);
//}
//catch (AddressException ex) when (ex.Code == ErrorCodes.NoAddress)
//{
//    Console.WriteLine("Здание не содержит адреса");
//}
//catch (AddressException ex) when (ex.Code == ErrorCodes.NoBuilding)
//{
//    Console.WriteLine("Нет строения");
//}



namespace Lesson_6
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }





    }
}
