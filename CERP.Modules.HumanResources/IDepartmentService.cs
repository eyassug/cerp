using System.Collections.Generic;
using CERP.Modules.HumanResources.Domain;

namespace CERP.Modules.HumanResources
{
    interface IDepartmentService
    {
        void Add(string departmentName, string departmentCode);
        Department GetDepartment(int departmentID);
        ICollection<Department> GetDepartments();
    }
}
