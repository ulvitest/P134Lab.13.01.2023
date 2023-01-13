using System.Collections.Generic;

namespace P134Lab.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
