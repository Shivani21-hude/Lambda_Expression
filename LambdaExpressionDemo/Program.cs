using System;
namespace LambdaExpressionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
            LambdaDemo.Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
            LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
            LambdaDemo.AllPersonsAverageAge(listPersonInCity);
          

            Console.ReadKey();
        }
    }
}