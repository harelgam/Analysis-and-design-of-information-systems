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
    public partial class TaskOperation : Form
    {
        public int userName { get; set; }
        public MainMenu M1 { get; set; }
CreateTask CreateSelfTask = new CreateTask();

         public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public TaskOperation()
        {
            InitializeComponent();
        }
        private void TaskOperation_Load(object sender, EventArgs e)//data grid
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet2.Tasks1' table. You can move, or remove it, as needed.
            this.tasks1TableAdapter.Fill(this.sAD_4DataSet2.Tasks1);
            // TODO: This line of code loads data into the 'sAD_4DataSet1.Tasks1' table. You can move, or remove it, as needed.
            this.tasks1TableAdapter.Fill(this.sAD_4DataSet1.Tasks1);
            // TODO: This line of code loads data into the 'sAD_4DataSet1.Get_all_Tasks' table. You can move, or remove it, as needed.
            this.get_all_TasksTableAdapter.Fill(this.sAD_4DataSet1.Get_all_Tasks);
            refreshData();
            this.tasks1TableAdapter.Fill(this.sAD_4DataSet.Tasks1);
            populateTable();
            CreateSelfTask.userName = this.userName;

          

            SqlCommand c = new SqlCommand();
            c.CommandText = "select count(*) from dbo.Employees where [ManagerNum] = '" + userName + "'";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            rdr.Read();
            int num = int.Parse(rdr.GetValue(0).ToString());
            if (num == 0)
            {
                button2.Hide();
            }
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateSelfTask.Show();
            CreateSelfTask.taskO = this;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // populateTable();//inserts all the tasks from DB for the employee.
        }

        public void populateTable()
        {

            //select count(*) from Employees where [ManagerNum]= 8179
            string query = "select * from dbo.Tasks where [Created for] = '" + userName + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TasksGrig.DataSource = ds.Tables[0];
                conn.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = TasksGrig.CurrentCell.RowIndex;
            DataGridViewRow row = TasksGrig.Rows[rowindex];
            if (userName == int.Parse(row.Cells[1].Value.ToString()))
            {
                if (MessageBox.Show("Are You Sure?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Task t = Program.seekTask(row.Cells[0].Value.ToString());
                    t.Delete_task();
                    this.refreshData();
                }
                else
                {
                    MessageBox.Show("Operation not performed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           else
            {
                MessageBox.Show("You Have No Authority, You May update your Cancelation Request and wait for your manager respond");
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            M1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
        }

        private void UpdateTask_btn_Click(object sender, EventArgs e)
        {
            UpdateTask updateTask = new UpdateTask();
            updateTask.userName = this.userName;
            updateTask.taskO = this;
            updateTask.Show();
            this.Hide();
        }
        public void refreshData()
        {
         
                string query = "select * from dbo.Tasks where [Created for] = '" + userName + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TasksGrig.DataSource = ds.Tables[0];
                conn.Close();
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            TaskManagmentOperation TaskManagmentOperation = new TaskManagmentOperation();
            TaskManagmentOperation.userName = this.userName;
            TaskManagmentOperation.t1 = this;
            TaskManagmentOperation.Show();
            this.Hide();
        }
    }

}
