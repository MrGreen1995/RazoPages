namespace RazorPages.Models
{
    public class Employee
    {

        public int Id { get; set; }
            
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhotoPath { get; set; }

        public Departments? Department { get; set; }

    }
}
