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
    public partial class view_SupplierDetails : Form
    {
        public string ID { get; set; }
        public int userName { get; set; }
        public MainMenu MM { get; set; }
        public Choose_recommendedSupplier cr { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public view_SupplierDetails()
        {
            InitializeComponent();
        }

        private void Details_ViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void view_SupplierDetails_Load(object sender, EventArgs e)
        {
            populateTable();
        }
        public void populateTable()
        {
            string query = "select * from dbo.Suppliers where [ID] = '" + ID + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Details_ViewGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            cr.Show();
        }
    }
}
