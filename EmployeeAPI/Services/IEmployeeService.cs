using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        bool AddEntity(Employee employee);
        bool UpdateEntity(Employee employee);
        bool DeleteEntity(int Id);
    }
}
