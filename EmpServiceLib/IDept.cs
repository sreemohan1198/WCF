using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceLib
{
    [ServiceContract]
    public interface IDept
    {
        [OperationContract]
        List<Dept> GetDepartments();

        [OperationContract]
        String AddDepartment(Dept dept);
        [OperationContract]
        String UpdateDepartment(Dept dept);
        [OperationContract]
        String DeleteDepartment(Dept dept);

        //[OperationContract]
        //DataSet SearchDepartment(Dept dept);
    }
}
