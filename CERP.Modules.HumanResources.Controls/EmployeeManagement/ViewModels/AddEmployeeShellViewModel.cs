namespace CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels
{
    public class AddEmployeeViewModel
    {
        private PersonalInformationViewModel _personalInformation;
        private EmploymentInformationViewModel _employmentInformation;

        public PersonalInformationViewModel PersonalInformation
        {
            get { return _personalInformation ?? (_personalInformation = new PersonalInformationViewModel()); }
            set { _personalInformation = value; }
        }

        public EmploymentInformationViewModel EmploymentInformation
        {
            get { return _employmentInformation ?? (_employmentInformation = new EmploymentInformationViewModel()); }
            set { _employmentInformation = value; }
        }
    }
}
