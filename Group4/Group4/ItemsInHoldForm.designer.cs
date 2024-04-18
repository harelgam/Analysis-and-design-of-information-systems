namespace Group4
{
    partial class ItemsInHoldForm
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
            this.Back_btn = new System.Windows.Forms.Button();
            this.Approve_btn = new System.Windows.Forms.Button();
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.items1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.items1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Items1TableAdapter();
            this.itemsInOrder1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsInOrder1TableAdapter = new Group4.SAD_4DataSetTableAdapters.ItemsInOrder1TableAdapter();
            this.sAD_4DataSet1 = new Group4.SAD_4DataSet();
            this.itemsInOrder1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsInHoldGrid = new System.Windows.Forms.DataGridView();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsInOrder1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsInHoldGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(526, 336);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(78, 35);
            this.Back_btn.TabIndex = 1;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Approve_btn
            // 
            this.Approve_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Approve_btn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve_btn.ForeColor = System.Drawing.Color.White;
            this.Approve_btn.Location = new System.Drawing.Point(32, 281);
            this.Approve_btn.Name = "Approve_btn";
            this.Approve_btn.Size = new System.Drawing.Size(96, 42);
            this.Approve_btn.TabIndex = 2;
            this.Approve_btn.Text = "Aprrove";
            this.Approve_btn.UseVisualStyleBackColor = false;
            this.Approve_btn.Click += new System.EventHandler(this.Approve_btn_Click);
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
            // itemsInOrder1BindingSource
            // 
            this.itemsInOrder1BindingSource.DataMember = "ItemsInOrder1";
            this.itemsInOrder1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // itemsInOrder1TableAdapter
            // 
            this.itemsInOrder1TableAdapter.ClearBeforeFill = true;
            // 
            // sAD_4DataSet1
            // 
            this.sAD_4DataSet1.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsInOrder1BindingSource1
            // 
            this.itemsInOrder1BindingSource1.DataMember = "ItemsInOrder1";
            this.itemsInOrder1BindingSource1.DataSource = this.sAD_4DataSet1;
            // 
            // ItemsInHoldGrid
            // 
            this.ItemsInHoldGrid.AutoGenerateColumns = false;
            this.ItemsInHoldGrid.BackgroundColor = System.Drawing.Color.White;
            this.ItemsInHoldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsInHoldGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.ItemsInHoldGrid.DataSource = this.itemsInOrder1BindingSource2;
            this.ItemsInHoldGrid.Location = new System.Drawing.Point(32, 77);
            this.ItemsInHoldGrid.Name = "ItemsInHoldGrid";
            this.ItemsInHoldGrid.Size = new System.Drawing.Size(348, 185);
            this.ItemsInHoldGrid.TabIndex = 3;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // itemsInOrder1BindingSource2
            // 
            this.itemsInOrder1BindingSource2.DataMember = "ItemsInOrder1";
            this.itemsInOrder1BindingSource2.DataSource = this.sAD_4DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items in hold";
            // 
            // ItemsInHoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.ItemsInHold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsInHoldGrid);
            this.Controls.Add(this.Approve_btn);
            this.Controls.Add(this.Back_btn);
            this.Name = "ItemsInHoldForm";
            this.Text = "ItemsInHoldForm";
            this.Load += new System.EventHandler(this.ItemsInHoldForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsInHoldGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInOrder1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Approve_btn;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource items1BindingSource;
        private SAD_4DataSetTableAdapters.Items1TableAdapter items1TableAdapter;
        private System.Windows.Forms.BindingSource itemsInOrder1BindingSource;
        private SAD_4DataSetTableAdapters.ItemsInOrder1TableAdapter itemsInOrder1TableAdapter;
        private SAD_4DataSet sAD_4DataSet1;
        private System.Windows.Forms.BindingSource itemsInOrder1BindingSource1;
        private System.Windows.Forms.DataGridView ItemsInHoldGrid;
        private System.Windows.Forms.BindingSource itemsInOrder1BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}