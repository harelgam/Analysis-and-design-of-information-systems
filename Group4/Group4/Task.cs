using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public class Task
    {
        private string ID;
        public Employee createdBy;
        public Employee createdFor;
        private string description;
        private DateTime deadLine;
        private string status;
        private Priority priority;
        private bool cancellationrequest;





        public Task(string ID, Employee createdBy, Employee createdFor, string description, DateTime deadLine, string status, Priority priority, bool cancellationrequest, bool is_new)
        {
            this.ID = ID;
            this.createdBy = createdBy;
            this.createdFor = createdFor;
            this.description = description;
            this.deadLine = deadLine;
            this.status = status;
            this.priority = priority;
            this.cancellationrequest = cancellationrequest;

            if (is_new)
            {
                this.ID = generateString();


                this.create_Task();
                Program.Tasks.Add(this);
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


        public string get_ID()
        {
            return this.ID;
        }

        public Employee get_createdBy()
        {
            return this.createdBy;
        }

        public Employee get_createdFor()
        {
            return this.createdFor;
        }

        public string get_description()
        {
            return this.description;
        }
        public DateTime get_deadLine()
        {
            return this.deadLine;
        }

        public string get_status()
        {
            return this.status;
        }

        public Priority get_priority()
        {
            return this.priority;
        }
        public bool get_cancellation_request()
        {
            return this.cancellationrequest;
        }

        // Setters
        public void set_ID(string ID)
        {
            this.ID = ID;
        }

        public void set_createdBy(Employee createdBy)
        {
            this.createdBy = createdBy;
        }

        public void set_createdFor(Employee createdFor)
        {
            this.createdFor = createdFor;
        }

        public void set_description(string description)
        {
            this.description = description;
        }

        public void set_deadLine(DateTime deadLine)
        {
            this.deadLine = deadLine;
        }

        public void set_status(string status)
        {
            this.status = status;
        }

        public void set_priority(Priority priority)
        {
            this.priority = priority;
        }
        public void set_cancellation_request(bool flag)
        {
            this.cancellationrequest = flag;
        }
        public void create_Task()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_task @ID, @createdBy, @createdFor, @description, @deadLine, @status, @priority, @cancellationrequest";
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@createdBy", this.createdBy.get_employeeNum());
            c.Parameters.AddWithValue("@createdFor", this.createdFor.get_employeeNum());
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@deadLine", this.deadLine);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@priority", this.priority.ToString());
            c.Parameters.AddWithValue("@cancellationrequest", this.cancellationrequest.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void Update_task()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_task @ID, @createdBy, @createdFor, @description, @deadLine, @status, @priority, @cancellationrequest"; ;
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@createdBy", this.createdBy.get_employeeNum());
            c.Parameters.AddWithValue("@createdFor", this.createdFor.get_employeeNum());
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@deadLine", this.deadLine);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@priority", this.priority.ToString());
            c.Parameters.AddWithValue("@cancellationrequest", this.cancellationrequest.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_task()
        {
            Program.Tasks.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_task @ID";
            c.Parameters.AddWithValue("@ID", this.ID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}