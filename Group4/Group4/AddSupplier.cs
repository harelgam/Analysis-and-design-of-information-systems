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
    public partial class AddSupplier : Form
    {
        public String SupplierID;
        public int userName { get; set; }
        public SupplierManagementcs sm { get; set; }
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddToSuppliers_btn_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            if (flag)
            {
                string IDinput = ID_textBox.Text;
                string phoneInput = Phone_textbox.Text;
                int quantity;
                if (ID_textBox.Text.Equals("") || !int.TryParse(IDinput, out quantity))
                {
                    MessageBox.Show("Write valid ID please");
                    flag = false;
                }
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
                    MessageBox.Show("Choose specialization please");
                    flag = false;
                }

                if (flag)
                {
                    Supplier s = new Supplier(ID_textBox.Text, Name_textbox.Text, Email_textbox.Text, Phone_textbox.Text, Adress_textBox.Text, (Specialization)Enum.Parse(typeof(Specialization), Spec_textbox.Text.Replace(" ", "")), true);/////dotansssssssss
                                                                                                                                                                                                                                             //   Employee employee = new Employee(0, ID_textBox.Text, fname_textBox.Text, lname_textBox.Text, Email_textBox.Text, Address_textBox.Text, phoneNumber_textBox.Text, RandomPassword, (Gender)Enum.Parse(typeof(Gender), comboBox1.Text.Replace(" ", "")), (Role)Enum.Parse(typeof(Role), comboBox2.Text.Replace(" ", "")), false, userName, true);
                    MessageBox.Show("The Employee Successfully Registered");
                    sm.populateSearchTable();
                    this.Hide();
                    sm.Show();
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sm.Show();
        }

        private void Phone_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}