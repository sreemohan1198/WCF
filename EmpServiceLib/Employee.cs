using System;
using System.Runtime.Serialization;

namespace EmpServiceLib
{

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Empno { get; set; }

        [DataMember]
        public string Name { get; set; }

    }
    [DataContract]
    public class Salgrade
    {
        [DataMember]
        public int GRADE { get; set; }
        [DataMember]
        public int LOSAL { get; set; }
        [DataMember]
        public int HISAL { get; set; }
    }
    [DataContract]
    public class State
    {
        [DataMember]
        public int STATEID { get; set; }
        [DataMember]
        public String CODE { get; set; }
        [DataMember]    
        public String STATE_NAME { get; set; }
    }
    [DataContract]
    public class Bonus
    {
        [DataMember]
        public string ENAME { get; set; }
        [DataMember]
        public String JOB { get; set; }
        [DataMember]
        public int SAL { get; set; }
        [DataMember]
        public int COMM { get; set; }
    }
    [DataContract]
    public class Address
    {
        [DataMember]
        public int ADDRESS_ID { get; set; }
        [DataMember]
        public string STREET { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public int STATEID { get; set; }
        [DataMember]
        public string ZIPCODE { get; set; }
        [DataMember]
        public int EMPNO { get; set; }
    }
}