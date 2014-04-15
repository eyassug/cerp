using System;
using System.Collections.Generic;
using Apex.Common.MVVM;

namespace CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels
{
    public class EmploymentInformationViewModel : ViewModelBase
    {
        private string _employeeNumber;
        private string _employmentType;
        private DateTime _hireDate;
        private decimal _salary;
        private string _currency;
        private string _department;
        private int _departmentID;
        private string _emailAddress;
        private string _jobTitle;

        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set
            {
                if(_employeeNumber == value)
                    return;
                _employeeNumber = value;
                OnPropertyChanged("EmployeeNumber");
            }
        }

        public List<LookUpViewModel> EmploymentTypeOptions
        {
            get
            {
                return new List<LookUpViewModel>
                           {
                               new LookUpViewModel{DisplayMember = "Local", ValueMember = "L"},
                               new LookUpViewModel{DisplayMember = "Foreign", ValueMember = "F"}
                           };
            }
        }

        public string EmploymentType
        {
            get { return _employmentType?? (_employmentType = "Local"); }
            set
            {
                if (_employmentType == value)
                    return;
                _employmentType = value;
                OnPropertyChanged("EmploymentType");
            }
        }

        public DateTime HireDate
        {
            get { return _hireDate; }
            set
            {
                if (_hireDate == value)
                    return;
                _hireDate = value;
                OnPropertyChanged("HireDate");
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (_salary == value)
                    return;
                _salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public List<LookUpViewModel> CurrencyOptions { get; set; }
        public string Currency
        {
            get { return _currency ?? (_currency = "ETB"); }
            set
            {
                if (_currency == value)
                    return;
                _currency = value;
                OnPropertyChanged("Currency");
            }
        }

        public List<LookUpViewModel> DepartmentOptions { get; set; }
        public string Department
        {
            get { return _department; }
            set
            {
                if (_department == value)
                    return;
                _department = value;
                OnPropertyChanged("Department");
            }
        }

        public int SelectedDepartmentID
        {
            get { return _departmentID; }
            set
            {
                if (_departmentID == value)
                    return;
                _departmentID = value;
                OnPropertyChanged("SelectedDepartmentID");
            }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                if (_jobTitle == value)
                    return;
                _jobTitle = value;
                OnPropertyChanged("JobTitle");
            }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress == value)
                    return;
                _emailAddress = value;
                OnPropertyChanged("EmailAddress");
            }
        }
    }
}
