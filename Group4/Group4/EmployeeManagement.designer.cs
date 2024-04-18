namespace Group4
{
    partial class EmployeeManagement
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.employeeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.employees1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Employees1TableAdapter();
            this.SearchEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.AddEmployee_btn = new System.Windows.Forms.Button();
            this.UpdateEmployee_btn = new System.Windows.Forms.Button();
            this.DeleteEmployee_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.EmployeeArchive_btn = new System.Windows.Forms.Button();
            this.saD_4DataSet1 = new Group4.SAD_4DataSet();
            this.saD_4DataSet2 = new Group4.SAD_4DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saD_4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saD_4DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AutoGenerateColumns = false;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.EmployeeGrid.DataSource = this.employees1BindingSource;
            this.EmployeeGrid.Location = new System.Drawing.Point(12, 79);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(937, 270);
            this.EmployeeGrid.TabIndex = 1;
            this.EmployeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGrid_CellContentClick);
            // 
            // employeeNumDataGridViewTextBoxColumn
            // 
            this.employeeNumDataGridViewTextBoxColumn.DataPropertyName = "employeeNum";
            this.employeeNumDataGridViewTextBoxColumn.HeaderText = "employeeNum";
            this.employeeNumDataGridViewTextBoxColumn.Name = "employeeNumDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // employees1BindingSource
            // 
            this.employees1BindingSource.DataMember = "Employees1";
            this.employees1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employees1TableAdapter
            // 
            this.employees1TableAdapter.ClearBeforeFill = true;
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.Location = new System.Drawing.Point(29, 396);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(100, 20);
            this.SearchEmployee.TabIndex = 2;
            this.SearchEmployee.TextChanged += new System.EventHandler(this.SearchEmployee_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "search first name:";
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(166, 396);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(800, 371);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(149, 45);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // AddEmployee_btn
            // 
            this.AddEmployee_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddEmployee_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_btn.ForeColor = System.Drawing.Color.White;
            this.AddEmployee_btn.Location = new System.Drawing.Point(166, 465);
            this.AddEmployee_btn.Name = "AddEmployee_btn";
            this.AddEmployee_btn.Size = new System.Drawing.Size(149, 44);
            this.AddEmployee_btn.TabIndex = 6;
            this.AddEmployee_btn.Text = "Add employee";
            this.AddEmployee_btn.UseVisualStyleBackColor = false;
            this.AddEmployee_btn.Click += new System.EventHandler(this.AddEmployee_btn_Click);
            // 
            // UpdateEmployee_btn
            // 
            this.UpdateEmployee_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateEmployee_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployee_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployee_btn.Location = new System.Drawing.Point(360, 465);
            this.UpdateEmployee_btn.Name = "UpdateEmployee_btn";
            this.UpdateEmployee_btn.Size = new System.Drawing.Size(149, 44);
            this.UpdateEmployee_btn.TabIndex = 7;
            this.UpdateEmployee_btn.Text = "Update employee";
            this.UpdateEmployee_btn.UseVisualStyleBackColor = false;
            this.UpdateEmployee_btn.Click += new System.EventHandler(this.UpdateEmployee_btn_Click);
            // 
            // DeleteEmployee_btn
            // 
            this.DeleteEmployee_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteEmployee_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployee_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployee_btn.Location = new System.Drawing.Point(552, 465);
            this.DeleteEmployee_btn.Name = "DeleteEmployee_btn";
            this.DeleteEmployee_btn.Size = new System.Drawing.Size(149, 44);
            this.DeleteEmployee_btn.TabIndex = 8;
            this.DeleteEmployee_btn.Text = "Delete employee";
            this.DeleteEmployee_btn.UseVisualStyleBackColor = false;
            this.DeleteEmployee_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.return_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(897, 493);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 9;
            this.return_btn.Text = "back";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // EmployeeArchive_btn
            // 
            this.EmployeeArchive_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmployeeArchive_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeArchive_btn.ForeColor = System.Drawing.Color.White;
            this.EmployeeArchive_btn.Location = new System.Drawing.Point(805, 493);
            this.EmployeeArchive_btn.Name = "EmployeeArchive_btn";
            this.EmployeeArchive_btn.Size = new System.Drawing.Size(75, 23);
            this.EmployeeArchive_btn.TabIndex = 10;
            this.EmployeeArchive_btn.Text = "Archive";
            this.EmployeeArchive_btn.UseVisualStyleBackColor = false;
            this.EmployeeArchive_btn.Click += new System.EventHandler(this.EmployeeArchive_btn_Click);
            // 
            // saD_4DataSet1
            // 
            this.saD_4DataSet1.DataSetName = "SAD_4DataSet";
            this.saD_4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saD_4DataSet2
            // 
            this.saD_4DataSet2.DataSetName = "SAD_4DataSet";
            this.saD_4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.EmployeeManagementForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 521);
            this.Controls.Add(this.EmployeeArchive_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.DeleteEmployee_btn);
            this.Controls.Add(this.UpdateEmployee_btn);
            this.Controls.Add(this.AddEmployee_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchEmployee);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeManagement";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saD_4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saD_4DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource employees1BindingSource;
        private SAD_4DataSetTableAdapters.Employees1TableAdapter employees1TableAdapter;
        private System.Windows.Forms.TextBox SearchEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button AddEmployee_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UpdateEmployee_btn;
        private System.Windows.Forms.Button DeleteEmployee_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button EmployeeArchive_btn;
        private SAD_4DataSet saD_4DataSet1;
        private SAD_4DataSet saD_4DataSet2;
    }
}