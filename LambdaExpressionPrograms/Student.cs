using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionPrograms
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

       public int TotalMarks { get; set; }
        public override string ToString()
        {
           
            return $"Id:{Id} Name:{Name} PhoneNumber:{PhoneNumber} Address:{Address} Age:{Age} TotalMarks:{TotalMarks}";
        }
    }
}
