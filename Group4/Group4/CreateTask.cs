using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Group4
{
    
    public partial class CreateTask : Form
    {
        public int userName { get; set; }
        public Priority P;
        public TaskOperation taskO { get; set; }
        
        public CreateTask()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateSelfTask_Load(object sender, EventArgs e)
        {
            
               
        }

        private void button1_Click(object sender, EventArgs e)//insert task
        {
            if (Description.Text.Equals("")){
            
                MessageBox.Show("Write Description please");

            }
            else if ((!comboBox1.Text.Equals("Lowpriority")) && (!comboBox1.Text.Equals("Normal")) && (!comboBox1.Text.Equals("Urgent")))
                { 
                MessageBox.Show("Choose priority please");
            }
            else
            {
                Employee e2;
                    e2 = Program.seekEmployee(userName);
            
                Employee e1 = Program.seekEmployee(userName);

                string s = dateTimePicker1.Value.ToShortDateString();
                //DateTime dt = DateTime.ParseExact(s, "dd/mm/yyyy", null);
                DateTime dt = DateTime.Parse(s);
                Task t = new Task(" ", e1, e2, Description.Text, dt, " ", (Priority)Enum.Parse(typeof(Priority), comboBox1.Text), false, true);
                MessageBox.Show("The Task Successfully Registered");
                Description.Clear();
                comboBox1.Text = string.Empty;
                taskO.refreshData();
                this.Hide();
              
            }

        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Description.Clear();
            comboBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)//return button
        {
               this.Hide();
            taskO.Hide();
            taskO.Show();



        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
