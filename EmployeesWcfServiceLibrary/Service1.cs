using ClassLibraryWCF.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeesWcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<EMP> GetEmployee()
        {

            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select EMPNO,ENAME,JOB,SAL,DEPTNO FROM EMP";

            SqlDataReader reader = cmd.ExecuteReader();
            List<EMP> employeelist = new List<EMP>();

            while (reader.Read())
            {
                EMP employee = new EMP();
                employee.EMPNO = (int)reader[0];
                employee.ENAME = (string)reader[1];
                employee.JOB = (string)reader[2];
                employee.SAL = (int)reader[3];
                employee.DEPTNO = (int)reader[4];

                employeelist.Add(employee);

            }
            return employeelist;

            //conn.Close();
        }


        //public void Insert(EMP emp)
        //{
        //    String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = @"INSERT INTO[dbo].[EMP] ([EMPNO],[ENAME],[JOB],[SAL],[DEPTNO])
        //                        VALUES(@EMPNO,@ENAME,@JOB,@SAL,@DEPTNO)";
        //    EMP employee = new EMP();

        //    //Pass values to Parameters
        //    cmd.Parameters.AddWithValue("@EMPNO", emp.EMPNO);
        //    cmd.Parameters.AddWithValue("@ENAME", emp.ENAME);
        //    cmd.Parameters.AddWithValue("@JOB", emp.JOB);
        //    cmd.Parameters.AddWithValue("@SAL", emp.SAL);
        //    cmd.Parameters.AddWithValue("@DEPTNO", emp.DEPTNO);
        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine("Error Generated. Details: " + e.ToString());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //        Console.Read();
        //    }
        //    Console.Read();

        //}

        public string AddEmployee(EMP emp)
        {
            string result = "";
            try
            {
                String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                //conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO[dbo].[EMP] ([EMPNO],[ENAME],[JOB],[SAL],[DEPTNO])
                                VALUES(@EMPNO,@ENAME,@JOB,@SAL,@DEPTNO)";

                cmd.Parameters.AddWithValue("@EMPNO", emp.EMPNO);
                cmd.Parameters.AddWithValue("@ENAME", emp.ENAME);
                cmd.Parameters.AddWithValue("@JOB", emp.JOB);
                cmd.Parameters.AddWithValue("@SAL", emp.SAL);
                cmd.Parameters.AddWithValue("@DEPTNO", emp.DEPTNO);
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








        public void Update(EMP emp)
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"UPDATE [dbo].[EMP]
                                           SET [EMPNO] = @EMPNO
                                              ,[ENAME] = @ENAME
                                              ,[JOB] = @JOB,[SAL]=@SAL,[DEPTNO]=@DEPTNO
                                         WHERE EMPNO=@EMPNO";

            
            EMP employee= new EMP();
            

            cmd.Parameters.AddWithValue("@EMPNO",emp.EMPNO);
            cmd.Parameters.AddWithValue("@ENAME", emp.ENAME);
            cmd.Parameters.AddWithValue("@JOB", emp.JOB);
            cmd.Parameters.AddWithValue("@SAL", emp.SAL);
            cmd.Parameters.AddWithValue("@DEPTNO", emp.DEPTNO);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.Read();
            }
            Console.Read();
        }
    }
}
