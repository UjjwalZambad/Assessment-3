using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId   { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }
}
