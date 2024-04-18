using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public class ItemInOrder
    {
        public Order order;
        private Item item;
        private int quantity;
        private float price;
        private bool inhold;

        public ItemInOrder(Order order, Item item, int quantity, float price, bool inhold, bool is_new)
        {
            this.order = order;
            this.item = item;
            this.quantity = quantity;
            this.price = price;
            this.inhold = inhold;

            if (is_new)
            {
                this.order.set_totalCost(this.order.get_totalCost() + (this.quantity * (int)this.price));
                this.order.Update_order();
                this.inhold = false;

                this.create_ItemInOrder();
                Program.ItemsInOrder.Add(this);
            }
        }



        public Order get_order()
        {
            return this.order;
        }

        public Item get_item()
        {
            return this.item;
        }

        public int get_quantity()
        {
            return this.quantity;
        }

        public float get_price()
        {
            return this.price;
        }

        public bool getInhold()
        {
            return this.inhold;
        }

        public void set_order(Order order)
        {
            this.order = order;
        }

        public void set_item(Item item)
        {
            this.item = item;
        }

        public void set_quantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void set_price(float price)
        {
            this.price = price;
        }

        public void insertToHold()
        {
            this.inhold = true;
        }


        public void removeFromHold()
        {
            this.inhold = false;
            this.addToStock();
        }

        public void addToStock()
        {
            this.item.set_quantity_in_stock(this.item.get_quantity_in_stock() + this.quantity);
        }


        public void create_ItemInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_itemInOrder @order,@item, @quantity, @price, @inhold";
            c.Parameters.AddWithValue("@order", this.order.get_ID());
            c.Parameters.AddWithValue("@item", this.item.get_serial_number());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@inhold", this.inhold);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void Update_itemInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_itemInOrder @order,@item, @quantity, @price, @inhold";
            c.Parameters.AddWithValue("@order", this.order.get_ID());
            c.Parameters.AddWithValue("@item", this.item.get_serial_number());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@inhold", this.inhold);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Delete_itemInOrder()
        {
            this.order.set_totalCost(this.order.get_totalCost() - (this.quantity * (int)this.price));
            this.order.Update_order();
            Program.ItemsInOrder.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_itemInOrder @order, @item";
            c.Parameters.AddWithValue("@order", this.order.get_ID());
            c.Parameters.AddWithValue("@item", this.item.get_serial_number());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }



    }
}