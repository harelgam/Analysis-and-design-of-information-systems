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
    public partial class SupplierManagementcs : Form
    {
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public int userName { get; set; }
        public MainMenu mn { get; set; }
        public SupplierManagementcs()
        {
            InitializeComponent();
        }

        private void SupplierManagementcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet.Suppliers1' table. You can move, or remove it, as needed.
            this.suppliers1TableAdapter.Fill(this.sAD_4DataSet.Suppliers1);

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mn.Show();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from dbo.Suppliers";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            suppliers_datagrid.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void populateTable()
        {
            string query = "select * from dbo.Suppliers";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            suppliers_datagrid.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void populateSearchTable()
        {
            try
            {
                string search = searchSupplier_textbox.Text;
                string query = "select * from dbo.Suppliers where name like '" + search + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                suppliers_datagrid.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (NullReferenceException ex)
            {

            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            populateSearchTable();
        }

        private void AddSupplier_btn_Click(object sender, EventArgs e)
        {
            int rowindex = suppliers_datagrid.CurrentCell.RowIndex;//update clicked task from grid
            DataGridViewRow row = suppliers_datagrid.Rows[rowindex];
            string SupplierID = row.Cells[0].Value.ToString();
            AddSupplier addsup = new AddSupplier();
            addsup.SupplierID = SupplierID;
            addsup.sm = this;
            addsup.Show();
            this.Hide();

        }


        private void UpdateSupplier_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = suppliers_datagrid.CurrentCell.RowIndex;//update clicked task from grid
                DataGridViewRow row = suppliers_datagrid.Rows[rowindex];
                string SupplierID = row.Cells[0].Value.ToString();
                UpdateSupplier upSup = new UpdateSupplier();
                upSup.userName = this.userName;
                upSup.SupplierID = SupplierID;
                upSup.sm = this;
                upSup.Show();
                this.Hide();
            }
            catch (NullReferenceException ex)
            {

            }

        }

        private void DeleateSupplier_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = suppliers_datagrid.CurrentCell.RowIndex;
                DataGridViewRow row = suppliers_datagrid.Rows[rowindex];
                Supplier s = Program.seekSupplier(row.Cells[0].Value.ToString());
                string SupplierID = s.get_ID();
                string query = "SELECT * FROM Orders WHERE [supplier] = '" + SupplierID + "'";

                // Execute the query to check if any rows are returned
                bool hasOrders;
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    hasOrders = reader.HasRows;
                }

                if (hasOrders)
                {
                    MessageBox.Show("You can't delete a supplier that appears in an order.");
                }
                else
                {
                    if (MessageBox.Show("Are You Sure?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        s.Delete_supplier();
                        MessageBox.Show("Supplier deleted");
                        this.populateTable();
                    }
                    else
                    {
                        MessageBox.Show("Operation not performed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (NullReferenceException ex)
            {

            }

        }

        private void searchSupplier_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}