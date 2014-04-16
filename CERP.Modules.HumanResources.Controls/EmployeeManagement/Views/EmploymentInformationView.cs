using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels;

namespace CERP.Modules.HumanResources.Controls.EmployeeManagement.Views
{
    public partial class EmploymentInformationView : UserControl
    {
        public EmploymentInformationView()
            : this(new EmploymentInformationViewModel())
        {
        }

        public EmploymentInformationView(EmploymentInformationViewModel employmentInformation)
        {
            InitializeComponent();
            EmploymentInformation = employmentInformation;
        }

        public EmploymentInformationViewModel EmploymentInformation
        {
            get { return employmentInfoBindingSource.DataSource as EmploymentInformationViewModel; }
            set { employmentInfoBindingSource.DataSource = value; }
        }

        public int SelectedDepartmentID
        {
            get
            {
                var departmentId = departmentLookUpEdit.EditValue ?? 1;
                return (int) departmentId;
            }
            set { departmentLookUpEdit.EditValue = value; }
        }

        public List<LookUpViewModel> Departments
        {
            get { return departmentBindingSource.DataSource as List<LookUpViewModel>; }
            set { departmentBindingSource.DataSource = value; departmentLookUpEdit.Refresh(); }
        }

        public decimal Salary
        {
            get
            {
                decimal salary = 0;
                var result = decimal.TryParse(salaryTextEdit.Text,out salary);
                return result ? salary : 0;
            }
        }

        public string JobTitle
        {
            get
            {
                var jobTitle = jobTitleTextEdit.Text;
                return jobTitle;
            }
        }

        public string EmailAddress
        {
            get { return emailAddressTextEdit.Text; }
        }

        public DateTime HireDate
        {
            get { return (hireDateDateEdit.DateTime == new DateTime()) ? DateTime.Today : hireDateDateEdit.DateTime; }
        }
    }
}
