namespace Group4
{
    partial class LoginMenu
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CLEAR_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Black;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(100, 186);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(203, 29);
            this.txt_password.TabIndex = 14;
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.Black;
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.ForeColor = System.Drawing.Color.White;
            this.txt_userName.Location = new System.Drawing.Point(100, 99);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(203, 29);
            this.txt_userName.TabIndex = 13;
            this.txt_userName.TextChanged += new System.EventHandler(this.txt_userName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 57);
            this.label3.TabIndex = 12;
            this.label3.Text = "welcome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CLEAR_btn
            // 
            this.CLEAR_btn.BackColor = System.Drawing.Color.Black;
            this.CLEAR_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_btn.ForeColor = System.Drawing.Color.White;
            this.CLEAR_btn.Location = new System.Drawing.Point(38, 322);
            this.CLEAR_btn.Name = "CLEAR_btn";
            this.CLEAR_btn.Size = new System.Drawing.Size(82, 27);
            this.CLEAR_btn.TabIndex = 9;
            this.CLEAR_btn.Text = "Clear";
            this.CLEAR_btn.UseVisualStyleBackColor = false;
            this.CLEAR_btn.Click += new System.EventHandler(this.CLEAR_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Black;
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Login_btn.Location = new System.Drawing.Point(200, 267);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(111, 28);
            this.Login_btn.TabIndex = 8;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Group4.Properties.Resources.login_menu_vector_25951661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(382, 373);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLEAR_btn);
            this.Controls.Add(this.Login_btn);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CLEAR_btn;
        private System.Windows.Forms.Button Login_btn;
    }
}