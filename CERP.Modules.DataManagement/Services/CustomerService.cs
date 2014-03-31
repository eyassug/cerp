using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement.Services
{
       public class CustomerServices : ICustomerService
       {
           private const string CustomerPartnerType = "C";
           
        #region CustomerServices Implementation
        public void AddNewCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("customer");
            if (string.IsNullOrWhiteSpace(customer.Name))
                throw new Exception("Invalid customer name!!!");
            customer.Name = customer.Name.Trim().Sanitise();
            using (var context = new DataManagementContext())
            {
                if (context.Partners.Any(m => m.Name == customer.Name))
                    throw new Exception("A customer with the supplied name already exists.");
                var newCustomer = new Models.Business.Partner
                {
                    Name = customer.Name
                };
                var partnerType = new Models.Business.PartnerType
                                      {
                                          PartnerTypeCode = CustomerPartnerType,
                                          Partner = newCustomer
                                      };
                context.Partners.Add(newCustomer);
                context.PartnerTypes.Add(partnerType);
                context.SaveChanges();
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("customer");
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Name.Sanitise()))
                throw new Exception("Invalid Customer name!!!");
            customer.Name = customer.Name.Trim().Sanitise();

            using (var context = new DataManagementContext())
            {
                var selectedCustomer = context.Partners.SingleOrDefault(m => m.PartnerID == customer.CustomerID);
                if (selectedCustomer == null)
                    throw new Exception("The Customer record was not found in the database");
                try
                {
                    context.Partners.Remove(selectedCustomer);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Could not remove the selected customer because it has associated Products.");
                }
            }
        }

        public void DisableCustomer(Domain.Customer customer)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetCustomers()
        {
            using (var context = new DataManagementContext())
            {
                var customer = from s in context.Partners
                               select new Customer()
                               {
                                   CustomerID = s.PartnerID,
                                   Name = s.Name
                               };
                return customer.ToList();
            }
        }

        public ICollection<Customer> SearchCustomers(string query)
        {
            throw new NotImplementedException();
        }

        public void RenameCustomer(Customer customer, string newName)
        {
            if (customer == null)
                throw new ArgumentNullException("customer");
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Name.Sanitise().Trim()))
                throw new Exception("Invalid Customer  name!!!");
            customer.Name = customer.Name.Sanitise().Trim();
            using (var context = new DataManagementContext())
            {
                var selectedCustomer =
                    context.Partners.SingleOrDefault(m => m.PartnerID == customer.CustomerID);
                if (selectedCustomer == null)
                    throw new Exception("The Customer record was not found in the database.");
                if (selectedCustomer.Name == newName)
                    return;
                selectedCustomer.Name = newName;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
