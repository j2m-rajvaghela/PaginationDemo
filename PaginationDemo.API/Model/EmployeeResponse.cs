namespace PaginationDemo.API.Model
{
    public class EmployeeResponse
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
