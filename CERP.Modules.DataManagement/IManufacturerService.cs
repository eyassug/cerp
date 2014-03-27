using System.Collections.Generic;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
    public interface IManufacturerService
    {
        /// <summary>
        /// Adds a new Manufacturer to the database
        /// </summary>
        /// <param name="manufacturer">The Product Category to be added</param>
        void AddNewManufacturer(Manufacturer manufacturer);
        /// <summary>
        /// Removes the Manufacturer record from the database, provided that it does not have associated Products
        /// </summary>
        /// <param name="manufacturer">Manufacturer to be removed from the database</param>
        void RemoveManufacturer(Manufacturer manufacturer);
        /// <summary>
        /// Sets the given manufacturer as inactive (It will no longer be possible to add Products under this Manufacturer)
        /// </summary>
        /// <param name="manufacturer">Manufacturer to be disabled</param>
        void DisableManufacturer(Manufacturer manufacturer);
        /// <summary>
        /// Returns all active manufacturers
        /// </summary>
        ICollection<Manufacturer> GetManufacturers();
        /// <summary>
        /// Returns all manufacturers that satisfy the given query
        /// </summary>
        /// <param name="query">Query to search Manufacturers from the database</param>
        /// <returns></returns>
        ICollection<Manufacturer> SearchManufacturers(string query);
        /// <summary>
        /// Renames the given Manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="newName"></param>
        void RenameManufacturer(Manufacturer manufacturer, string newName);

    }
}
