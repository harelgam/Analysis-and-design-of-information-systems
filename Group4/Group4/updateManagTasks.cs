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
    public partial class UpdateManagTasks : Form
    {
        public TaskManagmentOperation TMO { get; set; }
       
        public int userName { get; set; }
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public UpdateManagTasks()
        {
            InitializeComponent();
        }

        private void updateManagTasks_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        public void populateTable()
        {

            string query = "select [fName],[lName],Tasks.[ID],[Created by],[Created for],[description],[deadline] ,[priority] from dbo.Employees join dbo.Tasks on Employees.[employeeNum] = Tasks.[Created for] where [ManagerNum] = '" + userName + "' and[Created by] ='" + userName + "' and [Created for] not in  ('" + userName + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }
        public void refreshData()
        {
            this.populateTable();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            Task t = Program.seekTask(row.Cells[2].Value.ToString());


            string s = dateTimePicker1.Value.ToShortDateString();
            //DateTime dt = DateTime.ParseExact(s, "dd/mm/yyyy", null);
            DateTime dt = DateTime.Parse(s);
            t.set_deadLine(dt);
            if ((comboBox1.Text.Equals("Lowpriority")) || (comboBox1.Text.Equals("Normal")) || (comboBox1.Text.Equals("Urgent")))
            {
                t.set_priority((Priority)Enum.Parse(typeof(Priority), comboBox1.Text));
            }
            if (!richTextBox1.Text.Equals(""))
            {
                t.set_description(richTextBox1.Text);
            }
            t.Update_task();
            refreshData();
            TMO.refreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TMO.Show();
            this.Hide();
        }

        private void TasksGrig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
