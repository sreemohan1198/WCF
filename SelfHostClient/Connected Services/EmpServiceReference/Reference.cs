﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfHostClient.EmpServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dept", Namespace="http://schemas.datacontract.org/2004/07/EmpServiceLib")]
    [System.SerializableAttribute()]
    public partial class Dept : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DEPTNOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LOCField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DEPTNO {
            get {
                return this.DEPTNOField;
            }
            set {
                if ((this.DEPTNOField.Equals(value) != true)) {
                    this.DEPTNOField = value;
                    this.RaisePropertyChanged("DEPTNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNAME {
            get {
                return this.DNAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.DNAMEField, value) != true)) {
                    this.DNAMEField = value;
                    this.RaisePropertyChanged("DNAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LOC {
            get {
                return this.LOCField;
            }
            set {
                if ((object.ReferenceEquals(this.LOCField, value) != true)) {
                    this.LOCField = value;
                    this.RaisePropertyChanged("LOC");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpServiceReference.IDept")]
    public interface IDept {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/GetDepartments", ReplyAction="http://tempuri.org/IDept/GetDepartmentsResponse")]
        System.Collections.Generic.List<SelfHostClient.EmpServiceReference.Dept> GetDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/GetDepartments", ReplyAction="http://tempuri.org/IDept/GetDepartmentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SelfHostClient.EmpServiceReference.Dept>> GetDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/AddDepartment", ReplyAction="http://tempuri.org/IDept/AddDepartmentResponse")]
        string AddDepartment(SelfHostClient.EmpServiceReference.Dept dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/AddDepartment", ReplyAction="http://tempuri.org/IDept/AddDepartmentResponse")]
        System.Threading.Tasks.Task<string> AddDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/UpdateDepartment", ReplyAction="http://tempuri.org/IDept/UpdateDepartmentResponse")]
        string UpdateDepartment(SelfHostClient.EmpServiceReference.Dept dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/UpdateDepartment", ReplyAction="http://tempuri.org/IDept/UpdateDepartmentResponse")]
        System.Threading.Tasks.Task<string> UpdateDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/DeleteDepartment", ReplyAction="http://tempuri.org/IDept/DeleteDepartmentResponse")]
        string DeleteDepartment(SelfHostClient.EmpServiceReference.Dept dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDept/DeleteDepartment", ReplyAction="http://tempuri.org/IDept/DeleteDepartmentResponse")]
        System.Threading.Tasks.Task<string> DeleteDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeptChannel : SelfHostClient.EmpServiceReference.IDept, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeptClient : System.ServiceModel.ClientBase<SelfHostClient.EmpServiceReference.IDept>, SelfHostClient.EmpServiceReference.IDept {
        
        public DeptClient() {
        }
        
        public DeptClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeptClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeptClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeptClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<SelfHostClient.EmpServiceReference.Dept> GetDepartments() {
            return base.Channel.GetDepartments();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SelfHostClient.EmpServiceReference.Dept>> GetDepartmentsAsync() {
            return base.Channel.GetDepartmentsAsync();
        }
        
        public string AddDepartment(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.AddDepartment(dept);
        }
        
        public System.Threading.Tasks.Task<string> AddDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.AddDepartmentAsync(dept);
        }
        
        public string UpdateDepartment(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.UpdateDepartment(dept);
        }
        
        public System.Threading.Tasks.Task<string> UpdateDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.UpdateDepartmentAsync(dept);
        }
        
        public string DeleteDepartment(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.DeleteDepartment(dept);
        }
        
        public System.Threading.Tasks.Task<string> DeleteDepartmentAsync(SelfHostClient.EmpServiceReference.Dept dept) {
            return base.Channel.DeleteDepartmentAsync(dept);
        }
    }
}