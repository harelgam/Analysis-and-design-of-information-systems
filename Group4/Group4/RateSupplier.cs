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

    public partial class RateSupplier : Form
    {
        public int userName { get; set; }
        public MainMenu mn { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public RateSupplier()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                SupplyTimeRate.Items.Add(i);
                QuallityRateBox.Items.Add(i);
                PriceRateBox.Items.Add(i);
            }
        }

        private void RateSupplier_Load(object sender, EventArgs e)
        {

            this.orders1TableAdapter.Fill(this.sAD_4DataSet.Orders1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populateTable()
        {
            string search = SearchBoxOrder.Text;
            string query = "select * from dbo.Orders where [ID] like '" + search + "%' AND arrived='1'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrdersGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void SearchBoxOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchOrder_btn_Click(object sender, EventArgs e)
        {
            populateTable();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }
        public void refreshData()
        {

            string query = "select * from dbo.Orders where arrived='1'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrdersGrid.DataSource = ds.Tables[0];
            conn.Close();
        }


        private void ApplyRate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = OrdersGrid.CurrentCell.RowIndex;
                DataGridViewRow row = OrdersGrid.Rows[rowindex];
                string orderID = row.Cells[0].Value.ToString();
                Order O = Program.seekOrder(orderID);

                // Validate that a value is selected for each ComboBox
                if (SupplyTimeRate.SelectedItem != null &&
                    QuallityRateBox.SelectedItem != null &&
                    PriceRateBox.SelectedItem != null)
                {
                    // Set the selected ratings from the ComboBoxes
                    O.set_supplyTimeRating(Convert.ToInt32(SupplyTimeRate.SelectedItem));
                    O.set_qualitylRating(Convert.ToInt32(QuallityRateBox.SelectedItem));
                    O.set_priceRating(Convert.ToInt32(PriceRateBox.SelectedItem));

                    O.Update_order();
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Please select a rating value for each category.");
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }


        private void SupplyTimeRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            mn.Show();
            this.Hide();
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}