using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ContactApp
{
    public static class Datalayer
    {
        public const string constring = "Data Source= localhost; Initial Catalog = ContactDb1; Integrated Security = SSPI";
        private static SqlConnection conn = new SqlConnection(constring);
        private static SqlCommand cmd = new SqlCommand("", conn);
        private static SqlDataReader reader = null;
        public static List<AddressList> GetAddressList()
        {
            List<AddressList> list = new List<AddressList>();
            try
            {
                conn.Open();
                cmd.CommandText = "Select * from AddressList";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AddressList addr = new AddressList();
                    addr.AddressId = Convert.ToInt16(reader["Address"]);
                    addr.AddressName = Convert.ToString(reader["AddressName"]);
                    addr.PostalCode = Convert.ToString(reader["PostalCode"]);
                    list.Add(addr);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            return list;
        }
    }
}
