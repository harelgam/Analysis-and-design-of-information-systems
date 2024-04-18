namespace Group4
{
    partial class SupplierManagementcs
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
            this.suppliers_datagrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.AddSupplier_btn = new System.Windows.Forms.Button();
            this.DeleateSupplier_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.searchSupplier_textbox = new System.Windows.Forms.TextBox();
            this.searchlable = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.UpdateSupplier_btn = new System.Windows.Forms.Button();
            this.suppliers1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Suppliers1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliers_datagrid
            // 
            this.suppliers_datagrid.AutoGenerateColumns = false;
            this.suppliers_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.suppliers_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliers_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn});
            this.suppliers_datagrid.DataSource = this.suppliers1BindingSource;
            this.suppliers_datagrid.Location = new System.Drawing.Point(35, 90);
            this.suppliers_datagrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliers_datagrid.Name = "suppliers_datagrid";
            this.suppliers_datagrid.Size = new System.Drawing.Size(649, 229);
            this.suppliers_datagrid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // suppliers1BindingSource
            // 
            this.suppliers1BindingSource.DataMember = "Suppliers1";
            this.suppliers1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddSupplier_btn
            // 
            this.AddSupplier_btn.BackColor = System.Drawing.Color.Black;
            this.AddSupplier_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplier_btn.ForeColor = System.Drawing.Color.White;
            this.AddSupplier_btn.Location = new System.Drawing.Point(66, 360);
            this.AddSupplier_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddSupplier_btn.Name = "AddSupplier_btn";
            this.AddSupplier_btn.Size = new System.Drawing.Size(117, 46);
            this.AddSupplier_btn.TabIndex = 1;
            this.AddSupplier_btn.Text = "Add supplier";
            this.AddSupplier_btn.UseVisualStyleBackColor = false;
            this.AddSupplier_btn.Click += new System.EventHandler(this.AddSupplier_btn_Click);
            // 
            // DeleateSupplier_btn
            // 
            this.DeleateSupplier_btn.BackColor = System.Drawing.Color.Black;
            this.DeleateSupplier_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleateSupplier_btn.ForeColor = System.Drawing.Color.White;
            this.DeleateSupplier_btn.Location = new System.Drawing.Point(381, 360);
            this.DeleateSupplier_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleateSupplier_btn.Name = "DeleateSupplier_btn";
            this.DeleateSupplier_btn.Size = new System.Drawing.Size(126, 46);
            this.DeleateSupplier_btn.TabIndex = 3;
            this.DeleateSupplier_btn.Text = "Delete supplier";
            this.DeleateSupplier_btn.UseVisualStyleBackColor = false;
            this.DeleateSupplier_btn.Click += new System.EventHandler(this.DeleateSupplier_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.Color.Black;
            this.Refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Location = new System.Drawing.Point(615, 362);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(119, 44);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(647, 446);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(87, 28);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // searchSupplier_textbox
            // 
            this.searchSupplier_textbox.Location = new System.Drawing.Point(413, 48);
            this.searchSupplier_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchSupplier_textbox.Name = "searchSupplier_textbox";
            this.searchSupplier_textbox.Size = new System.Drawing.Size(116, 23);
            this.searchSupplier_textbox.TabIndex = 6;
            // 
            // searchlable
            // 
            this.searchlable.AutoSize = true;
            this.searchlable.BackColor = System.Drawing.Color.Transparent;
            this.searchlable.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlable.ForeColor = System.Drawing.Color.White;
            this.searchlable.Location = new System.Drawing.Point(288, 56);
            this.searchlable.Name = "searchlable";
            this.searchlable.Size = new System.Drawing.Size(103, 19);
            this.searchlable.TabIndex = 7;
            this.searchlable.Text = "search name";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Black;
            this.search_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(558, 43);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(87, 28);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // UpdateSupplier_btn
            // 
            this.UpdateSupplier_btn.BackColor = System.Drawing.Color.Black;
            this.UpdateSupplier_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSupplier_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateSupplier_btn.Location = new System.Drawing.Point(220, 360);
            this.UpdateSupplier_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateSupplier_btn.Name = "UpdateSupplier_btn";
            this.UpdateSupplier_btn.Size = new System.Drawing.Size(122, 46);
            this.UpdateSupplier_btn.TabIndex = 2;
            this.UpdateSupplier_btn.Text = "Update supplier";
            this.UpdateSupplier_btn.UseVisualStyleBackColor = false;
            this.UpdateSupplier_btn.Click += new System.EventHandler(this.UpdateSupplier_btn_Click);
            // 
            // suppliers1TableAdapter
            // 
            this.suppliers1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suppliers";
            // 
            // SupplierManagementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Group4.Properties.Resources.SupplierManagementForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchlable);
            this.Controls.Add(this.searchSupplier_textbox);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.DeleateSupplier_btn);
            this.Controls.Add(this.UpdateSupplier_btn);
            this.Controls.Add(this.AddSupplier_btn);
            this.Controls.Add(this.suppliers_datagrid);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierManagementcs";
            this.Text = "SupplierManagementcs";
            this.Load += new System.EventHandler(this.SupplierManagementcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView suppliers_datagrid;
        private System.Windows.Forms.Button AddSupplier_btn;
        private System.Windows.Forms.Button DeleateSupplier_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox searchSupplier_textbox;
        private System.Windows.Forms.Label searchlable;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button UpdateSupplier_btn;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource suppliers1BindingSource;
        private SAD_4DataSetTableAdapters.Suppliers1TableAdapter suppliers1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}