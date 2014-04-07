using System.Windows.Forms;
using CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels;

namespace CERP.Modules.HumanResources.Controls.EmployeeManagement.Views
{
    public partial class EmployeePersonalInformationView : UserControl
    {
        public EmployeePersonalInformationView()
            : this(new PersonalInformationViewModel())
        {
        }

        public EmployeePersonalInformationView(PersonalInformationViewModel personalInformation)
        {
            InitializeComponent();
            PersonalInformation = personalInformation;
        }

        public PersonalInformationViewModel PersonalInformation
        {
            get { return personalInfoBindingSource.DataSource as PersonalInformationViewModel; }
            set { personalInfoBindingSource.DataSource = value; }
        }
    }
    
}
