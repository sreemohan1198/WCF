using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceLib
{
    [DataContract]
    public class Dept
        {
            [DataMember]
            public int DEPTNO { get; set; }
            [DataMember]
            public String DNAME { get; set; }
            [DataMember]
            public String LOC { get; set; }
        }
    //[DataContract]
    //internal class Bonus
    //{
    //    [DataMember] 
    //    public string ENAME { get; set; }
    //    [DataMember]
    //    public String JOB { get; set; }
    //    [DataMember]
    //    public int SAL { get; set; }
    //    [DataMember]
    //    public int COMM { get; set; }
    //}
}
