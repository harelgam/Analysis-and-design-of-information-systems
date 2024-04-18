using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public class Supplier
    {
        private string ID;
        private string name;
        private string mail;
        private string phoneNumber;
        private string adress;
        private Specialization specialization;


        public Supplier(string iD, string name, string mail, string phoneNumber, string adress, Specialization specialization, bool is_new)
        {
            this.ID = iD;
            this.name = name;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            this.adress = adress;
            this.specialization = specialization;

            if (is_new)
            {
                this.ID = generateString();
                this.create_supplier();
                Program.Suppliers.Add(this);
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

        //getters
        public string get_ID()
        {
            return this.ID;
        }

        public string get_name()
        {
            return this.name;
        }

        public string get_mail()
        {
            return this.mail;
        }

        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        public string get_adress()
        {
            return this.adress;
        }

        public Specialization get_specialization()
        {
            return this.specialization;
        }

        // Setters
        public void set_ID(string ID)
        {
            this.ID = ID;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

        public void set_mail(string mail)
        {
            this.mail = mail;
        }

        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void set_adress(string adress)
        {
            this.adress = adress;
        }

        public void set_specialization(Specialization specialization)
        {
            this.specialization = specialization;
        }



        public void create_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Supplier @ID, @name, @mail, @phoneNumber, @adress, @specialization";
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@mail", this.mail);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@adress", this.adress);
            c.Parameters.AddWithValue("@specialization", this.specialization.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Supplier @ID, @name, @mail, @phoneNumber, @adress, @specialization";
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@mail", this.mail);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@adress", this.adress);
            c.Parameters.AddWithValue("@specialization", this.specialization.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_supplier()
        {
            Program.Suppliers.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Supplier @ID";
            c.Parameters.AddWithValue("@ID", this.ID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }





}