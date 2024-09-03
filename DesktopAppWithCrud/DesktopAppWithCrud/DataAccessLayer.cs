using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppWithCrud
{
    public class DataAccessLayer
    {
        const string conString = "";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public DataAccessLayer() { }

        public List<Student> GetAllStudents()
        {
            List<Student> list = new List<Student>();   
            conn.Open();
            string conString = "Selcet * from Student";
            cmd.CommandText = conString;

            while (reader.Read()) { 
            Student s = new Student();
                s.Id = Convert.ToInt32(reader["ID"]);
                s.Name = Convert.ToString(reader["Name"]);
                s.Address = Convert.ToString(reader["Address"]);
                s.Phone = Convert.ToString(reader["Phone"]);
                s.DoB = Convert.ToDateTime(reader["DoB"]);
                list.Add(s);
            }
            reader.Close();
            conn.Close();
            return list;
        }


        public bool Register(Student s)
        {
            cmd.CommandText = "Insert into Student (Id, Name, Address, Phone, DoB) values (Select max(Id) is Null Then 1 Else max(id)+1 From Student,@Name, @Address, @Phone, @DoB)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Address", s.Address);
            cmd.Parameters.AddWithValue("@Phone", s.Phone);
            cmd.Parameters.AddWithValue("DoB", s.DoB);
            try
            {

                conn.Open();
                int count = cmd.ExecuteNonQuery();
                conn.Close();
                return count == 1;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Edit(Student s, int oldId) {
            cmd.CommandText = "Update  Student Set Name=@Name, Address=@Address, Phone=@Phone, DoB=@DoB";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Address", s.Address);
            cmd.Parameters.AddWithValue("@Phone", s.Phone);
            cmd.Parameters.AddWithValue("DoB", s.DoB);
            try
            {

                conn.Open();
                int count = cmd.ExecuteNonQuery();
                conn.Close();
                return count == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        
    }
    
}
