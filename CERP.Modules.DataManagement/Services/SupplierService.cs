using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement.Services
{
    public class SupplierService : ISupplierService
    {
        #region ISupplierService Implementation
        public void AddNewSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException("supplier");
            if (string.IsNullOrWhiteSpace(supplier.Name))
                throw new Exception("Invalid supplier name!!!");
            supplier.Name = supplier.Name.Trim().Sanitise();
            using (var context = new DataManagementContext())
            {
                if (context.Partners.Any(m => m.Name == supplier.Name))
                    throw new Exception("A supplier with the supplied name already exists.");
                var newSupplier = new Models.Business.Partner
                {
                    Name = supplier.Name
                };
                context.Partners.Add(newSupplier);
                context.SaveChanges();
            }
        }

        public void RemoveSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException("supplier");
            if (string.IsNullOrWhiteSpace(supplier.Name) || string.IsNullOrWhiteSpace(supplier.Name.Sanitise()))
                throw new Exception("Invalid Supplier name!!!");
            supplier.Name = supplier.Name.Trim().Sanitise();

            using (var context = new DataManagementContext())
            {
                var selectedSupplier = context.Partners.SingleOrDefault(m => m.PartnerID == supplier.SupplierID);
                if (selectedSupplier == null)
                    throw new Exception("The Supplier record was not found in the database");
                try
                {
                    context.Partners.Remove(selectedSupplier);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Could not remove the selected supplier because it has associated Products.");
                }
            }
        }

        public void DisableSupplier(Domain.Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public ICollection<Supplier> GetSuppliers()
        {
            using (var context = new DataManagementContext())
            {
                var supplier = from s in context.Partners
                                    select new Supplier()
                                    {
                                        SupplierID = s.PartnerID,
                                        Name = s.Name
                                    };
                return supplier.ToList();
            }
        }

        public ICollection<Supplier> SearchSuppliers(string query)
        {
            throw new NotImplementedException();
        }

        public void RenameSupplier(Supplier supplier, string newName)
        {
            if (supplier == null)
                throw new ArgumentNullException("supplier");
            if (string.IsNullOrWhiteSpace(supplier.Name) || string.IsNullOrWhiteSpace(supplier.Name.Sanitise().Trim()))
                throw new Exception("Invalid Supplier  name!!!");
            supplier.Name = supplier.Name.Sanitise().Trim();
            using (var context = new DataManagementContext())
            {
                var selectedSupplier =
                    context.Partners.SingleOrDefault(m => m.PartnerID == supplier.SupplierID);
                if (selectedSupplier == null)
                    throw new Exception("The Supplier record was not found in the database.");
                if (selectedSupplier.Name == newName)
                    return;
                selectedSupplier.Name = newName;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
