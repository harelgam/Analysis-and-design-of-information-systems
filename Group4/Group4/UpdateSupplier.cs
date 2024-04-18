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
    public partial class UpdateSupplier : Form
    {
        public String SupplierID;
        public int userName { get; set; }
        public SupplierManagementcs sm { get; set; }
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void updateSupplier_btn_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            if (flag)
            {
                string phoneInput = Phone_textbox.Text;
                int quantity;

                if (Name_textbox.Text.Equals(""))
                {
                    MessageBox.Show("Write Name please");
                    flag = false;
                }
                if (Email_textbox.Text.Equals(""))
                {
                    MessageBox.Show("Write valid Email please");
                    flag = false;
                }
                else if (!Email_textbox.Text.Contains("@"))
                {
                    MessageBox.Show("Email must contain @ symbol");
                    flag = false;
                }
                if (Phone_textbox.Text.Equals("") || !int.TryParse(phoneInput, out quantity))
                {
                    MessageBox.Show("Write valid Phone number please");
                    flag = false;
                }
                if (Adress_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Write Address please");
                    flag = false;
                }
                if ((!Spec_textbox.Text.Equals("raw materials")) && (!Spec_textbox.Text.Equals("printing and publishing")) && (!Spec_textbox.Text.Equals("electronic components"))
                     && (!Spec_textbox.Text.Equals("construction materials")) && (!Spec_textbox.Text.Equals("logistics provider")) && (!Spec_textbox.Text.Equals("it services"))
                     && (!Spec_textbox.Text.Equals("packaging")))
                {
                    MessageBox.Show("Choose Specialization please");
                    flag = false;
                }


            }
            if (flag)
            {
                Supplier s1 = Program.seekSupplier(SupplierID);
                s1.set_name(Name_textbox.Text);
                s1.set_mail(Email_textbox.Text);
                s1.set_phoneNumber(Phone_textbox.Text);
                s1.set_adress(Adress_textBox.Text);
                s1.set_specialization((Specialization)Enum.Parse(typeof(Specialization), Spec_textbox.Text.Replace(" ", "")));
                //  e1.set_gender((Gender)Enum.Parse(typeof(Gender), comboBox1.Text.Replace(" ", "")));


                s1.Update_supplier();
                sm.populateSearchTable();
                MessageBox.Show("Update succesful");
                sm.Show();
                this.Hide();

            }
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            sm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}