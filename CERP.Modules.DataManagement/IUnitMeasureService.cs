using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
  public interface IUnitMeasureService
    {
        /// <summary>
        /// Add a new UnitMeasure  in the database
        /// </summary>
        /// <param name="unitMeasure"></param>
        void AddUnitMeasure(UnitMeasure unitMeasure);
        /// <summary>
        /// Removes the given UnitMeasure  from the database, assuming it doesn't have associated Invoices or Receipts
        /// </summary>
        /// <param name="unitMeasure"></param>
        void RemoveUnitMeasure(UnitMeasure unitMeasure);
        /// <summary>
        /// return all unitMeasure
        /// </summary>
        /// <returns>List of unitMeasures</returns>
        ICollection<UnitMeasure> GetAllUnitMeasures();
        /// <summary>
        /// Renames the given UnitMeasure
        /// </summary>
        /// <param name="unitMeasure"></param>
        /// <param name="newName"></param>
        void RenameunitMeasure(UnitMeasure unitMeasure, string newName);

        
    }
}
