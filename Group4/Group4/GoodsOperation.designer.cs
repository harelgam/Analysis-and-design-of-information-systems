namespace Group4
{
    partial class GoodsOperation
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
            this.InsertGoods_btn = new System.Windows.Forms.Button();
            this.ApproveItemsInHold_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertGoods_btn
            // 
            this.InsertGoods_btn.BackColor = System.Drawing.Color.Black;
            this.InsertGoods_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertGoods_btn.ForeColor = System.Drawing.Color.White;
            this.InsertGoods_btn.Location = new System.Drawing.Point(20, 120);
            this.InsertGoods_btn.Name = "InsertGoods_btn";
            this.InsertGoods_btn.Size = new System.Drawing.Size(159, 57);
            this.InsertGoods_btn.TabIndex = 0;
            this.InsertGoods_btn.Text = "Insert goods";
            this.InsertGoods_btn.UseVisualStyleBackColor = false;
            this.InsertGoods_btn.Click += new System.EventHandler(this.InsertGoods_btn_Click);
            // 
            // ApproveItemsInHold_btn
            // 
            this.ApproveItemsInHold_btn.BackColor = System.Drawing.Color.Black;
            this.ApproveItemsInHold_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveItemsInHold_btn.ForeColor = System.Drawing.Color.White;
            this.ApproveItemsInHold_btn.Location = new System.Drawing.Point(215, 120);
            this.ApproveItemsInHold_btn.Name = "ApproveItemsInHold_btn";
            this.ApproveItemsInHold_btn.Size = new System.Drawing.Size(159, 57);
            this.ApproveItemsInHold_btn.TabIndex = 1;
            this.ApproveItemsInHold_btn.Text = "Approve items in hold";
            this.ApproveItemsInHold_btn.UseVisualStyleBackColor = false;
            this.ApproveItemsInHold_btn.Click += new System.EventHandler(this.ApproveItemsInHold_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Black;
            this.Back_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(20, 293);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(80, 30);
            this.Back_btn.TabIndex = 2;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goods operation";
            // 
            // GoodsOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group4.Properties.Resources.goodsOperation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.ApproveItemsInHold_btn);
            this.Controls.Add(this.InsertGoods_btn);
            this.Name = "GoodsOperation";
            this.Text = "GoodsOperation";
            this.Load += new System.EventHandler(this.GoodsOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertGoods_btn;
        private System.Windows.Forms.Button ApproveItemsInHold_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label1;
    }
}