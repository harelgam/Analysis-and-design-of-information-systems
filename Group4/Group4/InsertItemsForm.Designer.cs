namespace Group4
{
    partial class InsertItemsForm
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
            this.orders1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.orders1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Orders1TableAdapter();
            this.Order_textbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Back_bt = new System.Windows.Forms.Button();
            this.OrderGridForSk = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orders1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ShowItems_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridForSk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // orders1BindingSource
            // 
            this.orders1BindingSource.DataMember = "Orders1";
            this.orders1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders1TableAdapter
            // 
            this.orders1TableAdapter.ClearBeforeFill = true;
            // 
            // Order_textbox
            // 
            this.Order_textbox.Location = new System.Drawing.Point(197, 98);
            this.Order_textbox.Name = "Order_textbox";
            this.Order_textbox.Size = new System.Drawing.Size(140, 20);
            this.Order_textbox.TabIndex = 1;
            this.Order_textbox.TextChanged += new System.EventHandler(this.Order_textbox_TextChanged);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Black;
            this.Search_button.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Location = new System.Drawing.Point(390, 93);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(79, 29);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert order:";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.Color.Black;
            this.Refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Location = new System.Drawing.Point(100, 345);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(137, 47);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Back_bt
            // 
            this.Back_bt.BackColor = System.Drawing.Color.Black;
            this.Back_bt.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_bt.ForeColor = System.Drawing.Color.White;
            this.Back_bt.Location = new System.Drawing.Point(560, 403);
            this.Back_bt.Name = "Back_bt";
            this.Back_bt.Size = new System.Drawing.Size(62, 32);
            this.Back_bt.TabIndex = 5;
            this.Back_bt.Text = "Back";
            this.Back_bt.UseVisualStyleBackColor = false;
            this.Back_bt.Click += new System.EventHandler(this.Back_bt_Click);
            // 
            // OrderGridForSk
            // 
            this.OrderGridForSk.AutoGenerateColumns = false;
            this.OrderGridForSk.BackgroundColor = System.Drawing.Color.White;
            this.OrderGridForSk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridForSk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.madeByDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn});
            this.OrderGridForSk.DataSource = this.orders1BindingSource1;
            this.OrderGridForSk.Location = new System.Drawing.Point(55, 157);
            this.OrderGridForSk.Name = "OrderGridForSk";
            this.OrderGridForSk.Size = new System.Drawing.Size(445, 149);
            this.OrderGridForSk.TabIndex = 6;
            this.OrderGridForSk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridForSk_CellContentClick);
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
            // madeByDataGridViewTextBoxColumn
            // 
            this.madeByDataGridViewTextBoxColumn.DataPropertyName = "madeBy";
            this.madeByDataGridViewTextBoxColumn.HeaderText = "madeBy";
            this.madeByDataGridViewTextBoxColumn.Name = "madeByDataGridViewTextBoxColumn";
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "purchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "purchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // orders1BindingSource1
            // 
            this.orders1BindingSource1.DataMember = "Orders1";
            this.orders1BindingSource1.DataSource = this.sAD_4DataSet;
            // 
            // ShowItems_btn
            // 
            this.ShowItems_btn.BackColor = System.Drawing.Color.Black;
            this.ShowItems_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowItems_btn.ForeColor = System.Drawing.Color.White;
            this.ShowItems_btn.Location = new System.Drawing.Point(274, 345);
            this.ShowItems_btn.Name = "ShowItems_btn";
            this.ShowItems_btn.Size = new System.Drawing.Size(137, 47);
            this.ShowItems_btn.TabIndex = 7;
            this.ShowItems_btn.Text = "Show items";
            this.ShowItems_btn.UseVisualStyleBackColor = false;
            this.ShowItems_btn.Click += new System.EventHandler(this.ShowItems_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insert Goods";
            // 
            // InsertItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.InsertItemsForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowItems_btn);
            this.Controls.Add(this.OrderGridForSk);
            this.Controls.Add(this.Back_bt);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Order_textbox);
            this.Name = "InsertItemsForm";
            this.Text = "InsertItemsForm";
            this.Load += new System.EventHandler(this.InsertItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridForSk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource orders1BindingSource;
        private SAD_4DataSetTableAdapters.Orders1TableAdapter orders1TableAdapter;
        private System.Windows.Forms.TextBox Order_textbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_bt;
        private System.Windows.Forms.DataGridView OrderGridForSk;
        private System.Windows.Forms.BindingSource orders1BindingSource1;
        private System.Windows.Forms.Button ShowItems_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}