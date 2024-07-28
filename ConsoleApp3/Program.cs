using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter student Deptname ");
            string dept_name = Console.ReadLine();
            Console.WriteLine("pls enter student Name ");
            string name = Console.ReadLine();
            Console.WriteLine("pls enter student id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pls enter student age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"student_Deptname : {dept_name} , his name : {name} , his id  {id} and his age {age} ");

        }
    }
}
