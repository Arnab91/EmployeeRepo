using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _dBContext;
        public EmployeeRepository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public bool AddEntity(Employee employee)
        {
            _dBContext.Employees.Add(employee);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteEntity(int Id)
        {
            var entity = _dBContext.Employees.Find(Id);
            _dBContext.Employees.Remove(entity);
            _dBContext.SaveChanges();
            return true;
        }

        public Employee Get(int Id)
        {
            return _dBContext.Employees.Find(Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dBContext.Employees.ToList();
        }

        public bool UpdateEntity(Employee employee)
        {
            _dBContext.Employees.Update(employee);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
