﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace WebClient.localhost1 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LogServiceTestSoap", Namespace="http://tempuri.org/")]
    public class LogServiceTest : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public LogServiceTest() {
            this.Url = "http://localhost/Chapter24/LogServiceTest.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmployeesCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetEmployeesCount() {
            object[] results = this.Invoke("GetEmployeesCount", new object[0]);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetEmployeesCount(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetEmployeesCount", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public int EndGetEmployeesCount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
    }
}
