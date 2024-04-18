namespace Group4
{
    partial class TaskManagmentOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteTask_btn = new System.Windows.Forms.Button();
            this.CreateTask_btn = new System.Windows.Forms.Button();
            this.TasksGrig = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tasks Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(753, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteTask_btn
            // 
            this.DeleteTask_btn.BackColor = System.Drawing.Color.Black;
            this.DeleteTask_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteTask_btn.Location = new System.Drawing.Point(574, 298);
            this.DeleteTask_btn.Name = "DeleteTask_btn";
            this.DeleteTask_btn.Size = new System.Drawing.Size(85, 23);
            this.DeleteTask_btn.TabIndex = 8;
            this.DeleteTask_btn.Text = "Delete Task";
            this.DeleteTask_btn.UseVisualStyleBackColor = false;
            this.DeleteTask_btn.Click += new System.EventHandler(this.DeleteTask_btn_Click);
            // 
            // CreateTask_btn
            // 
            this.CreateTask_btn.BackColor = System.Drawing.Color.Black;
            this.CreateTask_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTask_btn.ForeColor = System.Drawing.Color.White;
            this.CreateTask_btn.Location = new System.Drawing.Point(45, 298);
            this.CreateTask_btn.Name = "CreateTask_btn";
            this.CreateTask_btn.Size = new System.Drawing.Size(82, 23);
            this.CreateTask_btn.TabIndex = 7;
            this.CreateTask_btn.Text = "Create Task";
            this.CreateTask_btn.UseVisualStyleBackColor = false;
            this.CreateTask_btn.Click += new System.EventHandler(this.CreateTask_btn_Click);
            // 
            // TasksGrig
            // 
            this.TasksGrig.BackgroundColor = System.Drawing.Color.White;
            this.TasksGrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGrig.Location = new System.Drawing.Point(22, 48);
            this.TasksGrig.Name = "TasksGrig";
            this.TasksGrig.Size = new System.Drawing.Size(859, 235);
            this.TasksGrig.TabIndex = 6;
            this.TasksGrig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGrig_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(307, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update Task";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TaskManagmentOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Group4.Properties.Resources.managerTaskPic;
            this.ClientSize = new System.Drawing.Size(901, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteTask_btn);
            this.Controls.Add(this.CreateTask_btn);
            this.Controls.Add(this.TasksGrig);
            this.Name = "TaskManagmentOperation";
            this.Text = "TaskManagmentOperation";
            this.Load += new System.EventHandler(this.TaskManagmentOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteTask_btn;
        private System.Windows.Forms.Button CreateTask_btn;
        private System.Windows.Forms.DataGridView TasksGrig;
        private System.Windows.Forms.Button button2;
    }
}