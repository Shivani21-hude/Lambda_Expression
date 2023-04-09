using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressionPrograms
{
    public class Program
    {
       public static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student(){Id=1,Name="Shivani",PhoneNumber=9846271444,Address="Pune",Age=12,TotalMarks=95},
                new Student(){Id=2,Name="Monali", PhoneNumber=8345216746,Address="Mumbai",Age=22,TotalMarks=90},
                new Student(){Id=3,Name="Bhavesh",PhoneNumber=7846256314,Address="Nagpur",Age=17,TotalMarks=82},
                new Student(){Id=4,Name="Vrutik",PhoneNumber=8437210682,Address="Pune",Age=15,TotalMarks=89},
                new Student(){Id=5,Name="Shital",PhoneNumber=9875625641,Address="Hyderabad",Age=25,TotalMarks=85},
            };
           
            student.ForEach(x => Console.WriteLine(x.Id + ", " + x.Name + ", " + x.PhoneNumber + ", " + x.Address + ", " + x.Age));
            Console.WriteLine("------------------------------------");
            FetchRecord.AgeBetweentwelveToEighteen(student);
            Console.WriteLine("------------------------------------");
            FetchRecord.DisplayFrequencyOfEachAddress(student);
            Console.WriteLine("-------------------------------------");
            FetchRecord.SortTotalmarksInDescendingOrder(student);
            Console.WriteLine("--------------------------------------");
            DisplayDetails(student);
            Console.WriteLine("---------------------------------------");
            FetchRecord.DisplayStudentAddress(student);
            Console.WriteLine("----------------------------------------");
            FetchRecord.SearchParticularStudent(student);
            Console.WriteLine("--------------------------------------");
            FetchRecord.FetchFirstThreeRecord(student);
        }
        public static void DisplayDetails(List<Student> student)
        {
            Console.WriteLine("==> Display list of students");
            foreach(Student list in student)
            {
                Console.WriteLine(list);
            }
        }
       

       
    }


}