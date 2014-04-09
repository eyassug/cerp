using System.Collections.Generic;
using CERP.Modules.HumanResources.Domain;

namespace CERP.Modules.HumanResources
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Returns a single Employee with the specified ID
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        Employee GetEmployee(int employeeID);
        /// <summary>
        /// Gets all current employees
        /// </summary>
        /// <returns></returns>
        ICollection<Employee> GetEmployees();
        /// <summary>
        /// Terminates the specified employee
        /// </summary>
        /// <param name="employee"></param>
        void Terminate(Employee employee);
        /// <summary>
        /// Adds the given Employee to the database
        /// </summary>
        /// <param name="employee"></param>
        void Add(Employee employee);
        /// <summary>
        /// Removes the given Employee from the database, provided that it doesn't have associated transactions
        /// </summary>
        /// <param name="employee"></param>
        void Remove(Employee employee);
        /// <summary>
        /// Transfers the employee to a new department
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="newDepartment"></param>
        void ChangeDepartment(Employee employee, Department newDepartment);
        /// <summary>
        /// Updates the employee's salary
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="newSalary"></param>
        void UpdateSalary(Employee employee, decimal newSalary);
        /// <summary>
        /// Changes Payment Frequency for the given employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="paymentFrequency"></param>
        void ChangePaymentFrequency(Employee employee, Models.HumanResources.PaymentFrequency paymentFrequency);
        /// <summary>
        /// Returns all employees in the given department
        /// </summary>
        /// <param name="department"></param>
        void GetEmployees(Department department);
    }
}
