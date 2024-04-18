using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //רשימות
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Task> Tasks;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Item> Items;
        public static System.Collections.Generic.List<ItemInOrder> ItemsInOrder;
        public static ArrayList stringGenerator = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "Y", "A", "F" };
        public static System.Collections.Generic.List<Employee> EmployeesArchive;


        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי מספר עובד
        public static Employee seekEmployee(int employeeNum)
        {
            foreach (Employee e in Employees)
            {
                if (e.get_employeeNum() == employeeNum)
                    return e;
            }
            return null;

        }

        //שיטה שמחפשת ספק ברשימה לפי מספר ספק
        public static Supplier seekSupplier(string ID)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.get_ID().Equals(ID))
                    return s;
            }
            return null;
        }

        //שיטה שמחפשת משימה ברשימה לפי מספר ספק
        public static Task seekTask(string ID)
        {
            foreach (Task t in Tasks)
            {
                if (t.get_ID().Equals(ID))
                    return t;
            }
            return null;
        }

        //שיטה שמחפשת הזמנה ברשימה לפי מספר הזמנה
        public static Order seekOrder(string ID)
        {
            foreach (Order o in Orders)
            {
                if (o.get_ID().Equals(ID))
                    return o;
            }
            return null;
        }

        //שיטה שמחפשת פריט ברשימה לפי מספר פריט
        public static Item seekItem(int ID)
        {
            foreach (Item i in Items)
            {
                if (i.get_serial_number() == ID)
                    return i;
            }
            return null;
        }

        public static ItemInOrder seekItemsInOrderem(string order, int item)
        {
            foreach (ItemInOrder i in ItemsInOrder)
            {
                if (i.get_order().get_ID().Equals(order) && (i.get_item().get_serial_number() == item))
                    return i;
            }
            return null;
        }

        public static Employee seekEmployeeArchive(int employeeNum)
        {
            foreach (Employee e in EmployeesArchive)
            {
                if (e.get_employeeNum() == employeeNum)
                    return e;
            }
            return null;

        }


        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_employees();//אתחול הרשימה של העובדים
            init_suppliers();//אתחול הרשימה של ההזמנות
            init_Tasks();//אתחול הרשימה של המשימות
            init_Orders();//אתחול הרשימה של הזמנות
            init_Items();//אתחול הרשימה של פריטים
            init_ItemsInOrder();//אתחול הרשימה של פריטים
            init_employeesArchive();
        }


        public static void init_employees()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                string genderString = rdr.GetValue(8).ToString();
                Gender G = Enum.GetValues(typeof(Gender))
                    .Cast<Gender>()
                    .FirstOrDefault(gender =>
                    {
                        FieldInfo field = typeof(Gender).GetField(gender.ToString());
                        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                        return attribute != null && attribute.Description.Equals(genderString, StringComparison.OrdinalIgnoreCase);
                    });

                string roleString = rdr.GetValue(9).ToString();
                Role R = Enum.GetValues(typeof(Role))
                    .Cast<Role>()
                    .FirstOrDefault(role =>
                    {
                        FieldInfo field = typeof(Role).GetField(role.ToString());
                        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                        return attribute != null && attribute.Description.Equals(roleString, StringComparison.OrdinalIgnoreCase);
                    });

                int a1 = int.Parse(rdr.GetValue(0).ToString());
                string b2 = rdr.GetValue(1).ToString();
                string c3 = rdr.GetValue(2).ToString();
                string d4 = rdr.GetValue(3).ToString();
                string e5 = rdr.GetValue(4).ToString();
                string f = rdr.GetValue(5).ToString();
                string g = rdr.GetValue(6).ToString();
                string h = rdr.GetValue(7).ToString();
                bool i = Boolean.Parse(rdr.GetValue(10).ToString());
                int j = int.Parse(rdr.GetValue(11).ToString());

                Employee e = new Employee(a1, b2, c3, d4, e5, f, g, h, G, R, i, j, false);
                Employees.Add(e);
            }
        }

        public static void init_suppliers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_SUPPLIERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();


            while (rdr.Read())
            {

                string specializationString = rdr.GetValue(5).ToString();
                Specialization S = Enum.GetValues(typeof(Specialization))
                      .Cast<Specialization>()
                      .FirstOrDefault(specialization =>
                      {
                          FieldInfo field = typeof(Specialization).GetField(specialization.ToString());
                          DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                          return attribute != null && attribute.Description.Equals(specializationString, StringComparison.OrdinalIgnoreCase);
                      });

                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), S, false);
                Suppliers.Add(s);
            }
        }

        public static void init_Tasks()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tasks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Tasks = new List<Task>();


            while (rdr.Read())
            {

                string priorityString = rdr.GetValue(6).ToString();
                Priority P = Enum.GetValues(typeof(Priority))
                      .Cast<Priority>()
                      .FirstOrDefault(priority =>
                      {
                          FieldInfo field = typeof(Priority).GetField(priority.ToString());
                          DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                          return attribute != null && attribute.Description.Equals(priorityString, StringComparison.OrdinalIgnoreCase);
                      });
                DateTime dateTimeValue = (DateTime)rdr.GetValue(4);

                Task T = new Task(rdr.GetValue(0).ToString(), seekEmployee(int.Parse(rdr.GetValue(1).ToString())), seekEmployee(int.Parse(rdr.GetValue(2).ToString())), rdr.GetValue(3).ToString(), dateTimeValue, rdr.GetValue(5).ToString(), P, bool.Parse(rdr.GetValue(7).ToString()), false);
                Tasks.Add(T);
            }
        }


        public static void init_Orders()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ORDERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Orders = new List<Order>();


            while (rdr.Read())
            {


                DateTime dateTimeValue1 = (DateTime)rdr.GetValue(3);
                DateTime dateTimeValue2 = (DateTime)rdr.GetValue(4);
                DateTime dateTimeValue3 = (DateTime)rdr.GetValue(5);

                Order O = new Order(rdr.GetValue(0).ToString(), seekSupplier(rdr.GetValue(1).ToString()), seekEmployee(int.Parse(rdr.GetValue(2).ToString())),
                    dateTimeValue1, dateTimeValue2, dateTimeValue3,
                    decimal.Parse(rdr.GetValue(6).ToString()), int.Parse(rdr.GetValue(7).ToString()), int.Parse(rdr.GetValue(8).ToString()), int.Parse(rdr.GetValue(9).ToString()), decimal.Parse(rdr.GetValue(10).ToString()), bool.Parse(rdr.GetValue(11).ToString()), false);
                Orders.Add(O);
            }
        }


        public static void init_Items()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ITEMS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Items = new List<Item>();


            while (rdr.Read())
            {

                string categoryString = rdr.GetValue(5).ToString();
                Specialization S = Enum.GetValues(typeof(Specialization))
                      .Cast<Specialization>()
                      .FirstOrDefault(specialization =>
                      {
                          FieldInfo field = typeof(Specialization).GetField(specialization.ToString());
                          DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                          return attribute != null && attribute.Description.Equals(categoryString, StringComparison.OrdinalIgnoreCase);
                      });


                Item I = new Item(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), S, false);
                Items.Add(I);
            }
        }



        public static void init_ItemsInOrder()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ItemsInOreder";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            ItemsInOrder = new List<ItemInOrder>();


            while (rdr.Read())
            {
                ItemInOrder I = new ItemInOrder(seekOrder(rdr.GetValue(0).ToString()), seekItem(int.Parse(rdr.GetValue(1).ToString())), int.Parse(rdr.GetValue(2).ToString()), float.Parse(rdr.GetValue(3).ToString()), bool.Parse(rdr.GetValue(4).ToString()), false);
                ItemsInOrder.Add(I);
            }
        }

        public static void init_employeesArchive()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_EmployeesArchive";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            EmployeesArchive = new List<Employee>();

            while (rdr.Read())
            {
                string genderString = rdr.GetValue(8).ToString();
                Gender G = Enum.GetValues(typeof(Gender))
                    .Cast<Gender>()
                    .FirstOrDefault(gender =>
                    {
                        FieldInfo field = typeof(Gender).GetField(gender.ToString());
                        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                        return attribute != null && attribute.Description.Equals(genderString, StringComparison.OrdinalIgnoreCase);
                    });

                string roleString = rdr.GetValue(9).ToString();
                Role R = Enum.GetValues(typeof(Role))
                    .Cast<Role>()
                    .FirstOrDefault(role =>
                    {
                        FieldInfo field = typeof(Role).GetField(role.ToString());
                        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                        return attribute != null && attribute.Description.Equals(roleString, StringComparison.OrdinalIgnoreCase);
                    });

                int a1 = int.Parse(rdr.GetValue(0).ToString());
                string b2 = rdr.GetValue(1).ToString();
                string c3 = rdr.GetValue(2).ToString();
                string d4 = rdr.GetValue(3).ToString();
                string e5 = rdr.GetValue(4).ToString();
                string f = rdr.GetValue(5).ToString();
                string g = rdr.GetValue(6).ToString();
                string h = rdr.GetValue(7).ToString();
                bool i = Boolean.Parse(rdr.GetValue(10).ToString());
                int j = int.Parse(rdr.GetValue(11).ToString());

                Employee e = new Employee(a1, b2, c3, d4, e5, f, g, h, G, R, i, j, false);
                EmployeesArchive.Add(e);
            }
        }

        //public static void initTotalPriceUpdate()
        //{
        //    decimal totalCost = 0;
        //    for (int j = 0; j < Orders.Count(); j++)
        //    {
        //        for (int i = 0; i < ItemsInOrder.Count(); i++)
        //        {
        //            if (ItemsInOrder[i].get_order().get_ID().Equals(Orders[j].get_ID()))
        //            {
        //                totalCost += (decimal)(ItemsInOrder[i].get_price() * ItemsInOrder[i].get_quantity());
        //                Orders[j].set_totalCost(totalCost);
        //                Orders[j].Update_order();
        //            }

        //        }
        //        totalCost = 0;
        //    }
        //}


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            //initTotalPriceUpdate();

            //seekEmployee(2923).tasks.Contains(seekTask("#46c1fb"));
            ////Item i= new Item(2, "hj", 56, "HG"#"Fhfg", "jhgjgh", false, Specialization.itservices, true);
            //////i.Delete_item();
            ////DateTime dt = new DateTime(2022, 1, 2);
            ////Task T = new Task("14523FD", seekEmployee(1209), seekEmployee(1209), "gfgdfgdfrgdf", dt, "fgdgf", Priority.Urgent, true);
            ////Console.WriteLine(seekEmployee(1209).tasks.Contains(T));
            ////T.Delete_task();
            ////Console.WriteLine(seekEmployee(1209).tasks.Contains(T));




            //// Employee e = new Employee(786876, "jfdbhskjh", "kjhdsgkjd", "hjgdsjhgsd", "sjhdgdjsh", "shjdghdjsgs", "sdjhgfj", "sjdkgdhsj", Gender.agender, Role.CEO, false, 1209, true);
            //////   //Task T = new Task("14523FD", seekEmployee(1209), seekEmployee(1209), "gfgdfgdfrgdf", dt, "fgdgf", Priority.Urgent, true);
            //////   //Console.WriteLine(e.tasks.Contains(T));
            //////   //T.Delete_task();
            //////   //seekEmployee(786876).Delete_employee();
            //////   //seekEmployee(786876).Delete_employee();
            ////////   Task t = seekTask("#234d63");

            ////////   //t.Delete_task();
            ////  Supplier s = new Supplier("or", "dsf", "asd", "asd", "sdf", Specialization.constructionmaterials, true);
            ////  Order o = new Order("harel", s, e, dt, dt, dt, 50, 555, 77, 88, 50, true);


            //////////   //  seekSupplier("or").Delete_supplier();
            ////  //ItemInOrder ito = new ItemInOrder(seekOrder("00-021-3918"), seekItem(1080815), 152, 4456, true);
            ////ItemInOrder cusemek = new ItemInOrder(o, i, 152, 4456, true);
            ////Console.WriteLine(o.itemsInOrder.Contains(cusemek));
            ////cusemek.Delete_itemInOrder();
            ////Console.WriteLine(o.itemsInOrder.Contains(cusemek));
            //////// Console.WriteLine(o.itemsInOrder.Contains(ito));
            ////////Console.WriteLine(seekOrder("harel").itemsInOrder.Contains(seekItemsInOrderem("00-021-3918", 1080815)));


            //////   Console.WriteLine(o.itemsInOrder.Contains(ito));
            //////    seekOrder("harel").Delete_order();
            //////  seekTask("14523FD").Delete_task();
            //////  seekEmployee(786876).Delete_employee();


            //////s.Delete_supplier();
            //////e.Delete_employee();
            ////seekItemsInOrderem(seekOrder("00-021-3918").get_ID(), seekItem(1080815).get_serial_number()).Delete_itemInOrder();
            ////seekItem(2).Delete_item();
            ////seekOrder("harel").Delete_order();
            ////seekEmployee(786876).Delete_employee();
            ////seekSupplier("or").Delete_supplier();




            Console.WriteLine(seekEmployee(1209).get_employeeNum());
            Application.Run(new LoginMenu());



        }
    }

}