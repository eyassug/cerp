using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Modules.HumanResources.DataAccess;
using CERP.Modules.HumanResources.Domain;

namespace CERP.Modules.HumanResources.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDepartmentService _departmentService;

        public EmployeeService()
        {
            _departmentService = new DepartmentService();
        }


        public Employee GetEmployee(int employeeID)
        {
            using(var context = new CERPContext())
            {
                var employee = context.ExtendedEmployees.SingleOrDefault(e => e.EmployeeID == employeeID);
                if(employee == null)
                    throw new Exception("An employee with the specified id could not be found");
                return new Employee
                {
                    EmployeeID = employee.EmployeeID,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Department = _departmentService.GetDepartment(employee.DepartmentID),
                    DateOfBirth = employee.DateOfBirth.Date,
                    Salary = employee.Rate,
                    PaymentFrequency = employee.PaymentFrequency,
                    Gender = employee.Gender,
                    EmailAddress = employee.EmailAddress,
                    MaritalStatus = employee.Status.GetValueOrDefault(),
                    JobTitle = employee.JobTitle
                };
            }
        }

        public ICollection<Employee> GetEmployees()
        {
            using(var context = new CERPContext())
            {
                var employees = from employee in context.ExtendedEmployees.Where(e => e.IsCurrent)
                                select new Employee
                                           {
                                               EmployeeID = employee.EmployeeID,
                                               FirstName = employee.FirstName,
                                               MiddleName = employee.MiddleName,
                                               LastName = employee.LastName,
                                               Department = _departmentService.GetDepartment(employee.DepartmentID),
                                               DateOfBirth = employee.DateOfBirth.Date,
                                               Salary = employee.Rate,
                                               PaymentFrequency = employee.PaymentFrequency,
                                               Gender = employee.Gender,
                                               EmailAddress = employee.EmailAddress,
                                               MaritalStatus = employee.Status.GetValueOrDefault(),
                                               JobTitle = employee.JobTitle
                                           };
                return employees.ToList();
            }
        }

        public void Terminate(Employee employee)
        {
            using (var context = new CERPContext())
            {
                var employeeToBeTerminated = context.Employees.SingleOrDefault(e => e.EmployeeID == employee.EmployeeID);
                if(employeeToBeTerminated == null)
                    throw new Exception("The specified employee record was not found.");
                if (!employeeToBeTerminated.IsCurrent)
                    throw new Exception("The specified employee has already been terminated."); 
                employeeToBeTerminated.IsCurrent = false;
                context.SaveChanges();
            }
        }

        public void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Employee employee)
        {
            throw new NotImplementedException();
        }

        public void ChangeDepartment(Domain.Employee employee, Domain.Department newDepartment)
        {
            throw new NotImplementedException();
        }

        public void UpdateSalary(Domain.Employee employee, decimal newSalary)
        {
            throw new NotImplementedException();
        }

        public void ChangePaymentFrequency(Domain.Employee employee, Models.HumanResources.PaymentFrequency paymentFrequency)
        {
            throw new NotImplementedException();
        }

        public void GetEmployees(Domain.Department department)
        {
            throw new NotImplementedException();
        }
    
}
}
