using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Adio .Net
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConsoleWithDbCrud
{
    public class DataAccess
    {
        //private const string conString = "Data Source = MANAN; Initial Catalog = TestDb; Integrated Security= SSPI";
        private string conString = "Server = MANAN; Database = TestDb; Integrated Security= SSPI"; //For Windows Authentication mathi ko le nii kamm garxa yesle pani garxa
        //private string conString = "Data Source = MANAN; Initial Catalog = TestDb; User Id = sa; Password: 123456";// Sql Server Authentication ko lagi yo halne

        private SqlConnection con;
        private SqlCommand cmd;
        public DataAccess()
        {  
            //Instantate connection obhject
           //con = new SqlConnection(conString);
           // cmd = con.SqlCommand();

            con = new SqlConnection();
            con.ConnectionString = conString;
            //Insrantiate command object
            // cmd = new SqlCommand("", con); // Tala ko kura same ekline jma garna 
            cmd = new SqlCommand();
            cmd.Connection= con;

            //cmd.CommandType = CommandType.Text;
        }
        public bool AddStudent(Student s)//Create
        {
           // cmd.CommandText ="Insert into Student(Id, Name, Address, DoB) values ("+s.Id.ToString()+","" )";
            cmd.CommandText = "Insert into Student(Id, Name, Address, Gender, DoB) values (@Id, @Name, @Address, @Gender, @DoB)";
            cmd.Parameters.AddWithValue("@Id", s.Id);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Address", s.Address);
            cmd.Parameters.AddWithValue("@gender", s.Gender);
            cmd.Parameters.AddWithValue("@DoB", s.DoB.ToShortDateString());

            //At last apply the command
            try
            {
                con.Open(); // Phone lagaiyoo
                cmd.ExecuteNonQuery(); // Phone ma boliyoo
                con.Close(); // Phone katiyooo
                //Inserting incoming object into the table and return operation status.
                return true;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                if (con.State!= ConnectionState.Closed)
                    con.Close();
                return false; 
            }
        }
        public List<Student> GetStudentList()
        {
        List<Student> list = new List<Student>();

            //read all students record from database and store into the list.
            cmd.CommandText = "Select  Name, Id, Address, DoB, Gender from Student";
            try 
            { 
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { 
                Student s = new Student();
                s.Id = Convert.ToInt32(reader["Id"]);//Named index use gareko Database ko table ma vayeko column ko name.
                s.Name = Convert.ToString(reader["Name"])??"No-Name";
                s.Address = Convert.ToString(reader["Address"]);
                s.DoB = DateOnly.FromDateTime(Convert.ToDateTime(reader["DoB"]));
                s.Gender = Convert.ToBoolean(reader["Gender"]);
                    list.Add(s);
                           }
            reader.Close();
            con.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine (ex.ToString());
            }
            return list; //finally return the list
        }



        public bool UpdateStudent(Student s, int oldId)
        {
            cmd.CommandText = "UPDATE Student SET Name = @Name, Address = @Address, Gender = @Gender, DoB = @DoB WHERE Id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", oldId);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Address", s.Address);
            cmd.Parameters.AddWithValue("@DoB", s.DoB.ToShortDateString());
            cmd.Parameters.AddWithValue("@Gender", s.Gender);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
                return false;
            }

        }

        public bool DeleteStudent(int Id)
        {
            cmd.CommandText = "DELETE FROM Student WHERE Id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                if (con.State != ConnectionState.Closed)
                    con.Close();
                return false;
            }
        }

    }
}
