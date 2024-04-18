using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public class Employee
    {

        private int employeeNum;
        private string ID;
        private string fName;
        private string lName;
        private string email;
        private string address;
        private string phoneNumber;
        private string password;
        private Gender gender;
        private Role role;
        private bool inArchive;
        private int ManagerNum;


        public Employee(int employeeNum, string ID, string fName, string lName, string email, string address, string phoneNumber, string password, Gender gender, Role role, bool inArchive, int ManagerNum, bool is_new)
        {
            this.employeeNum = employeeNum;
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.password = password;
            this.gender = gender;
            this.role = role;
            this.inArchive = inArchive;
            this.ManagerNum = ManagerNum;

            if (is_new)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "SELECT MAX(scalar) AS MaxScalar FROM ( SELECT (select max(employeeNum)  from dbo.Employees)AS scalar UNION ALL SELECT  (select max(employeeNum)  from dbo.EmployeesArchive)AS scalar) AS subquery";
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);


                if (rdr.HasRows) // Check if there are rows available
                {
                    rdr.Read(); // Move the reader to the first row
                    if (!rdr.IsDBNull(0)) // Check if the value is not null 
                    {
                        int e = int.Parse(rdr.GetValue(0).ToString()) + 1;
                        this.employeeNum = e;
                        this.create_employee();
                        Program.Employees.Add(this);
                    }
                }
            }
        }


        public int get_employeeNum()
        {
            return this.employeeNum;
        }

        public string get_ID()
        {
            return this.ID;
        }

        public string get_fName()
        {
            return this.fName;
        }

        public string get_lName()
        {
            return this.lName;
        }

        public string get_email()
        {
            return this.email;
        }

        public string get_address()
        {
            return this.address;
        }

        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        public string get_password()
        {
            return this.password;
        }

        public Gender get_gender()
        {
            return this.gender;
        }

        public Role get_role()
        {
            return this.role;
        }

        public bool get_inArchive()
        {
            return this.inArchive;
        }

        public int get_ManagerNum()
        {
            return this.ManagerNum;
        }
        public void set_employeeNum(int employeeNum)
        {
            this.employeeNum = employeeNum;
        }

        public void set_ID(string ID)
        {
            this.ID = ID;
        }

        public void set_fName(string fName)
        {
            this.fName = fName;
        }

        public void set_lName(string lName)
        {
            this.lName = lName;
        }

        public void set_email(string email)
        {
            this.email = email;
        }

        public void set_address(string address)
        {
            this.address = address;
        }

        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void set_password(string password)
        {
            this.password = password;
        }

        public void set_gender(Gender gender)
        {
            this.gender = gender;
        }

        public void set_role(Role role)
        {
            this.role = role;
        }

        public void set_inArchive(bool inArchive)
        {
            this.inArchive = inArchive;
        }

        public void set_ManagerNum(int ManagerNum)
        {
            this.ManagerNum = ManagerNum;
        }


        public void create_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Employee @employeeNum, @ID, @fName, @lName, @email,@adress,@phoneNumber,@password, @gender, @role, @inarchive, @ManagerNum";
            c.Parameters.AddWithValue("@employeeNum", this.employeeNum);
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@fName", this.fName);
            c.Parameters.AddWithValue("@lName", this.lName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@adress", this.address);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@role", this.role.ToString());
            c.Parameters.AddWithValue("@inarchive", this.inArchive);
            c.Parameters.AddWithValue("@ManagerNum", this.ManagerNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_employee @employeeNum, @ID, @fName, @lName, @email,@address,@phoneNumber,@password, @gender, @role, @inarchive, @ManagerNum";
            c.Parameters.AddWithValue("@employeeNum", this.employeeNum);
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@fName", this.fName);
            c.Parameters.AddWithValue("@lName", this.lName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@role", this.role.ToString());
            c.Parameters.AddWithValue("@inarchive", this.inArchive);
            c.Parameters.AddWithValue("@ManagerNum", this.ManagerNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_employee()
        {
            Program.Employees.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_employee @ID";
            c.Parameters.AddWithValue("@ID", this.employeeNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void create_employeeArchive()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_EmployeesArchive @employeeNum, @ID, @fName, @lName, @email,@adress,@phoneNumber,@password, @gender, @role, @inarchive, @ManagerNum";
            c.Parameters.AddWithValue("@employeeNum", this.employeeNum);
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@fName", this.fName);
            c.Parameters.AddWithValue("@lName", this.lName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@adress", this.address);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@role", this.role.ToString());
            c.Parameters.AddWithValue("@inarchive", this.inArchive);
            c.Parameters.AddWithValue("@ManagerNum", this.ManagerNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_employeeArchive()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_EmployeesArchive @employeeNum, @ID, @fName, @lName, @email,@address,@phoneNumber,@password, @gender, @role, @inarchive, @ManagerNum";
            c.Parameters.AddWithValue("@employeeNum", this.employeeNum);
            c.Parameters.AddWithValue("@ID", this.ID);
            c.Parameters.AddWithValue("@lName", this.lName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@role", this.role.ToString());
            c.Parameters.AddWithValue("@inarchive", this.inArchive);
            c.Parameters.AddWithValue("@ManagerNum", this.ManagerNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_employeeArchive()
        {
            Program.EmployeesArchive.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_EmployeesArchive @employeeNum";
            c.Parameters.AddWithValue("@employeeNum", this.employeeNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public SqlConnection conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_4;Integrated Security=True");
        public void moveToArchive(Employee e)
        {
            int num = e.employeeNum;
            string query = "SELECT * FROM Tasks WHERE [Created by] = '" + num + "' OR [Created for] = '" + num + "'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Open the connection before executing the query
                conn.Open();

                // Set the parameter value
                command.Parameters.AddWithValue("@employeeNum", num);

                using (SqlDataReader reader = command.ExecuteReader())

                    if (e.get_role() == Role.CEO || e.get_role() == Role.CIO || e.get_role() == Role.FinanceManager || e.get_role() == Role.ProcuementManager || e.get_role() == Role.ProductionManager || e.get_role() == Role.WhearhouseManager)
                    {
                        MessageBox.Show("A manager can not be deleted only updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (reader.HasRows)
                    {
                        MessageBox.Show("you can't delete an employee with tasks, please delete his tasks first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        e.Delete_employee();
                        e.set_inArchive(true);
                        e.create_employeeArchive();
                        Program.EmployeesArchive.Add(e);
                        MessageBox.Show("Employee moved to archive");
                    }
                conn.Close();
            }
        }
        public void voidreturnFromArchive(Employee employee)
        {
            employee.Delete_employeeArchive();
            employee.set_inArchive(false);
            employee.create_employee();
            Program.Employees.Add(employee);

        }

    }


}