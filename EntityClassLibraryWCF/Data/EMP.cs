//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityClassLibraryWCF.Data
{
    using System;
    using System.Collections.Generic;

    public partial class EMP
    {
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public Nullable<int> MGR { get; set; }
        public Nullable<System.DateTime> HIREDATE { get; set; }
        public Nullable<int> SAL { get; set; }
        public Nullable<int> COMM { get; set; }
        public Nullable<int> DEPTNO { get; set; }
        public string EMAIL { get; set; }
    }

    //[ServiceContract]
    //public interface IEmpInterface
    //{
    //    [OperationContract]
    //    void Delete(int EMPNO);
    //    [OperationContract]
    //    void Insert(int EMPNO);
    //    [OperationContract]
    //    List<EMP> GetEmp();
    //    [OperationContract]
    //    void Update(int EMPNO,String ENAME,String JOB,int MGR,DateTime HIREDATE,int SAL,int COMM,int DEPTNO,String EMAIL);
    //}

}
