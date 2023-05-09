using IISHotClient.IISServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IISHostClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new DeptClient("basicHttpBinding");
            List<Dept> depts = client.GetDepartments();
           
        }
    }
}
