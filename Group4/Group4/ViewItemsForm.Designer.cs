namespace Group4
{
    partial class ViewItemsForm
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
            this.ViewItems_label = new System.Windows.Forms.Label();
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.items1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.items1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Items1TableAdapter();
            this.ItemsGridView1 = new System.Windows.Forms.DataGridView();
            this.serialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityinstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet1 = new Group4.SAD_4DataSet();
            this.SerialNumber_textbox = new System.Windows.Forms.TextBox();
            this.SearchItem_btn = new System.Windows.Forms.Button();
            this.insertSN_label = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewItems_label
            // 
            this.ViewItems_label.AutoSize = true;
            this.ViewItems_label.BackColor = System.Drawing.Color.Transparent;
            this.ViewItems_label.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewItems_label.ForeColor = System.Drawing.Color.Black;
            this.ViewItems_label.Location = new System.Drawing.Point(41, 36);
            this.ViewItems_label.Name = "ViewItems_label";
            this.ViewItems_label.Size = new System.Drawing.Size(173, 45);
            this.ViewItems_label.TabIndex = 0;
            this.ViewItems_label.Text = "View Items";
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // items1BindingSource
            // 
            this.items1BindingSource.DataMember = "Items1";
            this.items1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // items1TableAdapter
            // 
            this.items1TableAdapter.ClearBeforeFill = true;
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
            this.ItemsGridView1.DataSource = this.items1BindingSource1;
            this.ItemsGridView1.Location = new System.Drawing.Point(51, 162);
            this.ItemsGridView1.Name = "ItemsGridView1";
            this.ItemsGridView1.Size = new System.Drawing.Size(644, 213);
            this.ItemsGridView1.TabIndex = 1;
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
            // items1BindingSource1
            // 
            this.items1BindingSource1.DataMember = "Items1";
            this.items1BindingSource1.DataSource = this.sAD_4DataSet1;
            // 
            // sAD_4DataSet1
            // 
            this.sAD_4DataSet1.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SerialNumber_textbox
            // 
            this.SerialNumber_textbox.Location = new System.Drawing.Point(279, 115);
            this.SerialNumber_textbox.Name = "SerialNumber_textbox";
            this.SerialNumber_textbox.Size = new System.Drawing.Size(230, 20);
            this.SerialNumber_textbox.TabIndex = 2;
            this.SerialNumber_textbox.TextChanged += new System.EventHandler(this.SerialNumber_textbox_TextChanged);
            // 
            // SearchItem_btn
            // 
            this.SearchItem_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchItem_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItem_btn.ForeColor = System.Drawing.Color.White;
            this.SearchItem_btn.Location = new System.Drawing.Point(537, 112);
            this.SearchItem_btn.Name = "SearchItem_btn";
            this.SearchItem_btn.Size = new System.Drawing.Size(88, 25);
            this.SearchItem_btn.TabIndex = 3;
            this.SearchItem_btn.Text = "Search";
            this.SearchItem_btn.UseVisualStyleBackColor = false;
            this.SearchItem_btn.Click += new System.EventHandler(this.SearchItem_btn_Click);
            // 
            // insertSN_label
            // 
            this.insertSN_label.AutoSize = true;
            this.insertSN_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertSN_label.Location = new System.Drawing.Point(98, 116);
            this.insertSN_label.Name = "insertSN_label";
            this.insertSN_label.Size = new System.Drawing.Size(157, 19);
            this.insertSN_label.TabIndex = 4;
            this.insertSN_label.Text = "Insert serial number";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Location = new System.Drawing.Point(91, 392);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(139, 45);
            this.Refresh_btn.TabIndex = 5;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(621, 424);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(105, 27);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ViewItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.viewItemsForm2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.insertSN_label);
            this.Controls.Add(this.SearchItem_btn);
            this.Controls.Add(this.SerialNumber_textbox);
            this.Controls.Add(this.ItemsGridView1);
            this.Controls.Add(this.ViewItems_label);
            this.Name = "ViewItemsForm";
            this.Text = "ViewItemsForm";
            this.Load += new System.EventHandler(this.ViewItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewItems_label;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource items1BindingSource;
        private SAD_4DataSetTableAdapters.Items1TableAdapter items1TableAdapter;
        private System.Windows.Forms.DataGridView ItemsGridView1;
        private SAD_4DataSet sAD_4DataSet1;
        private System.Windows.Forms.BindingSource items1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityinstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SerialNumber_textbox;
        private System.Windows.Forms.Button SearchItem_btn;
        private System.Windows.Forms.Label insertSN_label;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}