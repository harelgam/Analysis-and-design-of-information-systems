using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class UpdateTask : Form
    {
        public TaskOperation taskO { get; set; }
        public Priority P;

        public int userName { get; set; }
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public UpdateTask()
        {
            InitializeComponent();
        }

        private void TasksGrig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTask_Load(object sender, EventArgs e)
        {
            populateTable();
        }
        public void populateTable()
        {
            //string userName2DB = userName.ToString();
            string query = "select * from dbo.Tasks where [Created for] = '" + userName + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TasksGrig.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = TasksGrig.CurrentCell.RowIndex;
            DataGridViewRow row = TasksGrig.Rows[rowindex];
           Task t = Program.seekTask(row.Cells[0].Value.ToString());
            
            
            string s = dateTimePicker1.Value.ToShortDateString();
            //DateTime dt = DateTime.ParseExact(s, "dd/mm/yyyy", null); 
            DateTime dt = DateTime.Parse(s);
            t.set_deadLine(dt);
            if ((comboBox1.Text.Equals("Lowpriority")) || (comboBox1.Text.Equals("Normal")) || (comboBox1.Text.Equals("Urgent")))
            {
                t.set_priority(P);
            }
            if (!richTextBox1.Text.Equals(""))
            {
                t.set_description(richTextBox1.Text);
            }
            if (!textBox3.Text.Equals(""))
            {
                t.set_status(textBox3.Text);
            } 
            t.set_cancellation_request((checkBox1.Checked));
            t.Update_task();
            MessageBox.Show("Update successful!");
            refreshData();
            taskO.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taskO.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
