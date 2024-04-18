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
    public partial class CreateManagTasks : Form
    {
        public int userName { get; set; }
        
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");

        public TaskManagmentOperation TMO { get; set; }
        public CreateManagTasks()
        {
            InitializeComponent();
        }

        private void CreateManagTasks_Load(object sender, EventArgs e)
        {
            populateTable();
        }
        public void populateTable()
        {

           string query = "select [fName],[lName],[employeeNum] from dbo.Employees  where [ManagerNum] = '" + userName + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            Employee e2 = Program.seekEmployee(int.Parse(row.Cells[2].Value.ToString()));

            if (Description.Text.Equals(""))
            {

                MessageBox.Show("Write Description please");

            }
            else if ((!comboBox1.Text.Equals("Lowpriority")) && (!comboBox1.Text.Equals("Normal")) && (!comboBox1.Text.Equals("Urgent")))
            {
                MessageBox.Show("Choose priority please");
            }
            else
            {
                Employee e1 = Program.seekEmployee(userName);

                string s = dateTimePicker1.Value.ToShortDateString();
                //DateTime dt = DateTime.ParseExact(s, "dd/mm/yyyy", null);
                DateTime dt = DateTime.Parse(s);
                Task t = new Task(" ",e1, e2, Description.Text, dt, " ", (Priority)Enum.Parse(typeof(Priority), comboBox1.Text), false, true);
                MessageBox.Show("The Task Successfully Registered");
                Description.Clear();
                comboBox1.Text = string.Empty;
                TMO.refreshData();
                this.Hide();
                TMO.Show();
            }
        }
            private void button3_Click(object sender, EventArgs e)
            {
                Description.Clear();
                comboBox1.Text = string.Empty;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            TMO.Show();
            this.Hide();
        }
    }

      
    }
