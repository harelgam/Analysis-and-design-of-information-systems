namespace Group4
{
    partial class view_SupplierDetails
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
            this.SupplierDetails_lable = new System.Windows.Forms.Label();
            this.Details_ViewGrid = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Details_ViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierDetails_lable
            // 
            this.SupplierDetails_lable.AutoSize = true;
            this.SupplierDetails_lable.BackColor = System.Drawing.Color.Transparent;
            this.SupplierDetails_lable.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierDetails_lable.ForeColor = System.Drawing.Color.White;
            this.SupplierDetails_lable.Location = new System.Drawing.Point(12, 9);
            this.SupplierDetails_lable.Name = "SupplierDetails_lable";
            this.SupplierDetails_lable.Size = new System.Drawing.Size(249, 45);
            this.SupplierDetails_lable.TabIndex = 0;
            this.SupplierDetails_lable.Text = "Supplier Details";
            // 
            // Details_ViewGrid
            // 
            this.Details_ViewGrid.BackgroundColor = System.Drawing.Color.White;
            this.Details_ViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Details_ViewGrid.Location = new System.Drawing.Point(18, 59);
            this.Details_ViewGrid.Name = "Details_ViewGrid";
            this.Details_ViewGrid.Size = new System.Drawing.Size(576, 85);
            this.Details_ViewGrid.TabIndex = 1;
            this.Details_ViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_ViewGrid_CellContentClick);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(528, 163);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(66, 30);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.UseWaitCursor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // view_SupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.viewSupplierDetails;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 208);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Details_ViewGrid);
            this.Controls.Add(this.SupplierDetails_lable);
            this.Name = "view_SupplierDetails";
            this.Text = "view_SupplierDetails";
            this.Load += new System.EventHandler(this.view_SupplierDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Details_ViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SupplierDetails_lable;
        private System.Windows.Forms.DataGridView Details_ViewGrid;
        private System.Windows.Forms.Button Back_btn;
    }
}