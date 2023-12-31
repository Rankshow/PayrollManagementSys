namespace PayrollManagementSys.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Salary>? Salaries { get; set;}
    }
}