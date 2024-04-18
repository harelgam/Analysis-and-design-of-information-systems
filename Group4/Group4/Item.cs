using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public class Item
    {


        private int serial_number;
        private string item_name;
        private int quantity_in_stock;
        private string expiration_date;
        private string location;

        private Specialization category;
        private static Random random = new Random();



        public Item(int serial_number, string item_name, int quantity_in_stock, string expiration_date, string location, Specialization category, bool is_new)
        {
            this.serial_number = serial_number;
            this.item_name = item_name;
            this.quantity_in_stock = quantity_in_stock;
            this.expiration_date = expiration_date;
            this.location = location;

            this.category = category;

            if (is_new)
            {
                this.quantity_in_stock = 0;
                this.location = generateLocation();

                SqlCommand c = new SqlCommand();
                c.CommandText = "select max([serial_number])  from dbo.Items";
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);

                if (rdr.HasRows) // Check if there are rows available
                {
                    rdr.Read(); // Move the reader to the first row
                    if (!rdr.IsDBNull(0)) // Check if the value is not null
                    {
                        int i = int.Parse(rdr.GetValue(0).ToString()) + 1;
                        this.serial_number = i;
                        this.create_item();
                        Program.Items.Add(this);
                    }
                }
            }



        }



        public int get_serial_number()
        {
            return this.serial_number;
        }

        public string get_item_name()
        {
            return this.item_name;
        }

        public int get_quantity_in_stock()
        {
            return this.quantity_in_stock;
        }

        public string get_expiration_date()
        {
            return this.expiration_date;
        }

        public string get_location()
        {
            return this.location;
        }


        public Specialization get_category()
        {
            return this.category;
        }

        // Setters
        public void set_serial_number(int serial_number)
        {
            this.serial_number = serial_number;
        }

        public void set_item_name(string item_name)
        {
            this.item_name = item_name;
        }

        public void set_quantity_in_stock(int quantity_in_stock)
        {
            this.quantity_in_stock = quantity_in_stock;
        }

        public void set_expiration_date(string expiration_date)
        {
            this.expiration_date = expiration_date;
        }

        public void set_location(string location)
        {
            this.location = location;
        }



        public void set_category(Specialization category)
        {
            this.category = category;
        }


        public static string generateLocation()
        {
            string aisle = "Aisle " + random.Next(1, 5);
            string shelf = "Shelf " + (char)random.Next('A', 'E') + "-" + random.Next(1, 13);

            return aisle + "-" + shelf;
        }

        public void create_item()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_item @serial_number, @item_name, @quantity_in_stock, @expiration_date, @location, @category";
            c.Parameters.AddWithValue("@serial_number", this.serial_number);
            c.Parameters.AddWithValue("@item_name", this.item_name);
            c.Parameters.AddWithValue("@quantity_in_stock", this.quantity_in_stock);
            c.Parameters.AddWithValue("@expiration_date", this.expiration_date);
            c.Parameters.AddWithValue("@location", this.location);
            c.Parameters.AddWithValue("@category", this.category);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_item()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_item  @serial_number, @item_name, @quantity_in_stock, @expiration_date, @location, @category";
            c.Parameters.AddWithValue("@serial_number", this.serial_number);
            c.Parameters.AddWithValue("@item_name", this.item_name);
            c.Parameters.AddWithValue("@quantity_in_stock", this.quantity_in_stock);
            c.Parameters.AddWithValue("@expiration_date", this.expiration_date);
            c.Parameters.AddWithValue("@location", this.location);
            c.Parameters.AddWithValue("@category", this.category);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_item()
        {
            Program.Items.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Item @serial_number";
            c.Parameters.AddWithValue("@serial_number", this.serial_number);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}