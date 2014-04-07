using System;
using System.Collections.Generic;
using Apex.Common.MVVM;

namespace CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels
{
    public class PersonalInformationViewModel : ViewModelBase
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private SexOptions? _sex;
        private DateTime _dateOfBirth;
        private MaritalStatusOptions? _maritalStatus;
        private string _nationality;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (_middleName == value)
                    return;
                _middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if(_lastName == value)
                    return;
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public List<LookUpViewModel> SexOptions
        {
            get
            {
                return new List<LookUpViewModel>
                           {
                               new LookUpViewModel{DisplayMember = "Male", ValueMember = "M"},
                               new LookUpViewModel{DisplayMember = "Female", ValueMember = "F"}
                           };
            }
        }
        public SexOptions? Sex
        {
            get { return _sex; }
            set
            {
                if (_sex == value)
                    return;
                _sex = value;
                OnPropertyChanged("Sex");
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if(_dateOfBirth == value)
                    return;
                _dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        public List<LookUpViewModel> MaritalStatusList
        {
            get 
            {
                return new List<LookUpViewModel>
                           {
                               new LookUpViewModel{DisplayMember = MaritalStatusOptions.Single.ToString(), ValueMember = MaritalStatusOptions.Single},
                               new LookUpViewModel{DisplayMember = MaritalStatusOptions.Married.ToString(), ValueMember = MaritalStatusOptions.Married}
                           };
            }
        }
        public MaritalStatusOptions? MaritalStatus
        {
            get { return _maritalStatus; }
            set
            {
                _maritalStatus = value;
                OnPropertyChanged("MaritalStatus");
            }
        }

        public string Nationality
        {
            get { return _nationality; }
            set
            {
                if(_nationality == value)
                    return;
                _nationality = value;
                OnPropertyChanged("Nationality");
            }
        }

        public List<string> NationalityOptions { get; set; }
        public string Remark { get; set; }

    }

    public enum SexOptions
    {
        Male,
        Female
    }

    public enum MaritalStatusOptions
    {
        Single,
        Married
    }
}
