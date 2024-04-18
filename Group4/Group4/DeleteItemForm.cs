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
    public partial class DeleteItemForm : Form
    {
        public int userName { get; set; }
        public GoodsManagementForm gm;
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");

        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet.Items1' table. You can move, or remove it, as needed.
            this.items1TableAdapter.Fill(this.sAD_4DataSet.Items1);

        }

        public void populateTable()
        {
            string search = SerialNumber_textbox.Text;
            int serialNumber;

            if (!int.TryParse(search, out serialNumber))
            {
                MessageBox.Show("Write valid serialNumber please");
            }
            else
            {
                string query = "select * from dbo.Items where [serial_number] = '" + search + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ItemsGrid.DataSource = ds.Tables[0];
                conn.Close();
            }

        }

        public void refreshData()
        {
            string query = "select * from dbo.Items";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ItemsGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            populateTable();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            gm.refreshData();
            gm.Show();
            this.Hide();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = ItemsGrid.CurrentCell.RowIndex;
                DataGridViewRow row = ItemsGrid.Rows[rowindex];
                Item i = Program.seekItem(int.Parse(row.Cells[0].Value.ToString()));
                int num = i.get_serial_number();
                string query = "SELECT * FROM ItemsInOrder WHERE [item] = '" + num + "'";

                // Execute the query to check if any rows are returned
                bool hasItemsInOrder;
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    hasItemsInOrder = reader.HasRows;
                }

                if (hasItemsInOrder)
                {
                    MessageBox.Show("You can't delete an item that has been used.");
                }
                else
                {
                    i.Delete_item();
                    MessageBox.Show("The item has been deleted.");
                    refreshData();
                    gm.refreshData();
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }

        private void SerialNumber_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}