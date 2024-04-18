using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public class Order
    {
        private string ID;
        public Supplier supplier;
        private Employee madeBy;
        private DateTime purchaseDate;
        private DateTime estimatedDelivery;
        private DateTime arrivalDate;
        private decimal discount;
        private int priceRating;
        private int supplyTimeRating;
        private int qualitylRating;
        private decimal totalCost;
        private bool arrived;

        public Order(string ID, Supplier supplier, Employee madeBy, DateTime purchaseDate, DateTime estimatedDelivery, DateTime arrivalDate, decimal discount, int priceRating, int supplyTimeRating, int qualitylRating, decimal totalCost, bool arrived, bool is_new)
        {
            this.ID = ID;
            this.supplier = supplier;
            this.madeBy = madeBy;
            this.purchaseDate = purchaseDate;
            this.estimatedDelivery = estimatedDelivery;
            this.arrivalDate = arrivalDate;
            this.discount = discount;
            this.priceRating = priceRating;
            this.supplyTimeRating = supplyTimeRating;
            this.qualitylRating = qualitylRating;
            this.totalCost = totalCost;
            this.arrived = arrived;




            if (is_new)
            {
                this.ID = generateString();
                this.arrived = false;
                DateTime dateTimeVariable = new DateTime(2050, 10, 10);
                this.arrivalDate = dateTimeVariable;

                this.create_order();
                Program.Orders.Add(this);
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

        //public void insertGoodsbyStoreKeeper() //// לתקןןןןןןןןןןןן
        //{
        //    this.arrived = true;
        //    this.set_arrivalDate(DateTime.Now);
        //    bool flag = true;

        //    for (int i = 0; i < Program.ItemsInOrder.Count; i++)
        //    {
        //        if(Program.ItemsInOrder[i].get_order().get_ID().Equals(this.ID)  && Program.ItemsInOrder[i].getInhold() == true)
        //        {
        //            flag = false;
        //            break;
        //        }
        //    }


        //        for (int i = 0; i < Program.ItemsInOrder.Count; i++)
        //    {
        //        if (Program.ItemsInOrder[i].get_order().get_ID().Equals(this.get_ID()) && flag)
        //        {
        //            Program.ItemsInOrder[i].get_item().set_quantity_in_stock(Program.ItemsInOrder[i].get_item().get_quantity_in_stock() + Program.ItemsInOrder[i].get_quantity());
        //        }
        //    }

        //    this.Update_order();

        //    if(!flag) // There are items in hold
        //    {

        //    }

        //}





        // Getters
        public string get_ID()
        {
            return this.ID;
        }

        public Supplier get_supplier()
        {
            return this.supplier;
        }

        public Employee get_madeBy()
        {
            return this.madeBy;
        }

        public DateTime get_purchaseDate()
        {
            return this.purchaseDate;
        }

        public DateTime get_estimatedDelivery()
        {
            return this.estimatedDelivery;
        }

        public DateTime get_arrivalDate()
        {
            return this.arrivalDate;
        }

        public decimal get_discount()
        {
            return this.discount;
        }

        public int get_priceRating()
        {
            return this.priceRating;
        }

        public int get_supplyTimeRating()
        {
            return this.supplyTimeRating;
        }

        public int get_qualitylRating()
        {
            return this.qualitylRating;
        }

        public decimal get_totalCost()
        {
            return this.totalCost;
        }

        // Setters
        public void set_ID(string ID)
        {
            this.ID = ID;
        }

        public void set_supplier(Supplier supplier)
        {
            this.supplier = supplier;
        }

        public void set_madeBy(Employee madeBy)
        {
            this.madeBy = madeBy;
        }

        public void set_purchaseDate(DateTime purchaseDate)
        {
            this.purchaseDate = purchaseDate;
        }

        public void set_estimatedDelivery(DateTime estimatedDelivery)
        {
            this.estimatedDelivery = estimatedDelivery;
        }

        public void set_arrivalDate(DateTime arrivalDate)
        {
            this.arrivalDate = arrivalDate;
        }

        public void set_discount(decimal discount)
        {
            this.discount = discount;
        }

        public void set_priceRating(int priceRating)
        {
            this.priceRating = priceRating;
        }

        public void set_supplyTimeRating(int supplyTimeRating)
        {
            this.supplyTimeRating = supplyTimeRating;
        }

        public void set_qualitylRating(int qualitylRating)
        {
            this.qualitylRating = qualitylRating;
        }

        public void set_totalCost(decimal totalCost)
        {
            this.totalCost = totalCost;
        }

        public void set_arrived(bool isarrived)
        {
            this.arrived = isarrived;
            this.set_arrivalDate(DateTime.Now);
        }





        public void create_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Order @ID, @supplier, @madeBy, @purchaseDate, @estimatedDelivery, @arrivalDate, @discount, @priceRating, @supplyTimeRating, @qualitylRating, @totalCost, @arrived";
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@supplier", this.supplier.get_ID());
            c.Parameters.AddWithValue("@madeBy", this.madeBy.get_employeeNum());
            c.Parameters.AddWithValue("@purchaseDate", this.purchaseDate);
            c.Parameters.AddWithValue("@estimatedDelivery", this.estimatedDelivery);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@discount", this.discount);
            c.Parameters.AddWithValue("@priceRating", this.priceRating);
            c.Parameters.AddWithValue("@supplyTimeRating", this.supplyTimeRating);
            c.Parameters.AddWithValue("@qualitylRating", this.qualitylRating);
            c.Parameters.AddWithValue("@totalCost", this.totalCost);
            c.Parameters.AddWithValue("@arrived", this.arrived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Order @ID, @supplier, @madeBy, @purchaseDate, @estimatedDelivery, @arrivalDate, @discount, @priceRating, @supplyTimeRating, @qualitylRating, @totalCost, @arrived";
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@supplier", this.supplier.get_ID());
            c.Parameters.AddWithValue("@madeBy", this.madeBy.get_employeeNum());
            c.Parameters.AddWithValue("@purchaseDate", this.purchaseDate);
            c.Parameters.AddWithValue("@estimatedDelivery", this.estimatedDelivery);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@discount", this.discount);
            c.Parameters.AddWithValue("@priceRating", this.priceRating);
            c.Parameters.AddWithValue("@supplyTimeRating", this.supplyTimeRating);
            c.Parameters.AddWithValue("@qualitylRating", this.qualitylRating);
            c.Parameters.AddWithValue("@totalCost", this.totalCost);
            c.Parameters.AddWithValue("@arrived", this.arrived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_order()
        {
            Program.Orders.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_order @ID";
            c.Parameters.AddWithValue("@ID", this.ID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}