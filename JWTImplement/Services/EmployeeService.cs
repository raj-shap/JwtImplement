using JWTImplement.Context;
using JWTImplement.Interfaces;
using JWTImplement.Models;

namespace JWTImplement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _jwtContext;
        public EmployeeService(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }

        ////////////////////////// : Add Employee : //////////////////////////
        public Employee AddEmployee(Employee employee)
        {
            var AddedEmployee = _jwtContext.employees.Add(employee);
            _jwtContext.SaveChanges();
            return AddedEmployee.Entity;
        }


        ////////////////////////// : Delete Employee : //////////////////////////
        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = _jwtContext.employees.Select(e => e.Id == id);
                if (emp == null)
                {
                    throw new Exception("user not found");
                }
                else
                {
                    _jwtContext.Remove(emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        ////////////////////////// : Get Employee by Id: //////////////////////////
        public Employee GetEmployeeById(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Please enter a vlid id");
            }
            else
            {
                var employee = _jwtContext.employees.SingleOrDefault(e => e.Id == id);
                if (employee == null)
                {
                    throw new Exception($"Employee with ID {id} Not Found");
                }
                else
                {
                    return employee;
                }
            }
        }

        
        ////////////////////////// : Get All Employees : //////////////////////////
        public List<Employee> GetEmployeeDetails()
        {
            var employees = _jwtContext.employees.ToList();
            return employees;
        }

        ////////////////////////// : Update Employees : //////////////////////////
        public Employee UpdateEmployee(Employee employee)
        {
            var updated = _jwtContext.employees.Update(employee);
            _jwtContext.SaveChanges();
            return updated.Entity;
        }
    }
}
