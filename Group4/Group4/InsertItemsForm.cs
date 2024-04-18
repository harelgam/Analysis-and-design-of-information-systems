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
    public partial class InsertItemsForm : Form
    {
       public  GoodsOperation go;
        public int userName { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");

        public InsertItemsForm()
        {
            InitializeComponent();
        }

        private void InsertItemsForm_Load(object sender, EventArgs e)
        {
            populateTable();
            // TODO: This line of code loads data into the 'sAD_4DataSet.Orders1' table. You can move, or remove it, as needed.
            this.orders1TableAdapter.Fill(this.sAD_4DataSet.Orders1);

        }


        public void populateTable()
        {
            string query = "select * from dbo.Orders WHERE arrived = '" + 0 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrderGridForSk.DataSource = ds.Tables[0];
            conn.Close();
        }

        public void populateBySearch()
        {
            string search = Order_textbox.Text;
            string query = "select * from dbo.Orders where [ID] = '" + search + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrderGridForSk.DataSource = ds.Tables[0];
            conn.Close();
        }

        public void refreshData()
        {

            string query = "select * from dbo.Orders WHERE arrived = '" + 0 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrderGridForSk.DataSource = ds.Tables[0];
            conn.Close();
        }



   

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void Back_bt_Click(object sender, EventArgs e)
        {
            go.Show();
            this.Hide();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            populateBySearch();
        }

        private void Order_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowItems_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = OrderGridForSk.CurrentCell.RowIndex;

                DataGridViewRow row = OrderGridForSk.Rows[rowindex];


                string o = row.Cells[0].Value.ToString();

                ItemsInOrderForm Ii = new ItemsInOrderForm();
                Ii.userName = this.userName;
                Ii.order = o;
                Ii.ii = this;
                Ii.Show();
                this.Hide();
            }
            catch (NullReferenceException ex)
            {

            }


        }

        private void OrderGridForSk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
