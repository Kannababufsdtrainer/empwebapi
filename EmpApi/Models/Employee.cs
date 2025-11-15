using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpApi.Models
{
    [Table("emp")]
    public class Employee
    {
        [Key]
        public int Eno { get; set; }
        public string? Ename { get; set; }
        public double Salary { get; set; }
    }
}
