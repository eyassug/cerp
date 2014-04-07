using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;



namespace CERP.Modules.DataManagement.Services
{
    class UnitMeasuresService : IUnitMeasureService
    {
        #region IUnitMeasureService Implementation
       
     public void AddUnitMeasure(UnitMeasure unitMeasure)
        {
            if (unitMeasure == null)
                throw new ArgumentNullException("unitMeasure");
            if (string.IsNullOrWhiteSpace(unitMeasure.Name))
                throw new Exception("Invalid UnitMeasure name!!!");
            unitMeasure.Name = unitMeasure.Name.Trim().Sanitise();
            using (var context = new DataManagementContext())
            {
                if (context.UnitMeasures.Any(m => m.Name == unitMeasure.Name))
                    throw new Exception("A unitMeasure with the supplied name already exists.");
                var newUnitMeasures = new Models.Inventory.UnitMeasure
                {
                    UnitMeasureCode = unitMeasure.UnitMeasureCode,
                    Name = unitMeasure.Name
                };
                context.UnitMeasures.Add(newUnitMeasures);
                context.SaveChanges();
            }
        }

        public void RemoveUnitMeasure(UnitMeasure unitMeasure)
        {
            if (unitMeasure == null)
                throw new ArgumentNullException("unitMeasure");
            if (string.IsNullOrWhiteSpace(unitMeasure.Name) || string.IsNullOrWhiteSpace(unitMeasure.Name.Sanitise()))
                throw new Exception("Invalid unitMeasure name!!!");
            unitMeasure.Name = unitMeasure.Name.Trim().Sanitise();

            using (var context = new DataManagementContext())
            {
                var selectedUnitMeasure = context.UnitMeasures.SingleOrDefault(u => u.UnitMeasureCode == unitMeasure.UnitMeasureCode);
                if (selectedUnitMeasure == null)
                    throw new Exception("The UnitMeasure record was not found in the database");
                try
                {
                    context.UnitMeasures.Remove(selectedUnitMeasure);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Could not remove the selected unitMeasure because it has associated Products.");
                }
            }
        }

        ICollection<UnitMeasure> IUnitMeasureService.GetAllUnitMeasures()
        {
            using (var context = new DataManagementContext())
            {
                var unitMeasure = from u in context.UnitMeasures
                                    select new UnitMeasure
                                    {
                                       UnitMeasureCode= u.UnitMeasureCode,
                                        Name = u.Name
                                    };
                return unitMeasure.ToList();
            }
        }

        public void RenameunitMeasure(UnitMeasure unitMeasure, string newName)
        {
            if (unitMeasure == null)
                throw new ArgumentNullException("unitMeasure");
            if (string.IsNullOrWhiteSpace(unitMeasure.Name) || string.IsNullOrWhiteSpace(unitMeasure.Name.Sanitise().Trim()))
                throw new Exception("Invalid UnitMeasure name!!!");
            unitMeasure.Name = unitMeasure.Name.Sanitise().Trim();
            using (var context = new DataManagementContext())
            {
                var selectedUnitMeasures =
                    context.UnitMeasures.SingleOrDefault(u => u.UnitMeasureCode == unitMeasure.UnitMeasureCode);
                if (selectedUnitMeasures == null)
                    throw new Exception("The UnitMeasure record was not found in the database.");
                if (selectedUnitMeasures.Name == newName)
                    return;
                selectedUnitMeasures.Name = newName;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
