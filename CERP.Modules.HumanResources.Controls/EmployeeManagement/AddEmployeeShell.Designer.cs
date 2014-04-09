namespace CERP.Modules.HumanResources.Controls.EmployeeManagement
{
    partial class AddEmployeeShell
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
            CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.EmploymentInformationViewModel employmentInformationViewModel1 = new CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.EmploymentInformationViewModel();
            CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.PersonalInformationViewModel personalInformationViewModel1 = new CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.PersonalInformationViewModel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.employeeDetailView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmployeeDetailView();
            this.employmentInformationView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmploymentInformationView();
            this.employeePersonalInformationView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmployeePersonalInformationView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.employeeDetailView);
            this.layoutControl1.Controls.Add(this.employmentInformationView);
            this.layoutControl1.Controls.Add(this.employeePersonalInformationView);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(987, 507);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(987, 507);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 196);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(967, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // employeeDetailView
            // 
            this.employeeDetailView.Enabled = false;
            this.employeeDetailView.Location = new System.Drawing.Point(12, 218);
            this.employeeDetailView.Name = "employeeDetailView";
            this.employeeDetailView.Size = new System.Drawing.Size(963, 277);
            this.employeeDetailView.TabIndex = 6;
            // 
            // employmentInformationView
            // 
            employmentInformationViewModel1.Currency = "ETB";
            employmentInformationViewModel1.CurrencyOptions = null;
            employmentInformationViewModel1.Department = null;
            employmentInformationViewModel1.DepartmentOptions = null;
            employmentInformationViewModel1.EmployeeNumber = null;
            employmentInformationViewModel1.EmploymentType = "Local";
            employmentInformationViewModel1.HireDate = new System.DateTime(((long)(0)));
            employmentInformationViewModel1.Salary = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.employmentInformationView.EmploymentInformation = employmentInformationViewModel1;
            this.employmentInformationView.Location = new System.Drawing.Point(672, 12);
            this.employmentInformationView.Name = "employmentInformationView";
            this.employmentInformationView.Size = new System.Drawing.Size(303, 192);
            this.employmentInformationView.TabIndex = 5;
            // 
            // employeePersonalInformationView
            // 
            this.employeePersonalInformationView.Location = new System.Drawing.Point(12, 12);
            this.employeePersonalInformationView.Name = "employeePersonalInformationView";
            personalInformationViewModel1.DateOfBirth = new System.DateTime(((long)(0)));
            personalInformationViewModel1.FirstName = null;
            personalInformationViewModel1.LastName = null;
            personalInformationViewModel1.MaritalStatus = null;
            personalInformationViewModel1.MiddleName = null;
            personalInformationViewModel1.Nationality = null;
            personalInformationViewModel1.NationalityOptions = null;
            personalInformationViewModel1.Remark = null;
            personalInformationViewModel1.Sex = null;
            this.employeePersonalInformationView.PersonalInformation = personalInformationViewModel1;
            this.employeePersonalInformationView.Size = new System.Drawing.Size(656, 192);
            this.employeePersonalInformationView.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.employeePersonalInformationView;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(660, 196);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(660, 196);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(660, 196);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.employmentInformationView;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(660, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(307, 196);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.employeeDetailView;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 206);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(967, 281);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // AddEmployeeShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 507);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddEmployeeShell";
            this.Text = "New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private Views.EmployeePersonalInformationView employeePersonalInformationView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Views.EmployeeDetailView employeeDetailView;
        private Views.EmploymentInformationView employmentInformationView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}