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

namespace Group4
{
    public partial class CreateItemForm : Form
    { 
        public int userName { get; set; }
        public GoodsManagementForm gmf;
 


        public CreateItemForm()
        {
            InitializeComponent();
            var specializations = Enum.GetValues(typeof(Specialization));
            foreach (Specialization specialization in specializations)
            {
                comboBox1.Items.Add(GetEnumDescription(specialization));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        private void CreateItemForm_Load(object sender, EventArgs e)
        {

        }

        private void Create_conf_btn_Click(object sender, EventArgs e)
        {
            if (Name_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Name please");
            }
            else if (ExpDate_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Expiration date please");
            }
            else
            {
               
                if(comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a value from the ComboBox.");
                    return;
                }
                else
                {
                    string selectedValue = comboBox1.SelectedItem.ToString();
                    Specialization S = Enum.GetValues(typeof(Specialization))
                        .Cast<Specialization>()
                        .FirstOrDefault(specialization =>
                        {
                            FieldInfo field = typeof(Specialization).GetField(specialization.ToString());
                            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                            return attribute != null && attribute.Description.Equals(selectedValue, StringComparison.OrdinalIgnoreCase);
                        });

                    Item i = new Item(0, Name_textbox.Text, 0, ExpDate_textbox.Text, "gfgf", S, true);
                    MessageBox.Show("The Item created Successfully");
                    Name_textbox.Clear();
                    ExpDate_textbox.Clear();
                    comboBox1.Text = string.Empty;
                    gmf.refreshData();
                    
                }
            }


        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            gmf.Show();
            this.Hide();
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
