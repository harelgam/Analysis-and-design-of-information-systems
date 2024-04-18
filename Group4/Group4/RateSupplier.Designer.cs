namespace Group4
{
    partial class RateSupplier
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
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.orders1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Orders1TableAdapter();
            this.SearchBoxOrder = new System.Windows.Forms.TextBox();
            this.PriceRateBox = new System.Windows.Forms.ComboBox();
            this.QuallityRateBox = new System.Windows.Forms.ComboBox();
            this.SupplyTimeRate = new System.Windows.Forms.ComboBox();
            this.searchOrderBox = new System.Windows.Forms.Label();
            this.PriceRateLable = new System.Windows.Forms.Label();
            this.SupplyTimeRateLable = new System.Windows.Forms.Label();
            this.QualityRate = new System.Windows.Forms.Label();
            this.orders1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet1 = new Group4.SAD_4DataSet();
            this.orders1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orders1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet2 = new Group4.SAD_4DataSet();
            this.orders1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyTimeRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orders1BindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.orders1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchOrder_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.ApplyRate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders1BindingSource
            // 
            this.orders1BindingSource.DataMember = "Orders1";
            this.orders1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // orders1TableAdapter
            // 
            this.orders1TableAdapter.ClearBeforeFill = true;
            // 
            // SearchBoxOrder
            // 
            this.SearchBoxOrder.Location = new System.Drawing.Point(116, 374);
            this.SearchBoxOrder.Name = "SearchBoxOrder";
            this.SearchBoxOrder.Size = new System.Drawing.Size(232, 20);
            this.SearchBoxOrder.TabIndex = 2;
            this.SearchBoxOrder.TextChanged += new System.EventHandler(this.SearchBoxOrder_TextChanged);
            // 
            // PriceRateBox
            // 
            this.PriceRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceRateBox.FormattingEnabled = true;
            this.PriceRateBox.Location = new System.Drawing.Point(623, 246);
            this.PriceRateBox.Name = "PriceRateBox";
            this.PriceRateBox.Size = new System.Drawing.Size(121, 21);
            this.PriceRateBox.TabIndex = 3;
            // 
            // QuallityRateBox
            // 
            this.QuallityRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuallityRateBox.FormattingEnabled = true;
            this.QuallityRateBox.Location = new System.Drawing.Point(623, 191);
            this.QuallityRateBox.Name = "QuallityRateBox";
            this.QuallityRateBox.Size = new System.Drawing.Size(121, 21);
            this.QuallityRateBox.TabIndex = 4;
            // 
            // SupplyTimeRate
            // 
            this.SupplyTimeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplyTimeRate.FormattingEnabled = true;
            this.SupplyTimeRate.Location = new System.Drawing.Point(623, 139);
            this.SupplyTimeRate.Name = "SupplyTimeRate";
            this.SupplyTimeRate.Size = new System.Drawing.Size(121, 21);
            this.SupplyTimeRate.TabIndex = 5;
            this.SupplyTimeRate.SelectedIndexChanged += new System.EventHandler(this.SupplyTimeRate_SelectedIndexChanged);
            // 
            // searchOrderBox
            // 
            this.searchOrderBox.AutoSize = true;
            this.searchOrderBox.BackColor = System.Drawing.Color.Transparent;
            this.searchOrderBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrderBox.ForeColor = System.Drawing.Color.White;
            this.searchOrderBox.Location = new System.Drawing.Point(10, 374);
            this.searchOrderBox.Name = "searchOrderBox";
            this.searchOrderBox.Size = new System.Drawing.Size(106, 19);
            this.searchOrderBox.TabIndex = 7;
            this.searchOrderBox.Text = "Search order";
            // 
            // PriceRateLable
            // 
            this.PriceRateLable.AutoSize = true;
            this.PriceRateLable.BackColor = System.Drawing.Color.Transparent;
            this.PriceRateLable.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceRateLable.ForeColor = System.Drawing.Color.White;
            this.PriceRateLable.Location = new System.Drawing.Point(623, 225);
            this.PriceRateLable.Name = "PriceRateLable";
            this.PriceRateLable.Size = new System.Drawing.Size(63, 16);
            this.PriceRateLable.TabIndex = 8;
            this.PriceRateLable.Text = "Price rate";
            this.PriceRateLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // SupplyTimeRateLable
            // 
            this.SupplyTimeRateLable.AutoSize = true;
            this.SupplyTimeRateLable.BackColor = System.Drawing.Color.Transparent;
            this.SupplyTimeRateLable.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyTimeRateLable.ForeColor = System.Drawing.Color.White;
            this.SupplyTimeRateLable.Location = new System.Drawing.Point(623, 116);
            this.SupplyTimeRateLable.Name = "SupplyTimeRateLable";
            this.SupplyTimeRateLable.Size = new System.Drawing.Size(102, 16);
            this.SupplyTimeRateLable.TabIndex = 9;
            this.SupplyTimeRateLable.Text = "Supply time rate";
            this.SupplyTimeRateLable.Click += new System.EventHandler(this.label4_Click);
            // 
            // QualityRate
            // 
            this.QualityRate.AutoSize = true;
            this.QualityRate.BackColor = System.Drawing.Color.Transparent;
            this.QualityRate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityRate.ForeColor = System.Drawing.Color.White;
            this.QualityRate.Location = new System.Drawing.Point(622, 169);
            this.QualityRate.Name = "QualityRate";
            this.QualityRate.Size = new System.Drawing.Size(75, 16);
            this.QualityRate.TabIndex = 10;
            this.QualityRate.Text = "Quality rate";
            this.QualityRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orders1BindingSource1
            // 
            this.orders1BindingSource1.DataMember = "Orders1";
            this.orders1BindingSource1.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet1
            // 
            this.sAD_4DataSet1.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders1BindingSource2
            // 
            this.orders1BindingSource2.DataMember = "Orders1";
            this.orders1BindingSource2.DataSource = this.sAD_4DataSet1;
            // 
            // orders1BindingSource3
            // 
            this.orders1BindingSource3.DataMember = "Orders1";
            this.orders1BindingSource3.DataSource = this.sAD_4DataSet2;
            // 
            // sAD_4DataSet2
            // 
            this.sAD_4DataSet2.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders1BindingSource4
            // 
            this.orders1BindingSource4.DataMember = "Orders1";
            this.orders1BindingSource4.DataSource = this.sAD_4DataSet;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AutoGenerateColumns = false;
            this.OrdersGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.priceRatingDataGridViewTextBoxColumn,
            this.supplyTimeRatingDataGridViewTextBoxColumn,
            this.qualityRatingDataGridViewTextBoxColumn});
            this.OrdersGrid.DataSource = this.orders1BindingSource6;
            this.OrdersGrid.Location = new System.Drawing.Point(30, 100);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(549, 241);
            this.OrdersGrid.TabIndex = 11;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // priceRatingDataGridViewTextBoxColumn
            // 
            this.priceRatingDataGridViewTextBoxColumn.DataPropertyName = "priceRating";
            this.priceRatingDataGridViewTextBoxColumn.HeaderText = "priceRating";
            this.priceRatingDataGridViewTextBoxColumn.Name = "priceRatingDataGridViewTextBoxColumn";
            // 
            // supplyTimeRatingDataGridViewTextBoxColumn
            // 
            this.supplyTimeRatingDataGridViewTextBoxColumn.DataPropertyName = "supplyTimeRating";
            this.supplyTimeRatingDataGridViewTextBoxColumn.HeaderText = "supplyTimeRating";
            this.supplyTimeRatingDataGridViewTextBoxColumn.Name = "supplyTimeRatingDataGridViewTextBoxColumn";
            // 
            // qualityRatingDataGridViewTextBoxColumn
            // 
            this.qualityRatingDataGridViewTextBoxColumn.DataPropertyName = "qualityRating";
            this.qualityRatingDataGridViewTextBoxColumn.HeaderText = "qualityRating";
            this.qualityRatingDataGridViewTextBoxColumn.Name = "qualityRatingDataGridViewTextBoxColumn";
            // 
            // orders1BindingSource6
            // 
            this.orders1BindingSource6.DataMember = "Orders1";
            this.orders1BindingSource6.DataSource = this.sAD_4DataSet;
            // 
            // orders1BindingSource5
            // 
            this.orders1BindingSource5.DataMember = "Orders1";
            this.orders1BindingSource5.DataSource = this.sAD_4DataSet;
            // 
            // SearchOrder_btn
            // 
            this.SearchOrder_btn.BackColor = System.Drawing.Color.Black;
            this.SearchOrder_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrder_btn.ForeColor = System.Drawing.Color.White;
            this.SearchOrder_btn.Location = new System.Drawing.Point(352, 371);
            this.SearchOrder_btn.Name = "SearchOrder_btn";
            this.SearchOrder_btn.Size = new System.Drawing.Size(79, 29);
            this.SearchOrder_btn.TabIndex = 12;
            this.SearchOrder_btn.Text = "Search";
            this.SearchOrder_btn.UseVisualStyleBackColor = false;
            this.SearchOrder_btn.Click += new System.EventHandler(this.SearchOrder_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.Color.Black;
            this.Refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Location = new System.Drawing.Point(462, 365);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(108, 43);
            this.Refresh_btn.TabIndex = 13;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(753, 372);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(70, 36);
            this.Back_btn.TabIndex = 14;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ApplyRate_btn
            // 
            this.ApplyRate_btn.BackColor = System.Drawing.Color.Black;
            this.ApplyRate_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyRate_btn.ForeColor = System.Drawing.Color.White;
            this.ApplyRate_btn.Location = new System.Drawing.Point(642, 280);
            this.ApplyRate_btn.Name = "ApplyRate_btn";
            this.ApplyRate_btn.Size = new System.Drawing.Size(84, 35);
            this.ApplyRate_btn.TabIndex = 15;
            this.ApplyRate_btn.Text = "Apply rates";
            this.ApplyRate_btn.UseVisualStyleBackColor = false;
            this.ApplyRate_btn.Click += new System.EventHandler(this.ApplyRate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rate supplier";
            // 
            // RateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.RateSupplierForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyRate_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.SearchOrder_btn);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.QualityRate);
            this.Controls.Add(this.SupplyTimeRateLable);
            this.Controls.Add(this.PriceRateLable);
            this.Controls.Add(this.searchOrderBox);
            this.Controls.Add(this.SupplyTimeRate);
            this.Controls.Add(this.QuallityRateBox);
            this.Controls.Add(this.PriceRateBox);
            this.Controls.Add(this.SearchBoxOrder);
            this.Name = "RateSupplier";
            this.Text = "RateSupplier";
            this.Load += new System.EventHandler(this.RateSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource orders1BindingSource;
        private SAD_4DataSetTableAdapters.Orders1TableAdapter orders1TableAdapter;
        private System.Windows.Forms.TextBox SearchBoxOrder;
        private System.Windows.Forms.ComboBox PriceRateBox;
        private System.Windows.Forms.ComboBox QuallityRateBox;
        private System.Windows.Forms.ComboBox SupplyTimeRate;
        private System.Windows.Forms.Label searchOrderBox;
        private System.Windows.Forms.Label PriceRateLable;
        private System.Windows.Forms.Label SupplyTimeRateLable;
        private System.Windows.Forms.Label QualityRate;
        private System.Windows.Forms.BindingSource orders1BindingSource1;
        private SAD_4DataSet sAD_4DataSet1;
        private System.Windows.Forms.BindingSource orders1BindingSource2;
        private SAD_4DataSet sAD_4DataSet2;
        private System.Windows.Forms.BindingSource orders1BindingSource3;
        private System.Windows.Forms.BindingSource orders1BindingSource4;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.BindingSource orders1BindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyTimeRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orders1BindingSource6;
        private System.Windows.Forms.Button SearchOrder_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button ApplyRate_btn;
        private System.Windows.Forms.Label label1;
    }
}