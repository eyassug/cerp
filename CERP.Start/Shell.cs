using System.Linq;
using System.Windows.Forms;
using CERP.Modules.HumanResources.Controls.EmployeeManagement;
using DevExpress.XtraBars;

namespace CERP.Start
{
    public partial class Shell : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void BtnEmployeesClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateTab(new AddEmployeeShell());
        }

        #region Tab Manager
        private void OpenOrActivateTab<TForm>(TForm window) where TForm : Form, new()
        {
            // Check if a window is already open
            foreach (var mdiChild in MdiChildren.Where(mdiChild => mdiChild.GetType() == typeof(TForm)))
            {
                mdiChild.Activate();
                return;
            }
            window.MdiParent = this;
            window.Show();
        }

        #endregion
    }
}