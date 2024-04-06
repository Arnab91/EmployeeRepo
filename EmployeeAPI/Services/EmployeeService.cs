using EmployeeAPI.Models;
using EmployeeAPI.Repositories;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public bool AddEntity(Employee employee)
        {
            return _repository.AddEntity(employee);
        }

        public bool DeleteEntity(int Id)
        {
            return _repository.DeleteEntity(Id);
        }

        public Employee Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public bool UpdateEntity(Employee employee)
        {
            return _repository.UpdateEntity(employee);
        }
    }
}
