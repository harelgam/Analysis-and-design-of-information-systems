namespace Group4
{
    partial class GoodsManagementForm
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
            this.ViewItems_btn = new System.Windows.Forms.Button();
            this.GoodsManagement_label = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.CreateItem_btn = new System.Windows.Forms.Button();
            this.ItemsGridView1 = new System.Windows.Forms.DataGridView();
            this.serialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityinstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.sAD4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.items1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Items1TableAdapter();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.UpdateItem_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD4DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewItems_btn
            // 
            this.ViewItems_btn.BackColor = System.Drawing.Color.Black;
            this.ViewItems_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewItems_btn.ForeColor = System.Drawing.Color.White;
            this.ViewItems_btn.Location = new System.Drawing.Point(208, 384);
            this.ViewItems_btn.Name = "ViewItems_btn";
            this.ViewItems_btn.Size = new System.Drawing.Size(118, 40);
            this.ViewItems_btn.TabIndex = 1;
            this.ViewItems_btn.Text = "View item";
            this.ViewItems_btn.UseVisualStyleBackColor = false;
            this.ViewItems_btn.Click += new System.EventHandler(this.ViewItems_btn_Click);
            // 
            // GoodsManagement_label
            // 
            this.GoodsManagement_label.AutoSize = true;
            this.GoodsManagement_label.BackColor = System.Drawing.Color.Transparent;
            this.GoodsManagement_label.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsManagement_label.ForeColor = System.Drawing.Color.White;
            this.GoodsManagement_label.Location = new System.Drawing.Point(41, 30);
            this.GoodsManagement_label.Name = "GoodsManagement_label";
            this.GoodsManagement_label.Size = new System.Drawing.Size(267, 45);
            this.GoodsManagement_label.TabIndex = 2;
            this.GoodsManagement_label.Text = "Items management";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(743, 431);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(108, 32);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // CreateItem_btn
            // 
            this.CreateItem_btn.BackColor = System.Drawing.Color.Black;
            this.CreateItem_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateItem_btn.ForeColor = System.Drawing.Color.White;
            this.CreateItem_btn.Location = new System.Drawing.Point(59, 384);
            this.CreateItem_btn.Name = "CreateItem_btn";
            this.CreateItem_btn.Size = new System.Drawing.Size(118, 40);
            this.CreateItem_btn.TabIndex = 4;
            this.CreateItem_btn.Text = "Create item";
            this.CreateItem_btn.UseVisualStyleBackColor = false;
            this.CreateItem_btn.Click += new System.EventHandler(this.CreateItem_btn_Click);
            // 
            // ItemsGridView1
            // 
            this.ItemsGridView1.AutoGenerateColumns = false;
            this.ItemsGridView1.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialnumberDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.quantityinstockDataGridViewTextBoxColumn,
            this.expirationdateDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.ItemsGridView1.DataSource = this.items1BindingSource;
            this.ItemsGridView1.Location = new System.Drawing.Point(27, 93);
            this.ItemsGridView1.Name = "ItemsGridView1";
            this.ItemsGridView1.Size = new System.Drawing.Size(643, 262);
            this.ItemsGridView1.TabIndex = 5;
            this.ItemsGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView1_CellContentClick);
            // 
            // serialnumberDataGridViewTextBoxColumn
            // 
            this.serialnumberDataGridViewTextBoxColumn.DataPropertyName = "serial_number";
            this.serialnumberDataGridViewTextBoxColumn.HeaderText = "serial_number";
            this.serialnumberDataGridViewTextBoxColumn.Name = "serialnumberDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // quantityinstockDataGridViewTextBoxColumn
            // 
            this.quantityinstockDataGridViewTextBoxColumn.DataPropertyName = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.HeaderText = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.Name = "quantityinstockDataGridViewTextBoxColumn";
            // 
            // expirationdateDataGridViewTextBoxColumn
            // 
            this.expirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.Name = "expirationdateDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // items1BindingSource
            // 
            this.items1BindingSource.DataMember = "Items1";
            this.items1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAD4DataSetBindingSource
            // 
            this.sAD4DataSetBindingSource.DataSource = this.sAD_4DataSet;
            this.sAD4DataSetBindingSource.Position = 0;
            // 
            // items1TableAdapter
            // 
            this.items1TableAdapter.ClearBeforeFill = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Black;
            this.Delete_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(511, 384);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(118, 40);
            this.Delete_btn.TabIndex = 6;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // UpdateItem_btn
            // 
            this.UpdateItem_btn.BackColor = System.Drawing.Color.Black;
            this.UpdateItem_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItem_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateItem_btn.Location = new System.Drawing.Point(360, 384);
            this.UpdateItem_btn.Name = "UpdateItem_btn";
            this.UpdateItem_btn.Size = new System.Drawing.Size(118, 40);
            this.UpdateItem_btn.TabIndex = 7;
            this.UpdateItem_btn.Text = "Update Item";
            this.UpdateItem_btn.UseVisualStyleBackColor = false;
            this.UpdateItem_btn.Click += new System.EventHandler(this.UpdateItem_btn_Click);
            // 
            // GoodsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.GoodsManagementForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 475);
            this.Controls.Add(this.UpdateItem_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.ItemsGridView1);
            this.Controls.Add(this.CreateItem_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.GoodsManagement_label);
            this.Controls.Add(this.ViewItems_btn);
            this.Name = "GoodsManagementForm";
            this.Text = "GoodsManagementForm";
            this.Load += new System.EventHandler(this.GoodsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD4DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewItems_btn;
        private System.Windows.Forms.Label GoodsManagement_label;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button CreateItem_btn;
        private System.Windows.Forms.DataGridView ItemsGridView1;
        private System.Windows.Forms.BindingSource sAD4DataSetBindingSource;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource items1BindingSource;
        private SAD_4DataSetTableAdapters.Items1TableAdapter items1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityinstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button UpdateItem_btn;
    }
}