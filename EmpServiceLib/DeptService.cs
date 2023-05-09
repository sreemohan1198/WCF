using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceLib
{
    public class DeptService : IDept
    {
        //GET ALL DEPARTMENT RECORDS
        public List<Dept> GetDepartments()
        {

            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [DEPTNO],[DNAME],[LOC] FROM [dbo].[DEPT]";

            SqlDataReader reader = cmd.ExecuteReader();
            List<Dept> depts = new List<Dept>();
            while (reader.Read())
            {

                Dept dept = new Dept();
                dept.DEPTNO = reader[0].GetHashCode();
                dept.DNAME = reader[1].ToString();
                dept.LOC = reader[2].ToString();
                depts.Add(dept);

            }
            return depts;

            conn.Close();
            //Console.Read();
        }


        //INSERT DEPARTMENT
        public string AddDepartment(Dept dept)
        {
            string result = "";
            try
            {
                String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                //conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO[dbo].[dept] ([DEPTNO],[DNAME],[LOC])
                                VALUES(@DEPTNO,@DNAME,@LOC)";
                //string Query = @"INSERT INTO[dbo].[dept] ([DEPTNO],[DNAME],[LOC])
                // VALUES(@DEPTNO,@DNAME,@LOC)";
                // Dept dept = new Dept();
                //dept.DEPTNO = dept.DEPTNO.GetHashCode();
                //dept.DNAME= dept.DNAME.ToString();
                //dept.LOC = dept.LOC.ToString();
                //cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@DEPTNO", dept.DEPTNO);
                cmd.Parameters.AddWithValue("@DNAME", dept.DNAME);
                cmd.Parameters.AddWithValue("@LOC", dept.LOC);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        //UPDATE DEPARTMENT
        public string UpdateDepartment(Dept dept)
        {
            string result = "";
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"UPDATE [dbo].[Dept]
                                       SET [DEPTNO] = @DEPTNO
                                          ,[DNAME] = @DNAME
                                          ,[LOC] = @LOC
                                     WHERE DEPTNO=@DEPTNO";

            //String Query = @"UPDATE [dbo].[Dept]
            //                           SET [DEPTNO] = @DEPTNO
            //                              ,[DNAME] = @DNAME
            //                              ,[LOC] = @LOC
            //                         WHERE DEPTNO=@DEPTNO";

            //cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@DEPTNO", dept.DEPTNO);
            cmd.Parameters.AddWithValue("@DNAME", dept.DNAME);
            cmd.Parameters.AddWithValue("@LOC", dept.LOC);
            conn.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            conn.Close();

            return result;
        }


        //DELETE DEPARTMENT

        public string DeleteDepartment(Dept dept)
        {
            string result = "";
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [dbo].[DEPT] WHERE DEPTNO=@DEPTNO";
            //string Query = "DELETE FROM [dbo].[Dept] WHERE DEPTNO=@DEPTNO";
            //cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@DEPTNO", dept.DEPTNO);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            result = "Record Deleted Successfully!";
            return result;
        }



        //SEARCH DEPARTMENTS
        //public List<Dept> SearchDepartment(Dept DEPTNO)
        //{
        //List<Dept> results = new List<Dept>();

        //String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
        //SqlConnection conn = new SqlConnection(connString);
        //SqlCommand cmd = new SqlCommand();
        //conn.Open();
        //cmd.Connection = conn;
        //cmd.CommandText= "SELECT * FROM [dbo].[Dept] WHERE DEPTNO=@DEPTNO";
        //cmd.Parameters.AddWithValue("@DEPTNO", DEPTNO);
        //SqlDataReader reader = cmd.ExecuteReader();
        //List<Dept> depts = new List<Dept>();
        //while (reader.Read())
        //{

        //    Dept dept = new Dept();
        //    dept.DEPTNO = reader[0].GetHashCode();
        //    dept.DNAME = reader[1].ToString();
        //    dept.LOC = reader[2].ToString();
        //    //results.Add(dept);
        //    depts.Add(dept);

        //}
        ////return results;
        //return depts;
        //conn.Close();

        //public DataSet SearchDepartment(Dept dept)
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
        //        SqlConnection conn = new SqlConnection(connString);
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = conn;
        //        //cmd.CommandText = "SELECT * FROM [dbo].[DEPT] WHERE DEPTNO=@DEPTNO";
        //        //cmd.Parameters.AddWithValue("@DEPTNO", dept.DEPTNO);


        //        string Query = "SELECT * FROM [dbo].[DEPT] WHERE DEPTNO=@DEPTNO";

        //        SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
        //        sda.SelectCommand.Parameters.AddWithValue("@DEPTNO", dept.DEPTNO);
        //        sda.Fill(ds);
        //    }

        //    catch (FaultException fex)
        //    {
        //        throw new FaultException<string>("Error:  " + fex);
        //    }


        //    return ds;

    //}
}
}
    

