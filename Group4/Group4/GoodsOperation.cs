using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class GoodsOperation : Form
    {
        public int userName { get; set; }
        public MainMenu mn { get; set; }
        public GoodsOperation()
        {
            InitializeComponent();       
        }

        private void InsertGoods_btn_Click(object sender, EventArgs e)
        {
            InsertItemsForm it = new InsertItemsForm();
            it.go = this;
            it.userName = this.userName;
            it.Show();
            this.Hide();
        }

        private void GoodsOperation_Load(object sender, EventArgs e)
        {
            Role r = Program.seekEmployee(userName).get_role();

            if (r != Role.CEO && r != Role.StoreKeeper && r != Role.WhearhouseManager)
            {
                InsertGoods_btn.Visible = false;
            }

            if (r != Role.WhearhouseManager && r!=Role.CEO && r!=Role.ProcuementManager)
            {
                ApproveItemsInHold_btn.Visible = false;
            }


        }

        private void ApproveItemsInHold_btn_Click(object sender, EventArgs e)
        {
            ItemsInHoldForm iih = new ItemsInHoldForm();
            iih.userName = this.userName;
            iih.go = this;
            iih.Show();
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            mn.Show();
            this.Hide();
        }


    }
}
