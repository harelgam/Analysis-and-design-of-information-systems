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
    public partial class ItemsInOrderForm : Form
    {
        public string order { get; set; }
        public int userName { get; set; }
        public InsertItemsForm ii { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");

        public ItemsInOrderForm()
        {
            InitializeComponent();
        }

        private void ItemsInOrderForm_Load(object sender, EventArgs e)
        {
            populateByOrderClick();
        }




        public void populateByOrderClick()
        {
            string query = "select [order],item,quantity from dbo.ItemsInOrder where [order] = '" + order + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            GridItemsInOrder.DataSource = ds.Tables[0];
            conn.Close();
        }



        private void GridItemsInOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ii.Show();
            this.Hide();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Program.seekOrder(this.order).set_arrived(true);
            Program.seekOrder(this.order).Update_order();

            int checkIfGap = 0;

            foreach (DataGridViewRow row in GridItemsInOrder.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Check if the checkbox in the row is selected
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                    bool isChecked = Convert.ToBoolean(checkBoxCell.Value);


                    int item = int.Parse(row.Cells[2].Value.ToString());

                    ItemInOrder ItemInOrder = Program.seekItemsInOrderem(this.order, item);


                    if (isChecked)
                    {
                        checkIfGap++;
                        ItemInOrder.insertToHold();
                    }
                    else
                    {
                        ItemInOrder.addToStock();
                    }

                    ItemInOrder.Update_itemInOrder();
                    ItemInOrder.get_item().Update_item();
                }
            }

            if (checkIfGap > 0)
            {
                ReasonForHoldForm rfh = new ReasonForHoldForm();
                rfh.orderWithHold = order;
                rfh.userName = this.userName;
                rfh.ii = this.ii;
                rfh.Show();
                this.Hide();
            }
            else
            {
                ii.refreshData();
                ii.Show();
                this.Hide();
            }
        }

        


    }
}
