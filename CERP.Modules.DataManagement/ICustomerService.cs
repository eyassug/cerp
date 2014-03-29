using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
    public interface ICustomerService
    {
        /// <summary>
        /// Adds a new Customer to the database
        /// </summary>
        /// <param name="customer">The Product Category to be added</param>
        void AddNewCustomer(Customer customer);
        /// <summary>
        /// Removes the Customer record from the database, provided that it does not have associated Products
        /// </summary>
        /// <param name="customer">Customer to be removed from the database</param>
        void RemoveCustomer(Customer customer);
        /// <summary>
        /// Sets the given customer as inactive (It will no longer be possible to add Products under this Customer)
        /// </summary>
        /// <param name="customer">Customer to be disabled</param>
        void DisableCustomer(Customer customer);
        /// <summary>
        /// Returns all active customers
        /// </summary>
        ICollection<Customer> GetCustomers();
        /// <summary>
        /// Returns all customers that satisfy the given query
        /// </summary>
        /// <param name="query">Query to search Customers from the database</param>
        /// <returns></returns>
        ICollection<Customer> SearchCustomers(string query);
        /// <summary>
        /// Renames the given Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="newName"></param>
        void RenameCustomer(Customer customer, string newName);
    }
}
