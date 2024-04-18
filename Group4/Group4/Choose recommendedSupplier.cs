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

    public partial class Choose_recommendedSupplier : Form
    {
        
        public int userName { get; set; }
        public MainMenu MM { get; set; }
     

        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public Choose_recommendedSupplier()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            
            MM.Show();
            this.Hide();

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            populateEmptyTable();
        }
        public void populateEmptyTable()
        {
       
            string query = "SELECT * FROM suppliers ; ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Price_btn_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT supplier,COUNT(*) AS OrderCount, AVG(CAST((priceRating) AS DECIMAL (10,2))) AS [Average price Rating]FROM Orders GROUP BY supplier order by [Average price Rating] desc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Quality_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT supplier,COUNT(*) AS OrderCount, AVG(CAST((qualityRating) AS DECIMAL (10,2))) AS [Average quality Rating] from orders GROUP BY supplier order by [Average quality Rating] desc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Supplytime_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT supplier,COUNT(*) AS OrderCount, AVG(CAST((supplyTimeRating) AS DECIMAL (10,2))) AS [Average supply Time Rating] FROM Orders GROUP BY supplier order by [Average supply Time Rating] desc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Overall_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT supplier,COUNT(*) AS OrderCount, CAST(AVG(CAST(order_avg_rating AS decimal (10,2))) AS DECIMAL (10,2)) AS [Average Rating] FROM (SELECT supplier, (priceRating + supplyTimeRating + qualityRating) / 3.0 AS order_avg_rating FROM Orders ) AS subquery GROUP BY supplier ORDER BY [Average Rating] DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Discount_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUPPLIER,[Average discount] = AVG(DISCOUNT) FROM Orders GROUP BY Supplier order by [Average discount] desc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Specialization_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = Specialization_ComboBox.Text;
            Console.WriteLine(search);
            string query = "select ID,specialization from dbo.Suppliers where specialization like '" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Suplliers_grid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void ViewSupllier_btn_Click(object sender, EventArgs e)
        {
            int rowindex = Suplliers_grid.CurrentCell.RowIndex;
            DataGridViewRow row = Suplliers_grid.Rows[rowindex];
            string o = row.Cells[0].Value.ToString();

            view_SupplierDetails SD = new view_SupplierDetails();
            SD.userName = this.userName;
            SD.ID = o;
            SD.cr = this;
            SD.Show();
            this.Hide();
        }

        private void Choose_recommendedSupplier_Load(object sender, EventArgs e)
        {
            populateEmptyTable();


        }
    }

}
