using EmployeeAPI.Models;

namespace EmployeeAPI.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        bool AddEntity(Employee employee);
        bool UpdateEntity(Employee employee);
        bool DeleteEntity(int Id);
    }
}
