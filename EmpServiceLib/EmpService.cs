using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceLib
{
    public class EmpService : IEmployee
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> emps = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.Empno = 1;
            emp1.Name = "Scott";
            Employee emp2 = new Employee();
            emp2.Empno = 2;
            emp2.Name = "JOHN";
            emps.Add(emp1);
            emps.Add(emp2);
            return emps;
            //emps.Add(new Employee(1, "Scott")); we have to generate contructore for Employee in class file

            //  throw new NotImplementedException();
        }
    }
}
