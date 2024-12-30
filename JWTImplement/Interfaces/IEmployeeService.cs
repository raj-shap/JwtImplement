using JWTImplement.Models;

namespace JWTImplement.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeeDetails();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);

    }
}
