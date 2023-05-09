using SelfHostClient.EmpServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new DeptClient("BasicHttpBinding_IDept");
            List<Dept> depts = client.GetDepartments();
           // var dept = client.AddDepartment();
           
        }
    }
}
