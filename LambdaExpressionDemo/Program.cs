using System;
namespace LambdaExpressionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
           
            Console.ReadKey();
        }
    }
}