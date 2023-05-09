using NewEntityClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using NewEntityClassLibrary;

namespace CustomersServiceLibrary
{
    public class CustomerService :IService1
    {
        public List<customer> GetCustomers()
        {

            String connString = "Data Source=.;Initial Catalog=CustomerOrders;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select CustomerID,CustomerName,ContactName,Address,City,PostalCode,Country from customers";

            SqlDataReader reader = cmd.ExecuteReader();
            List<customer> customerlist = new List<customer>();
            while (reader.Read())
            {
                customer cust = new customer();
                cust.CustomerID = reader[0].GetHashCode();
                cust.CustomerName = reader[1].ToString();
                cust.ContactName = reader[2].ToString();
                cust.Address = reader[3].ToString();
                cust.City = reader[4].ToString();
                cust.PostalCode = reader[5].ToString();
                cust.Country = reader[6].ToString();
                customerlist.Add(cust);
            }
            return customerlist;

            //conn.Close();
        }

      
    }
}
