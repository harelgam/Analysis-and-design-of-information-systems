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
    public partial class UpdateItemForm : Form
    {
        public int userName { get; set; }
        public GoodsManagementForm gm { get; set; }

        public int serialNum { get; set; }
        public UpdateItemForm()
        {
            InitializeComponent();
            var specializations = Enum.GetValues(typeof(Specialization));
            foreach (Specialization specialization in specializations)
            {
                comboBox1.Items.Add(GetEnumDescription(specialization));
            }
        }
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            gm.Show();
            this.Hide();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (ItemName_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Name please");
            }
            else if (Quantity_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Quantity please");
            }
            else if (Expiration_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Expiration date please");
            }
            else if (Location_textbox.Text.Equals(""))
            {

                MessageBox.Show("Write Location please");
            }
            else
            {
               
                if (comboBox1.SelectedItem == null)
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

                    string input = Quantity_textbox.Text;
                    int quantity;

                    if (int.TryParse(input, out quantity))
                    {
                        Item i = Program.seekItem(serialNum);
                        i.set_item_name(ItemName_textbox.Text);
                        i.set_quantity_in_stock(int.Parse(Quantity_textbox.Text));
                        i.set_expiration_date(Expiration_textbox.Text);
                        i.set_location(Location_textbox.Text);
                        i.set_category(S);
                        i.Update_item();
                        MessageBox.Show("The Item updated Successfully");

                        gm.refreshData();
                        gm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The quantity is not valid");
                    }



                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
