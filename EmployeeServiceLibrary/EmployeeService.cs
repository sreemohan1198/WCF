using EmpClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceLibrary
{
   public class EmployeeService :IService1
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
    }
}
