using System;
using System.Windows.Forms;
using CERP.Models.HumanResources;
using CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels;
using CERP.Modules.HumanResources.Services;
using DevExpress.XtraEditors;
using Employee = CERP.Modules.HumanResources.Domain.Employee;

namespace CERP.Modules.HumanResources.Controls.EmployeeManagement
{
    public partial class AddEmployeeShell : Form
    {
        private readonly IEmployeeService _employeeService;
        public AddEmployeeShell()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        void Save()
        {
            var personalInformation = employeePersonalInformationView.PersonalInformation;
            var employmentInformation = employmentInformationView.EmploymentInformation;
            _employeeService.Add(new Employee
                                     {
                                         FirstName = personalInformation.FirstName,
                                         LastName = personalInformation.LastName,
                                         MiddleName = personalInformation.MiddleName,
                                         DateOfBirth = personalInformation.DateOfBirth,
                                         Gender = (personalInformation.Sex == SexOptions.Male ? Gender.Male : Gender.Female),
                                         MaritalStatus = MaritalStatus.Single,
                                         Salary = employmentInformation.Salary
                                     });
        }

        private void BtnSaveEmployeeClick(object sender, EventArgs e)
        {
            try
            {
                Save();
                XtraMessageBox.Show("Employee successfully added!");
                Close();
            }
            catch (Exception ex)
            {
                var message = string.Format("Couldn't save employee record. Error:{0}",ex.Message);
                XtraMessageBox.Show(message);
            }
           
        }
    }
}
