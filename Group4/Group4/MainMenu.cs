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
    
    public partial class MainMenu : Form
    {
        public LoginMenu loginMenu;
        public string fname { get; set; }
        public string lname { get; set; }
        public int userName { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            name_lab.Text = fname;
            lastName.Text = lname;

            Role r = Program.seekEmployee(userName).get_role();
            if (r != Role.CEO && r != Role.CIO && r != Role.FinanceManager && r != Role.ProcuementManager && r != Role.ProductionManager && r != Role.WhearhouseManager)
            {
                employee_btn.Visible = false;
                pictureBox3.Visible = false;
            }
            if (r != Role.CEO && r != Role.ProcuementManager)
            {
                SupplierManagement_btn.Visible = false;
                pictureBox4.Visible = false;
                RecommendedSupplier_btn.Visible = false;
                pictureBox5.Visible = false;
                RecommendedSupplier_btn.Visible = false;
            }
            if (r != Role.CEO && r != Role.StoreKeeper && r != Role.WhearhouseManager && r != Role.ProcuementManager)
            {
                goods_btn.Visible = false;
                pictureBox2.Visible = false;
            }
            if (r != Role.CEO && r != Role.StoreKeeper && r != Role.WhearhouseManager && r != Role.ProcuementManager)
            {
                GoodsOperatiob_btn.Visible = false;
                pictureBox7.Visible = false;
            }
            if (r != Role.CEO && r != Role.ProcuementManager)
            {
                RateSupplier_btn.Visible = false;
                pictureBox6.Visible = false;
            }

        }

        private void taskOperation_btn_Click(object sender, EventArgs e)
        {
            TaskOperation TaskOperation = new TaskOperation();
            TaskOperation.userName = this.userName;
            TaskOperation.Show();
            TaskOperation.M1 = this;
            this.Hide();

        }

        private void name_lab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu lm = new LoginMenu();
            loginMenu.Show();
            this.Hide();

        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            EmployeeManagement Em = new EmployeeManagement();
            Em.userName = this.userName;
            Em.fname = this.fname;
            Em.Show();
            this.Hide();
            Em.MM = this;
        }

    

        private void RecommendedSupplier_btn_Click(object sender, EventArgs e)
        {
            Choose_recommendedSupplier ch = new Choose_recommendedSupplier();
            ch.MM = this;
            this.Hide();
            ch.Show();
   
            
        }

        private void RateSupplier_btn_Click(object sender, EventArgs e)
        {
            RateSupplier rateSupplier = new RateSupplier();
            rateSupplier.mn = this;
            rateSupplier.userName = this.userName;
            rateSupplier.Show();
            this.Hide();

        }

        private void goods_btn_Click(object sender, EventArgs e)
        {
            GoodsManagementForm gm = new GoodsManagementForm();
            gm.mn = this;
            gm.userName = this.userName;
            gm.Show();
            this.Hide();
        }

        private void SupplierManagement_btn_Click(object sender, EventArgs e)
        {
            SupplierManagementcs sm = new SupplierManagementcs();
            sm.mn = this;
            sm.userName = this.userName;
            this.Hide();
            sm.Show();
         

        }

        private void GoodsOperatiob_btn_Click(object sender, EventArgs e)
        {
            GoodsOperation GO = new GoodsOperation();
            GO.mn = this;
            GO.userName = this.userName;
            this.Hide();
            GO.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
