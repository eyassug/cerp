//using System;
//using System.Collections.Generic;
//using System.Data.Entity.SqlServer;
//using System.Linq;
//using CERP.Modules.DataManagement.DataAccess;
//using CERP.Modules.DataManagement.Domain;
//namespace CERP.Modules.DataManagement.Services
//{
//    public class LocationService : ILocationService
//    {

//        #region ILocationService Implementation
//        public void AddNewLocation(Location location)
//        {
//            if (location == null)
//                throw new ArgumentNullException("location");
//            if (string.IsNullOrWhiteSpace(location.Name))
//                throw new Exception("Invalid Location name!!!");
//            location.Name = location.Name.Trim().Sanitise();
//            using (var context = new DataManagementContext())
//            {
//                if (context.Locations.Any(m => m.Name == location.Name))
//                    throw new Exception("A location with the supplied name already exists.");
//                Location newLocation = new Models.Inventory.Location
//                {
//                    Name = location.Name,
//                    LocationNode = location.LocationNode
//                };
//                context.Locations.Add(newLocation);
//                context.SaveChanges();
//            }
//        }

//        public void RemoveLocation(Location location)
//        {
//            throw new NotImplementedException();
//        }

//        public ICollection<Location> GetLocations()
//        {
//            throw new NotImplementedException();
//        }

//        public void RenameLocation(Location location, string newName)
//        {
//            throw new NotImplementedException();
//        }
//        #endregion
//    }

//}
