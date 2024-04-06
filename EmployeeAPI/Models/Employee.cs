using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public long Salary { get; set; }
        public string Location { get; set; }
    }
}
