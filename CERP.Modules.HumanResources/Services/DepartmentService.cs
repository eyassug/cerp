using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Models.HumanResources;
using CERP.Modules.HumanResources.DataAccess;

namespace CERP.Modules.HumanResources.Services
{
    public class DepartmentService : IDepartmentService
    {

        public void Add(string departmentName, string departmentCode)
        {
            using (var context = new CERPContext())
            {
                if(string.IsNullOrWhiteSpace(departmentName))
                    throw new ArgumentException("Invalid department name");
                if(string.IsNullOrWhiteSpace(departmentCode))
                    throw new ArgumentException("Invalid department code");

                if(context.Departments.Any(d => d.Name == departmentName.Trim()))
                    throw new Exception("A department with the specified name already exists");
                context.Departments.Add(new Department
                                            {
                                                Name = departmentName.Trim(),
                                                DepartmentCode = departmentCode.Trim()
                                            });
                context.SaveChanges();
            }
        }

        public Domain.Department GetDepartment(int departmentID)
        {
            using (var context = new CERPContext())
            {
                var department = context.Departments.SingleOrDefault(d => d.DepartmentID == departmentID);
                if(department == null)
                    throw new Exception("A department with the specified id was not found.");
                return new Domain.Department()
                           {
                               DepartmentID = departmentID,
                               Name = department.Name
                           };
            }
        }

        public ICollection<Domain.Department> GetDepartments()
        {
            using (var context = new CERPContext())
            {
                return (from d in context.Departments
                select new Domain.Department()
                {
                    DepartmentID = d.DepartmentID,
                    Name = d.Name
                }).ToList();
            }
        }
    }
}
