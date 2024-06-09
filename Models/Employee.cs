namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public string Email { get; set; }
        public string Department { get; set; }
       // public int Phonenumber { get; set; }

    }
}
