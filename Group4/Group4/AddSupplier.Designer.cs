namespace Group4
{
    partial class AddSupplier
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
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Adress_textBox = new System.Windows.Forms.TextBox();
            this.Spec_textbox = new System.Windows.Forms.ComboBox();
            this.AddToSuppliers_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Specialization = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(499, 131);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(100, 20);
            this.ID_textBox.TabIndex = 0;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(499, 167);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Name_textbox.TabIndex = 1;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(499, 203);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(100, 20);
            this.Email_textbox.TabIndex = 2;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(499, 238);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(100, 20);
            this.Phone_textbox.TabIndex = 3;
            // 
            // Adress_textBox
            // 
            this.Adress_textBox.Location = new System.Drawing.Point(499, 274);
            this.Adress_textBox.Name = "Adress_textBox";
            this.Adress_textBox.Size = new System.Drawing.Size(100, 20);
            this.Adress_textBox.TabIndex = 4;
            // 
            // Spec_textbox
            // 
            this.Spec_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spec_textbox.FormattingEnabled = true;
            this.Spec_textbox.Items.AddRange(new object[] {
            "construction materials",
            "electronic components",
            "it services",
            "logistics provider",
            "packaging",
            "printing and publishing",
            "raw materials"});
            this.Spec_textbox.Location = new System.Drawing.Point(499, 309);
            this.Spec_textbox.Name = "Spec_textbox";
            this.Spec_textbox.Size = new System.Drawing.Size(100, 21);
            this.Spec_textbox.TabIndex = 5;
            // 
            // AddToSuppliers_btn
            // 
            this.AddToSuppliers_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddToSuppliers_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSuppliers_btn.ForeColor = System.Drawing.Color.White;
            this.AddToSuppliers_btn.Location = new System.Drawing.Point(341, 358);
            this.AddToSuppliers_btn.Name = "AddToSuppliers_btn";
            this.AddToSuppliers_btn.Size = new System.Drawing.Size(102, 45);
            this.AddToSuppliers_btn.TabIndex = 6;
            this.AddToSuppliers_btn.Text = "Add supplier";
            this.AddToSuppliers_btn.UseVisualStyleBackColor = false;
            this.AddToSuppliers_btn.Click += new System.EventHandler(this.AddToSuppliers_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add Supplier";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(542, 397);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 19;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(337, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(337, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(337, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(337, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adress";
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.BackColor = System.Drawing.Color.Transparent;
            this.Specialization.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization.ForeColor = System.Drawing.Color.White;
            this.Specialization.Location = new System.Drawing.Point(337, 311);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(109, 19);
            this.Specialization.TabIndex = 21;
            this.Specialization.Text = "Specialization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.AddSupplierForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddToSuppliers_btn);
            this.Controls.Add(this.Spec_textbox);
            this.Controls.Add(this.Adress_textBox);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.ID_textBox);
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.TextBox Adress_textBox;
        private System.Windows.Forms.ComboBox Spec_textbox;
        private System.Windows.Forms.Button AddToSuppliers_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label label1;
    }
}