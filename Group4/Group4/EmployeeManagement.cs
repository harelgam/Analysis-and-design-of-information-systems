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

    public partial class EmployeeManagement : Form
    {
        public int userName { get; set; }
        public string fname { get; set; }
        public MainMenu MM { get; set; }

        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public EmployeeManagement()
        {
            InitializeComponent();
        }
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            this.employees1TableAdapter.Fill(this.sAD_4DataSet.Employees1);
            populateEmployeeTable();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            populateSearchTable();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            populateEmployeeTable();
        }
        private void AddEmployee_btn_Click(object sender, EventArgs e)//Add employee
        {
            AddEmployee ae = new AddEmployee();
            ae.userName = this.userName;
            ae.Em = this;
            ae.Show();
            this.Hide();
        }
        private void UpdateEmployee_btn_Click(object sender, EventArgs e)//Update employee
        {
            int rowindex = EmployeeGrid.CurrentCell.RowIndex;//update clicked task from grid
            DataGridViewRow row = EmployeeGrid.Rows[rowindex];
            int employeeUserName = int.Parse(row.Cells[0].Value.ToString());
            UpdateEmployee ue = new UpdateEmployee();
            ue.userName = this.userName;
            ue.employeeUserName = employeeUserName;
            ue.Em = this;
            ue.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)//delete employee
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowindex = EmployeeGrid.CurrentCell.RowIndex;
                    DataGridViewRow row = EmployeeGrid.Rows[rowindex];
                    Employee e1 = Program.seekEmployee(int.Parse(row.Cells[0].Value.ToString()));

                    e1.moveToArchive(e1);

                    this.populateEmployeeTable();

                }
                else
                {
                    MessageBox.Show("Operation not performed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException ex)
            {
            }
        }
        public void populateEmployeeTable()
        {
            string query = "select * from dbo.Employees where ManagerNum = '" + userName + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmployeeGrid.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void populateSearchTable()
        {
            string search = SearchEmployee.Text;
            string query = "select * from dbo.Employees where fname like '" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmployeeGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MM.Show();
        }

        private void EmployeeArchive_btn_Click(object sender, EventArgs e)
        {
            Employee_Archive EA = new Employee_Archive();
            EA.userName = this.userName;
            EA.Em = this;
            EA.Show();
            this.Hide();
        }
    }
}