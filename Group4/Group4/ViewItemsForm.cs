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
    public partial class ViewItemsForm : Form
    {
        public int userName { get; set; }
        public GoodsManagementForm gm;
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public ViewItemsForm()
        {
            InitializeComponent();
        }

        private void ViewItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet1.Items1' table. You can move, or remove it, as needed.
            this.items1TableAdapter.Fill(this.sAD_4DataSet1.Items1);
            // TODO: This line of code loads data into the 'sAD_4DataSet.Items1' table. You can move, or remove it, as needed.
            this.items1TableAdapter.Fill(this.sAD_4DataSet.Items1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void populateTable()
        {
            string search = SerialNumber_textbox.Text;

            int serialNumber;
            if (int.TryParse(search, out serialNumber))
            {
                string query = "select * from dbo.Items where [serial_number] = '" + search + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ItemsGridView1.DataSource = ds.Tables[0];
            }


            conn.Close();
        }


        public void refreshData()
        {

            string query = "select * from dbo.Items";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ItemsGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            gm.Show();
            this.Hide();
        }

        private void SerialNumber_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchItem_btn_Click(object sender, EventArgs e)
        {
            populateTable();
        }
    }
}