using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SSN;
            string name;
            double salary;
            int age;
            do
            {
                Console.WriteLine("pls Enter Employee SSN");
                SSN = int.Parse(Console.ReadLine());
                Console.WriteLine("pls Enter Employee Name");
                name = Console.ReadLine();
                Console.WriteLine("pls Enter Employee Salary");
                salary = double.Parse(Console.ReadLine());
                Console.WriteLine("pls Enter Employee Age");
                age = int.Parse(Console.ReadLine());
            } while (age < 0 && salary < 40000); 
        }
    }
}
