using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int MyProperty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Grade> Grade { get; set; } = new List<Grade>();
    }
}
