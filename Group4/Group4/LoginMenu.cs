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
    public partial class LoginMenu : Form
    {
        public Employee user_emp;
        public MainMenu MainMenu;
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            bool flag = false;
            Employee user_emp;
            for (int i = 0; i < Program.Employees.Count; i++)
            {
                if ((Program.Employees[i].get_employeeNum()).ToString().Equals(txt_userName.Text) && (Program.Employees[i].get_password()).Equals(txt_password.Text))
                {
                    user_emp = Program.Employees[i];
                    MainMenu = new MainMenu();
                    MainMenu.fname = user_emp.get_fName();// שמירת השם לתצוגה במסך הבא
                    MainMenu.lname = user_emp.get_lName();//שמירת המפשחה לתצוגה במסך הבא
                    MainMenu.userName = user_emp.get_employeeNum();//sending the user name
                    flag = true;
                }

            }
            if (flag)
            {
                MainMenu.loginMenu = this;
                MainMenu.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("The User Name or Password are incorrect");
                txt_password.Clear();
                txt_userName.Clear();
            }
        }

        private void CLEAR_btn_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_userName.Clear();
        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
