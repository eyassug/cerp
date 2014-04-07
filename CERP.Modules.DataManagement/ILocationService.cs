using System.Collections.Generic;
using CERP.Modules.DataManagement.Domain;
namespace CERP.Modules.DataManagement
{
    interface ILocationService
    {
        /// <summary>
        /// Adds a new Location to the database
        /// </summary>
        /// <param name="location">The Product Category to be added</param>
        void AddNewLocation(Location location);
        /// <summary>
        /// Removes the Location record from the database, provided that it does not have associated Products
        /// </summary>
        /// <param name="location">Location to be removed from the database</param>
        void RemoveLocation(Location location);
        /// <summary>
        /// Returns all Locations
        /// </summary>
        ICollection<Location> GetLocations();
        /// <summary>
        /// Renames the given Location
        /// </summary>
        /// <param name="location"></param>
        /// <param name="newName"></param>
        void RenameLocation(Location location, string newName);
    }
}
