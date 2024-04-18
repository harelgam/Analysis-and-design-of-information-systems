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
using System.Net;
using System.Net.Mail;

namespace Group4
{
    public partial class ReasonForHoldForm : Form
    {
        public int userName { get; set; }
        public string orderWithHold { get; set; }
        public InsertItemsForm ii { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");

        public ReasonForHoldForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReasonForHoldForm_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string reason = ReasonForGap_textbox.Text;
                    Employee manager = Program.seekEmployee(Program.seekEmployee(this.userName).get_ManagerNum());

                    SmtpClient AranMail = new SmtpClient();
                    AranMail.Port = 587;
                    AranMail.Host = "smtp.gmail.com";
                    AranMail.EnableSsl = true;
                    AranMail.Timeout = 10000;
                    AranMail.DeliveryMethod = SmtpDeliveryMethod.Network;
                    AranMail.UseDefaultCredentials = false;
                    AranMail.Credentials = new NetworkCredential(manager.get_email(), "veweuzbviiecabap");

                    MailMessage massage = new MailMessage(manager.get_email(), manager.get_email(), "An gap in order '" + this.orderWithHold + "'", reason);
                    massage.BodyEncoding = UTF8Encoding.UTF8;
                    massage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    AranMail.Send(massage);

                    MessageBox.Show("Email sent successfuly");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erroe: " + ex.Message);
                }
            }

            ii.refreshData();
            ii.Show();
            this.Hide();


        }

        private void ReasonForGap_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
