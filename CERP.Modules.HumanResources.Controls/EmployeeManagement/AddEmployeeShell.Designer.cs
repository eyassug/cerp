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
            CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.EmploymentInformationViewModel employmentInformationViewModel2 = new CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.EmploymentInformationViewModel();
            CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.PersonalInformationViewModel personalInformationViewModel2 = new CERP.Modules.HumanResources.Controls.EmployeeManagement.ViewModels.PersonalInformationViewModel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.employeeDetailView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmployeeDetailView();
            this.employmentInformationView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmploymentInformationView();
            this.employeePersonalInformationView = new CERP.Modules.HumanResources.Controls.EmployeeManagement.Views.EmployeePersonalInformationView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSaveEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSaveEmployee);
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
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.emptySpaceItem2});
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
            this.employeeDetailView.Size = new System.Drawing.Size(963, 251);
            this.employeeDetailView.TabIndex = 6;
            // 
            // employmentInformationView
            // 
            employmentInformationViewModel2.Currency = "ETB";
            employmentInformationViewModel2.CurrencyOptions = null;
            employmentInformationViewModel2.Department = null;
            employmentInformationViewModel2.DepartmentOptions = null;
            employmentInformationViewModel2.EmployeeNumber = null;
            employmentInformationViewModel2.EmploymentType = "Local";
            employmentInformationViewModel2.HireDate = new System.DateTime(((long)(0)));
            employmentInformationViewModel2.Salary = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.employmentInformationView.EmploymentInformation = employmentInformationViewModel2;
            this.employmentInformationView.Location = new System.Drawing.Point(672, 12);
            this.employmentInformationView.Name = "employmentInformationView";
            this.employmentInformationView.Size = new System.Drawing.Size(303, 192);
            this.employmentInformationView.TabIndex = 5;
            // 
            // employeePersonalInformationView
            // 
            this.employeePersonalInformationView.Location = new System.Drawing.Point(12, 12);
            this.employeePersonalInformationView.Name = "employeePersonalInformationView";
            personalInformationViewModel2.DateOfBirth = new System.DateTime(((long)(0)));
            personalInformationViewModel2.FirstName = null;
            personalInformationViewModel2.LastName = null;
            personalInformationViewModel2.MaritalStatus = null;
            personalInformationViewModel2.MiddleName = null;
            personalInformationViewModel2.Nationality = null;
            personalInformationViewModel2.NationalityOptions = null;
            personalInformationViewModel2.Remark = null;
            personalInformationViewModel2.Sex = null;
            this.employeePersonalInformationView.PersonalInformation = personalInformationViewModel2;
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
            this.layoutControlItem3.Size = new System.Drawing.Size(967, 255);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(897, 473);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(78, 22);
            this.btnSaveEmployee.StyleController = this.layoutControl1;
            this.btnSaveEmployee.TabIndex = 7;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.Click += new System.EventHandler(this.BtnSaveEmployeeClick);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSaveEmployee;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(885, 461);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 461);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(885, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnSaveEmployee;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}