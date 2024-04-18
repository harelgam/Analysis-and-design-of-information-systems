using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class AddEmployee : Form
    {
        public EmployeeManagement Em { get; set; }
        public int userName { get; set; }


        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Em.Show();
        }

        private void AddEmployee_btn_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            if (flag)
            {
                string IDinput = ID_textBox.Text;
                string phoneInput = phoneNumber_textBox.Text;
                int quantity;
                if (ID_textBox.Text.Equals("") || ID_textBox.Text.Length != 9 || !int.TryParse(IDinput, out quantity))
                {
                    MessageBox.Show("Write valid ID please");
                    flag = false;
                }
                if (fname_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Write First Name please");
                    flag = false;
                }
                if (lname_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Write Last Name please");
                    flag = false;
                }
                if (Email_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Write valid Email please");
                    flag = false;
                }
                else if (!Email_textBox.Text.Contains("@"))
                {
                    MessageBox.Show("Email must contain @ symbol");
                    flag = false;
                }
                if (Address_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Write Address please");
                    flag = false;
                }
                if (phoneNumber_textBox.Text.Equals("") || !int.TryParse(phoneInput, out quantity))
                {
                    MessageBox.Show("Write valid Phone Number please");
                    flag = false;
                }
                if ((!comboBox1.Text.Equals("Male")) && (!comboBox1.Text.Equals("Female")) && (!comboBox1.Text.Equals("agender"))
                    && (!comboBox1.Text.Equals("Gendernatural")) && (!comboBox1.Text.Equals("Genderqueer")) && (!comboBox1.Text.Equals("NonBinary"))
                    && (!comboBox1.Text.Equals("Pangender")) && (!comboBox1.Text.Equals("Thirdgender")) && (!comboBox1.Text.Equals("Transgender"))
                    && (!comboBox1.Text.Equals("Twospirit")))
                {
                    MessageBox.Show("Choose Gender please");
                    flag = false;
                }
                if ((!comboBox2.Text.Equals("CEO")) && (!comboBox2.Text.Equals("CIO")) && (!comboBox2.Text.Equals("Data Analyst"))
                   && (!comboBox2.Text.Equals("Procuement Manager")) && (!comboBox2.Text.Equals("Whearhouse Manager")) && (!comboBox2.Text.Equals("Finance Manager"))
                   && (!comboBox2.Text.Equals("Production Manager")) && (!comboBox2.Text.Equals("Store Keeper")) && (!comboBox2.Text.Equals("Production Line"))
                   && (!comboBox2.Text.Equals("Graphic Designer")) && (!comboBox2.Text.Equals("IT")))
                {
                    MessageBox.Show("Choose Role please");
                    flag = false;
                }
            }
            if (flag)
            {
                string RandomPassword = generateString();
                Employee employee = new Employee(0, ID_textBox.Text, fname_textBox.Text, lname_textBox.Text, Email_textBox.Text, Address_textBox.Text, phoneNumber_textBox.Text, RandomPassword, (Gender)Enum.Parse(typeof(Gender), comboBox1.Text.Replace(" ", "")), (Role)Enum.Parse(typeof(Role), comboBox2.Text.Replace(" ", "")), false, userName, true);
                MessageBox.Show("The Employee Successfully Registered");
                Em.populateEmployeeTable();
                this.Hide();
                Em.Show();
            }


        }
        public static string generateString()
        {
            Random random = new Random();
            int randomNumber;
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                randomNumber = random.Next(0, 20);
                s += Program.stringGenerator[randomNumber];
            }
            return s;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}