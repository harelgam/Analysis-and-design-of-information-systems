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
    public partial class Employee_Archive : Form
    {
        public int userName { get; set; }
        public EmployeeManagement Em { get; set; }
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public Employee_Archive()
        {
            InitializeComponent();
        }

        private void Employee_Archive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet.EmployeesArchive' table. You can move, or remove it, as needed.
            this.employeesArchiveTableAdapter.Fill(this.sAD_4DataSet.EmployeesArchive);

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Em.Show();
        }

        private void Revive_btn_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            int location = int.Parse(row.Cells[0].Value.ToString());
            Employee e1 = Program.seekEmployeeArchive(int.Parse(row.Cells[0].Value.ToString()));
            e1.voidreturnFromArchive(e1);
            MessageBox.Show("Employee returned from archive");
            this.populateEmployeeTable();
            Em.populateEmployeeTable();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            int location = int.Parse(row.Cells[0].Value.ToString());
            Employee e1 = Program.seekEmployeeArchive(int.Parse(row.Cells[0].Value.ToString()));
            e1.Delete_employeeArchive();
            MessageBox.Show("Employee deleted");
            this.populateEmployeeTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populateEmployeeTable()
        {
            string query = "select * from dbo.EmployeesArchive where ManagerNum = '" + userName + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
