using System;
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

        public EmploymentInformationViewModel EmploymentInformation { get; set; }

        //public event EventArgs AddDepartmentButtonClicked;
    }
}
