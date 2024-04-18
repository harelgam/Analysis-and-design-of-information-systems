namespace Group4
{
    partial class TaskOperation
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
            this.TasksGrig = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasks1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet2 = new Group4.SAD_4DataSet();
            this.tasks1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_4DataSet = new Group4.SAD_4DataSet();
            this.CreateTask_btn = new System.Windows.Forms.Button();
            this.DeleteTask_btn = new System.Windows.Forms.Button();
            this.UpdateTask_btn = new System.Windows.Forms.Button();
            this.tasks1TableAdapter = new Group4.SAD_4DataSetTableAdapters.Tasks1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sAD_4DataSet1 = new Group4.SAD_4DataSet();
            this.getallTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_all_TasksTableAdapter = new Group4.SAD_4DataSetTableAdapters.Get_all_TasksTableAdapter();
            this.tasks1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksGrig
            // 
            this.TasksGrig.AutoGenerateColumns = false;
            this.TasksGrig.BackgroundColor = System.Drawing.Color.White;
            this.TasksGrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGrig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.createdForDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn});
            this.TasksGrig.DataSource = this.tasks1BindingSource2;
            this.TasksGrig.Location = new System.Drawing.Point(154, 51);
            this.TasksGrig.Name = "TasksGrig";
            this.TasksGrig.Size = new System.Drawing.Size(745, 235);
            this.TasksGrig.TabIndex = 0;
            this.TasksGrig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "Created by";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Created by";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // createdForDataGridViewTextBoxColumn
            // 
            this.createdForDataGridViewTextBoxColumn.DataPropertyName = "Created for";
            this.createdForDataGridViewTextBoxColumn.HeaderText = "Created for";
            this.createdForDataGridViewTextBoxColumn.Name = "createdForDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "deadline";
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // tasks1BindingSource2
            // 
            this.tasks1BindingSource2.DataMember = "Tasks1";
            this.tasks1BindingSource2.DataSource = this.sAD_4DataSet2;
            // 
            // sAD_4DataSet2
            // 
            this.sAD_4DataSet2.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasks1BindingSource
            // 
            this.tasks1BindingSource.DataMember = "Tasks1";
            this.tasks1BindingSource.DataSource = this.sAD_4DataSet;
            // 
            // sAD_4DataSet
            // 
            this.sAD_4DataSet.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateTask_btn
            // 
            this.CreateTask_btn.BackColor = System.Drawing.Color.Black;
            this.CreateTask_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTask_btn.ForeColor = System.Drawing.Color.White;
            this.CreateTask_btn.Location = new System.Drawing.Point(12, 97);
            this.CreateTask_btn.Name = "CreateTask_btn";
            this.CreateTask_btn.Size = new System.Drawing.Size(121, 34);
            this.CreateTask_btn.TabIndex = 1;
            this.CreateTask_btn.Text = "Create Self Task";
            this.CreateTask_btn.UseVisualStyleBackColor = false;
            this.CreateTask_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteTask_btn
            // 
            this.DeleteTask_btn.BackColor = System.Drawing.Color.Black;
            this.DeleteTask_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteTask_btn.Location = new System.Drawing.Point(12, 229);
            this.DeleteTask_btn.Name = "DeleteTask_btn";
            this.DeleteTask_btn.Size = new System.Drawing.Size(121, 34);
            this.DeleteTask_btn.TabIndex = 2;
            this.DeleteTask_btn.Text = "Delete Self Task";
            this.DeleteTask_btn.UseVisualStyleBackColor = false;
            this.DeleteTask_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateTask_btn
            // 
            this.UpdateTask_btn.BackColor = System.Drawing.Color.Black;
            this.UpdateTask_btn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTask_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateTask_btn.Location = new System.Drawing.Point(12, 162);
            this.UpdateTask_btn.Name = "UpdateTask_btn";
            this.UpdateTask_btn.Size = new System.Drawing.Size(134, 35);
            this.UpdateTask_btn.TabIndex = 3;
            this.UpdateTask_btn.Text = "Update Self Task";
            this.UpdateTask_btn.UseVisualStyleBackColor = false;
            this.UpdateTask_btn.Click += new System.EventHandler(this.UpdateTask_btn_Click);
            // 
            // tasks1TableAdapter
            // 
            this.tasks1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(820, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tasks Details";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // sAD_4DataSet1
            // 
            this.sAD_4DataSet1.DataSetName = "SAD_4DataSet";
            this.sAD_4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getallTasksBindingSource
            // 
            this.getallTasksBindingSource.DataMember = "Get_all_Tasks";
            this.getallTasksBindingSource.DataSource = this.sAD_4DataSet1;
            // 
            // get_all_TasksTableAdapter
            // 
            this.get_all_TasksTableAdapter.ClearBeforeFill = true;
            // 
            // tasks1BindingSource1
            // 
            this.tasks1BindingSource1.DataMember = "Tasks1";
            this.tasks1BindingSource1.DataSource = this.sAD_4DataSet1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Your Employees\' Tasks";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // TaskOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Group4.Properties.Resources.TaskOperationMenu;
            this.ClientSize = new System.Drawing.Size(911, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateTask_btn);
            this.Controls.Add(this.DeleteTask_btn);
            this.Controls.Add(this.CreateTask_btn);
            this.Controls.Add(this.TasksGrig);
            this.Name = "TaskOperation";
            this.Text = "Tasks Data";
            this.Load += new System.EventHandler(this.TaskOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TasksGrig;
        private System.Windows.Forms.Button CreateTask_btn;
        private System.Windows.Forms.Button DeleteTask_btn;
        private System.Windows.Forms.Button UpdateTask_btn;
        private SAD_4DataSet sAD_4DataSet;
        private System.Windows.Forms.BindingSource tasks1BindingSource;
        private SAD_4DataSetTableAdapters.Tasks1TableAdapter tasks1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private SAD_4DataSet sAD_4DataSet1;
        private System.Windows.Forms.BindingSource getallTasksBindingSource;
        private SAD_4DataSetTableAdapters.Get_all_TasksTableAdapter get_all_TasksTableAdapter;
        private System.Windows.Forms.BindingSource tasks1BindingSource1;
        private SAD_4DataSet sAD_4DataSet2;
        private System.Windows.Forms.BindingSource tasks1BindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
    }
}