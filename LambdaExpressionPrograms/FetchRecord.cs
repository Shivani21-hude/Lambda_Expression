using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionPrograms
{
    public class FetchRecord
    {

        public static void AgeBetweentwelveToEighteen(List<Student> student)
        {
            Console.WriteLine(" ==> Age betwwen 12 to 18 by linq");
            var ageCase = from s in student where s.Age >= 12 && s.Age <= 18 select s;
          
            foreach(Student s in ageCase)
            {
                Console.WriteLine(s);
            }
           
           
        }
        public static void SortTotalmarksInDescendingOrder(List<Student> student)
        {
            Console.WriteLine("==> Sort total marks in descending order ");
            var rev =student.OrderByDescending(s=>s.Age);
            foreach(Student s in rev)
            {
                Console.WriteLine(s);
            }
        }
        public static void DisplayFrequencyOfEachAddress(List<Student> student)
        {

            Console.WriteLine("==> Display frequency of each address");
            var res = student.GroupBy(x => x.Address);
            foreach(var r in res)
            {
                Console.WriteLine("Key : "+r.Key);
                List<Student> students = r.ToList();
                foreach(Student s in students)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void DisplayStudentAddress(List<Student> student)
        {
            Console.WriteLine(" ==> Display student address");
            student.ForEach(x => Console.WriteLine(x.Address));
        }

        public static void FetchFirstThreeRecord(List<Student> student)
        {
            Console.WriteLine("==> Fetch first three records ");

           List<Student> students=student.Take(3).ToList();
            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }
        }
        public static void SearchParticularStudent(List<Student> student)
        {
            Console.WriteLine("==> Check particular person is exists or not");
            List<Student> search = student.ToList();
            if(student.Exists(x=> x.Name == "Vrutik"))
            {
                Console.WriteLine("Person is exist");
            }
        }

    }
}
