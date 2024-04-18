using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class TaskManagmentOperation : Form
    {
        public int userName { get; set; }
        public TaskOperation t1 { get; set; }
        //CreateTask CreateSelfTask = new CreateTask();

        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public TaskManagmentOperation()
        {
            InitializeComponent();
        }

        private void TasksGrig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaskManagmentOperation_Load(object sender, EventArgs e)
        {
            populateTable();

        }
        public void populateTable()
        {

           
            string query = "select [fName],[lName],Tasks.[ID],[Created by],[Created for],[description],[deadline],[status] ,[priority],[cancellationrequest] from dbo.Employees join dbo.Tasks on Employees.[employeeNum] = Tasks.[Created for] where [ManagerNum] = '" + userName + "' and[Created by] ='" + userName + "' and [Created for] not in  ('" + userName + "')"; 
         SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TasksGrig.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Show();
            this.Hide();
        }

        private void CreateTask_btn_Click(object sender, EventArgs e)
        {
            CreateManagTasks createManagTasks = new CreateManagTasks();
            createManagTasks.userName = userName;
            createManagTasks.TMO = this;
            createManagTasks.Show();
            this.Hide();



        }

        private void DeleteTask_btn_Click(object sender, EventArgs e)
        {
            int rowindex = TasksGrig.CurrentCell.RowIndex;
            DataGridViewRow row = TasksGrig.Rows[rowindex];

            if (MessageBox.Show("Are You Sure?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Task t = Program.seekTask(row.Cells[2].Value.ToString());
                t.Delete_task();
                this.refreshData();
            }
            else
            {
                MessageBox.Show("Operation not performed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void refreshData()
        {
           this.populateTable();


        }

        private void UpdateTask_btn_Click(object sender, EventArgs e)
        {
           
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateManagTasks u1 = new UpdateManagTasks();
            u1.TMO = this;
            u1.userName = userName;
            u1.Show();
            this.Hide();
        }
    }
}
