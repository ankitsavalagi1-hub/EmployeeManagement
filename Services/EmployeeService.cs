using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    class EmployeeService
    {
        private List<Employee> employees =
            new List<Employee>();

        public void AddEmployee(
            Employee emp)
        {
            employees.Add(emp);
        }

        public List<Employee>
            GetEmployees()
        {
            return employees;
        }
    }
}