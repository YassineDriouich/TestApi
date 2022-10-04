using TestApi.Models;

namespace TestApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly CompanyDbContext _companyDbContext;
        public EmployeeService(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }
        public void CreateEmployee(Employee employee)
        {
            _companyDbContext.employees.Add(employee);
            _companyDbContext.SaveChanges();
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _companyDbContext.employees.Find(id);
            if (employee != null)
            {
                _companyDbContext.employees.Remove(employee);
                _companyDbContext.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
