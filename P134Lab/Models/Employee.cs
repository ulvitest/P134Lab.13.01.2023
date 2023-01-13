namespace P134Lab.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
