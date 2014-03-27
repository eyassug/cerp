using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
    public interface ISupplierService
    {
        /// <summary>
        /// Adds a new Supplier to the database
        /// </summary>
        /// <param name="supplier">The Product Category to be added</param>
        void AddNewSupplier(Supplier supplier);
        /// <summary>
        /// Removes the Supplier record from the database, provided that it does not have associated Products
        /// </summary>
        /// <param name="supplier">Supplier to be removed from the database</param>
        void RemoveSupplier(Supplier supplier);
        /// <summary>
        /// Sets the given supplier as inactive (It will no longer be possible to add Products under this Supplier)
        /// </summary>
        /// <param name="supplier">Supplier to be disabled</param>
        void DisableSupplier(Supplier supplier);
        /// <summary>
        /// Returns all active suppliers
        /// </summary>
        ICollection<Supplier> GetSuppliers();
        /// <summary>
        /// Returns all suppliers that satisfy the given query
        /// </summary>
        /// <param name="query">Query to search Suppliers from the database</param>
        /// <returns></returns>
        ICollection<Supplier> SearchSuppliers(string query);
        /// <summary>
        /// Renames the given Supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <param name="newName"></param>
        void RenameSupplier(Supplier supplier, string newName);
    }
}
