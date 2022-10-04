using TestApi.Models;

namespace TestApi.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        void CreateEmployee(Employee employee);
        Employee GetById(int id);
        Employee DeleteEmployee(int id);
        Employee UpdateEmployee(Employee employee);

    }
}
