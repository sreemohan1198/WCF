using EmpServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(DeptService)))
            {
                host.Open();
                Console.WriteLine("Host Started @" + DateTime.Now.ToString());
                Console.ReadLine();


            }
        }
    }
}
