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
    public partial class ItemsInHoldForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public int userName { get; set; }
        public GoodsOperation go { get; set; }

        public ItemsInHoldForm()
        {
            InitializeComponent();
        }

        private void ItemsInHoldForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet1.ItemsInOrder1' table. You can move, or remove it, as needed.
            this.itemsInOrder1TableAdapter.Fill(this.sAD_4DataSet1.ItemsInOrder1);
            // TODO: This line of code loads data into the 'sAD_4DataSet1.ItemsInOrder1' table. You can move, or remove it, as needed.
            this.itemsInOrder1TableAdapter.Fill(this.sAD_4DataSet1.ItemsInOrder1);
            // TODO: This line of code loads data into the 'sAD_4DataSet.ItemsInOrder1' table. You can move, or remove it, as needed.
            this.itemsInOrder1TableAdapter.Fill(this.sAD_4DataSet.ItemsInOrder1);
            // TODO: This line of code loads data into the 'sAD_4DataSet.Items1' table. You can move, or remove it, as needed.
            this.items1TableAdapter.Fill(this.sAD_4DataSet.Items1);
            populate();
        }

        public void populate()
        {
            string query = "select [order],item,quantity from dbo.ItemsInOrder where [inhold] = 1";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ItemsInHoldGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        public void refreshData()
        {
            populate();
        }


        private void ItemsInHoldGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            go.Show();
            this.Hide();
        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = ItemsInHoldGrid.CurrentCell.RowIndex;
                DataGridViewRow row = ItemsInHoldGrid.Rows[rowindex];

                string o = row.Cells[0].Value.ToString();
                int i = int.Parse(row.Cells[1].Value.ToString());
                ItemInOrder it = Program.seekItemsInOrderem(o, i);

                it.removeFromHold();
                it.Update_itemInOrder();

                MessageBox.Show("The items removed from order!");
                refreshData();

            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
}
