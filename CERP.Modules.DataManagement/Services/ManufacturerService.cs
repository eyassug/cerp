using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement.Services
{
    public class ManufacturerService : IManufacturerService
    {

        #region IManufacturerService Implementation

        public void AddNewManufacturer(Manufacturer manufacturer)
        {
            if(manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            if(string.IsNullOrWhiteSpace(manufacturer.Name))
                throw new Exception("Invalid Manufacturer name!!!");
            manufacturer.Name = manufacturer.Name.Trim().Sanitise();
            using (var context = new DataManagementContext())
            {
                if(context.Manufacturers.Any(m => m.Name == manufacturer.Name))
                    throw new Exception("A manufacturer with the supplied name already exists.");
                var newManufacturer = new Models.Business.Manufacturer
                                          {
                                              Name = manufacturer.Name
                                          };
                context.Manufacturers.Add(newManufacturer);
                context.SaveChanges();
            }
        }

        public void RemoveManufacturer(Manufacturer manufacturer)
        {
            if(manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            if(string.IsNullOrWhiteSpace(manufacturer.Name) || string.IsNullOrWhiteSpace(manufacturer.Name.Sanitise()))
                throw new Exception("Invalid Manufacturer name!!!");
            manufacturer.Name = manufacturer.Name.Trim().Sanitise();
            
            using (var context = new DataManagementContext())
            {
                var selectedManufacturer = context.Manufacturers.SingleOrDefault(m => m.ManufacturerID == manufacturer.ManufacturerID);
                if(selectedManufacturer == null)
                    throw new Exception("The Manufacturer record was not found in the database");
                try
                {
                    context.Manufacturers.Remove(selectedManufacturer);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Could not remove the selected manufacturer because it has associated Products.");
                }
            }
        }

        public void DisableManufacturer(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public ICollection<Manufacturer> GetManufacturers()
        {
            using (var context = new DataManagementContext())
            {
                var manufacturers = from m in context.Manufacturers
                                    select new Manufacturer
                                               {
                                                   ManufacturerID = m.ManufacturerID,
                                                   Name = m.Name
                                               };
                return manufacturers.ToList();
            }
        }

        public ICollection<Manufacturer> SearchManufacturers(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetManufacturers();
            var searchQuery = string.Format("%{0}%",query.Sanitise().Trim().ToLower());
            using (var context = new DataManagementContext())
            {
                var searchResults = from m in context.Manufacturers
                                    where SqlFunctions.PatIndex(searchQuery, m.Name) > 0
                                    select new Manufacturer
                                               {
                                                   ManufacturerID = m.ManufacturerID,
                                                   Name = m.Name
                                               };
                return searchResults.ToList();
            }
        }

        public void RenameManufacturer(Manufacturer manufacturer, string newName)
        {
            if (manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            if (string.IsNullOrWhiteSpace(manufacturer.Name) || string.IsNullOrWhiteSpace(manufacturer.Name.Sanitise().Trim()))
                throw new Exception("Invalid Manufacturer name!!!");
            manufacturer.Name = manufacturer.Name.Sanitise().Trim();
            using (var context = new DataManagementContext())
            {
                var selectedManufacturer =
                    context.Manufacturers.SingleOrDefault(m => m.ManufacturerID == manufacturer.ManufacturerID);
                if(selectedManufacturer == null)
                    throw new Exception("The Manufacturer record was not found in the database.");
                if (selectedManufacturer.Name == manufacturer.Name)
                    return;
                selectedManufacturer.Name = manufacturer.Name;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
