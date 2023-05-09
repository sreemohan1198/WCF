using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceLib
{
    [ServiceContract]
    internal interface IEmployee
    {
        [OperationContract]
        List<Employee> GetEmployees();


    }
}
