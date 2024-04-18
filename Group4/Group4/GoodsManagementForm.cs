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
    public partial class GoodsManagementForm : Form
    {
        public int userName { get; set; }
        public MainMenu mn { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public GoodsManagementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GoodsManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_4DataSet.Items1' table. You can move, or remove it, as needed.
            this.items1TableAdapter.Fill(this.sAD_4DataSet.Items1);
            Role r = Program.seekEmployee(userName).get_role();

            if (r != Role.CEO && r != Role.WhearhouseManager && r != Role.ProcuementManager)
            {
                UpdateItem_btn.Visible = false;
                CreateItem_btn.Visible = false;
                Delete_btn.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewItems_btn_Click(object sender, EventArgs e)
        {
            ViewItemsForm vi = new ViewItemsForm();
            vi.gm = this;
            vi.userName = this.userName;
            vi.Show();
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            mn.Show();
            this.Hide();
        }

        private void CreateItem_btn_Click(object sender, EventArgs e)
        {
            CreateItemForm ci = new CreateItemForm();
            ci.userName = this.userName;
            ci.gmf = this;
            ci.Show();
            this.Hide();
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


        private void ItemsGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DeleteItemForm di = new DeleteItemForm();
            di.userName = this.userName;
            di.gm = this;
            di.Show();
            this.Hide();
        }

        private void UpdateItem_btn_Click(object sender, EventArgs e)
        {
            int rowindex = ItemsGridView1.CurrentCell.RowIndex;//update clicked task from grid
            DataGridViewRow row = ItemsGridView1.Rows[rowindex];
            int serialNum = int.Parse(row.Cells[0].Value.ToString());
            UpdateItemForm ui = new UpdateItemForm();
            ui.userName = this.userName;
            ui.gm = this;
            ui.serialNum = serialNum;
            ui.Show();
            this.Hide();
        }
    }
}
