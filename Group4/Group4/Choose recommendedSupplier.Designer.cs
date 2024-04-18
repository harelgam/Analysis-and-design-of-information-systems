namespace Group4
{
    partial class Choose_recommendedSupplier
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
            this.Suplliers_grid = new System.Windows.Forms.DataGridView();
            this.ChooseSupplier = new System.Windows.Forms.Label();
            this.Price_btn = new System.Windows.Forms.Button();
            this.Quality_btn = new System.Windows.Forms.Button();
            this.Supplytime_btn = new System.Windows.Forms.Button();
            this.Overall_btn = new System.Windows.Forms.Button();
            this.Discount_btn = new System.Windows.Forms.Button();
            this.Specialization_ComboBox = new System.Windows.Forms.ComboBox();
            this.FillterBylable = new System.Windows.Forms.Label();
            this.ViewSupllier_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Specialization_lable = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.suppliers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliers1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Suppliers1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Suplliers_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Suplliers_grid
            // 
            this.Suplliers_grid.BackgroundColor = System.Drawing.Color.White;
            this.Suplliers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Suplliers_grid.Location = new System.Drawing.Point(12, 79);
            this.Suplliers_grid.Name = "Suplliers_grid";
            this.Suplliers_grid.Size = new System.Drawing.Size(279, 354);
            this.Suplliers_grid.TabIndex = 0;
            this.Suplliers_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChooseSupplier
            // 
            this.ChooseSupplier.AutoSize = true;
            this.ChooseSupplier.BackColor = System.Drawing.Color.Transparent;
            this.ChooseSupplier.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSupplier.ForeColor = System.Drawing.Color.White;
            this.ChooseSupplier.Location = new System.Drawing.Point(153, 22);
            this.ChooseSupplier.Name = "ChooseSupplier";
            this.ChooseSupplier.Size = new System.Drawing.Size(226, 45);
            this.ChooseSupplier.TabIndex = 1;
            this.ChooseSupplier.Text = "Choose Supplier";
            // 
            // Price_btn
            // 
            this.Price_btn.BackColor = System.Drawing.Color.Black;
            this.Price_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_btn.ForeColor = System.Drawing.Color.White;
            this.Price_btn.Location = new System.Drawing.Point(297, 148);
            this.Price_btn.Name = "Price_btn";
            this.Price_btn.Size = new System.Drawing.Size(84, 38);
            this.Price_btn.TabIndex = 2;
            this.Price_btn.Text = "Price";
            this.Price_btn.UseVisualStyleBackColor = false;
            this.Price_btn.Click += new System.EventHandler(this.Price_btn_Click);
            // 
            // Quality_btn
            // 
            this.Quality_btn.BackColor = System.Drawing.Color.Black;
            this.Quality_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quality_btn.ForeColor = System.Drawing.Color.White;
            this.Quality_btn.Location = new System.Drawing.Point(410, 148);
            this.Quality_btn.Name = "Quality_btn";
            this.Quality_btn.Size = new System.Drawing.Size(84, 38);
            this.Quality_btn.TabIndex = 3;
            this.Quality_btn.Text = "Quality";
            this.Quality_btn.UseVisualStyleBackColor = false;
            this.Quality_btn.Click += new System.EventHandler(this.Quality_btn_Click);
            // 
            // Supplytime_btn
            // 
            this.Supplytime_btn.BackColor = System.Drawing.Color.Black;
            this.Supplytime_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplytime_btn.ForeColor = System.Drawing.Color.White;
            this.Supplytime_btn.Location = new System.Drawing.Point(297, 211);
            this.Supplytime_btn.Name = "Supplytime_btn";
            this.Supplytime_btn.Size = new System.Drawing.Size(84, 37);
            this.Supplytime_btn.TabIndex = 4;
            this.Supplytime_btn.Text = "Supply time";
            this.Supplytime_btn.UseVisualStyleBackColor = false;
            this.Supplytime_btn.Click += new System.EventHandler(this.Supplytime_btn_Click);
            // 
            // Overall_btn
            // 
            this.Overall_btn.BackColor = System.Drawing.Color.Black;
            this.Overall_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overall_btn.ForeColor = System.Drawing.Color.White;
            this.Overall_btn.Location = new System.Drawing.Point(410, 211);
            this.Overall_btn.Name = "Overall_btn";
            this.Overall_btn.Size = new System.Drawing.Size(84, 37);
            this.Overall_btn.TabIndex = 5;
            this.Overall_btn.Text = "Overall";
            this.Overall_btn.UseVisualStyleBackColor = false;
            this.Overall_btn.Click += new System.EventHandler(this.Overall_btn_Click);
            // 
            // Discount_btn
            // 
            this.Discount_btn.BackColor = System.Drawing.Color.Black;
            this.Discount_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_btn.ForeColor = System.Drawing.Color.White;
            this.Discount_btn.Location = new System.Drawing.Point(356, 268);
            this.Discount_btn.Name = "Discount_btn";
            this.Discount_btn.Size = new System.Drawing.Size(84, 37);
            this.Discount_btn.TabIndex = 6;
            this.Discount_btn.Text = "Discount";
            this.Discount_btn.UseVisualStyleBackColor = false;
            this.Discount_btn.Click += new System.EventHandler(this.Discount_btn_Click);
            // 
            // Specialization_ComboBox
            // 
            this.Specialization_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Specialization_ComboBox.Items.AddRange(new object[] {
            "Construction materials",
            "Electronic components",
            "IT services",
            "Logistics provider",
            "Logistics provider",
            "Packaging",
            "Printing and publishing",
            "Raw materials"});
            this.Specialization_ComboBox.Location = new System.Drawing.Point(340, 359);
            this.Specialization_ComboBox.Name = "Specialization_ComboBox";
            this.Specialization_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Specialization_ComboBox.TabIndex = 7;
            this.Specialization_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Specialization_ComboBox_SelectedIndexChanged);
            // 
            // FillterBylable
            // 
            this.FillterBylable.AutoSize = true;
            this.FillterBylable.BackColor = System.Drawing.Color.Transparent;
            this.FillterBylable.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterBylable.ForeColor = System.Drawing.Color.White;
            this.FillterBylable.Location = new System.Drawing.Point(352, 105);
            this.FillterBylable.Name = "FillterBylable";
            this.FillterBylable.Size = new System.Drawing.Size(93, 23);
            this.FillterBylable.TabIndex = 8;
            this.FillterBylable.Text = "Fillter By";
            // 
            // ViewSupllier_btn
            // 
            this.ViewSupllier_btn.BackColor = System.Drawing.Color.Black;
            this.ViewSupllier_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSupllier_btn.ForeColor = System.Drawing.Color.White;
            this.ViewSupllier_btn.Location = new System.Drawing.Point(50, 475);
            this.ViewSupllier_btn.Name = "ViewSupllier_btn";
            this.ViewSupllier_btn.Size = new System.Drawing.Size(108, 43);
            this.ViewSupllier_btn.TabIndex = 9;
            this.ViewSupllier_btn.Text = "View supplier";
            this.ViewSupllier_btn.UseVisualStyleBackColor = false;
            this.ViewSupllier_btn.Click += new System.EventHandler(this.ViewSupllier_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(428, 487);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 31);
            this.Back_btn.TabIndex = 10;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Specialization_lable
            // 
            this.Specialization_lable.AutoSize = true;
            this.Specialization_lable.BackColor = System.Drawing.Color.Transparent;
            this.Specialization_lable.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization_lable.ForeColor = System.Drawing.Color.White;
            this.Specialization_lable.Location = new System.Drawing.Point(346, 328);
            this.Specialization_lable.Name = "Specialization_lable";
            this.Specialization_lable.Size = new System.Drawing.Size(107, 18);
            this.Specialization_lable.TabIndex = 11;
            this.Specialization_lable.Text = "Specialization";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.Color.Black;
            this.Refresh_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btn.Location = new System.Drawing.Point(67, 439);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(75, 30);
            this.Refresh_btn.TabIndex = 12;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliers1BindingSource
            // 
            this.suppliers1BindingSource.DataMember = "Suppliers1";
            this.suppliers1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // suppliers1TableAdapter
            // 
            this.suppliers1TableAdapter.ClearBeforeFill = true;
            // 
            // Choose_recommendedSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.chooseRecommendedSupplier;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 530);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Specialization_lable);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.ViewSupllier_btn);
            this.Controls.Add(this.FillterBylable);
            this.Controls.Add(this.Specialization_ComboBox);
            this.Controls.Add(this.Discount_btn);
            this.Controls.Add(this.Overall_btn);
            this.Controls.Add(this.Supplytime_btn);
            this.Controls.Add(this.Quality_btn);
            this.Controls.Add(this.Price_btn);
            this.Controls.Add(this.ChooseSupplier);
            this.Controls.Add(this.Suplliers_grid);
            this.Name = "Choose_recommendedSupplier";
            this.Text = "Choose_recommendedSupplier";
            this.Load += new System.EventHandler(this.Choose_recommendedSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Suplliers_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Suplliers_grid;
        private System.Windows.Forms.Label ChooseSupplier;
        private System.Windows.Forms.Button Price_btn;
        private System.Windows.Forms.Button Quality_btn;
        private System.Windows.Forms.Button Supplytime_btn;
        private System.Windows.Forms.Button Overall_btn;
        private System.Windows.Forms.Button Discount_btn;
        private System.Windows.Forms.Label FillterBylable;
        private System.Windows.Forms.Button ViewSupllier_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ComboBox Specialization_ComboBox;
        private System.Windows.Forms.Label Specialization_lable;
        private System.Windows.Forms.Button Refresh_btn;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource suppliers1BindingSource;
        private SAD_4DataSetTableAdapters.Suppliers1TableAdapter suppliers1TableAdapter;
    }
}