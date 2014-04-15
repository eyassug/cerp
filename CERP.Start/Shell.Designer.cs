namespace CERP.Start
{
    partial class Shell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEmployees = new DevExpress.XtraBars.BarButtonItem();
            this.newPayrollTerm = new DevExpress.XtraBars.BarButtonItem();
            this.hrPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.employeesPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.payrollPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEmployees,
            this.newPayrollTerm});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.hrPage});
            this.ribbon.Size = new System.Drawing.Size(442, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Caption = "Employees";
            this.btnEmployees.Id = 1;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEmployeesClick);
            // 
            // newPayrollTerm
            // 
            this.newPayrollTerm.Caption = "New Payroll";
            this.newPayrollTerm.Id = 2;
            this.newPayrollTerm.Name = "newPayrollTerm";
            this.newPayrollTerm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewPayrollTermItemClick);
            // 
            // hrPage
            // 
            this.hrPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.employeesPageGroup,
            this.payrollPageGroup});
            this.hrPage.Name = "hrPage";
            this.hrPage.Text = "Human Resources";
            // 
            // employeesPageGroup
            // 
            this.employeesPageGroup.ItemLinks.Add(this.btnEmployees);
            this.employeesPageGroup.Name = "employeesPageGroup";
            this.employeesPageGroup.Text = "Employees";
            // 
            // payrollPageGroup
            // 
            this.payrollPageGroup.ItemLinks.Add(this.newPayrollTerm);
            this.payrollPageGroup.Name = "payrollPageGroup";
            this.payrollPageGroup.Text = "Payroll";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // tabManager
            // 
            this.tabManager.MdiParent = this;
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Shell";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Shell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage hrPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup employeesPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnEmployees;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup payrollPageGroup;
        private DevExpress.XtraBars.BarButtonItem newPayrollTerm;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
    }
}