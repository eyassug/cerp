using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
