﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace GI.Framework.WorldTimeWebService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WorldTimeWebServiceSoap", Namespace="http://www.quantumsoftware.com.au/WorldTimeWebService/")]
    public partial class WorldTimeWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTimeZonesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTimeZoneInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WorldTimeWebService() {
            this.Url = "http://www.quantumsoftware.com.au/WorldTimeWebService/WorldTimeWebService.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetTimeZonesCompletedEventHandler GetTimeZonesCompleted;
        
        /// <remarks/>
        public event GetTimeZoneInfoCompletedEventHandler GetTimeZoneInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.quantumsoftware.com.au/WorldTimeWebService/GetTimeZones", RequestNamespace="http://www.quantumsoftware.com.au/WorldTimeWebService/", ResponseNamespace="http://www.quantumsoftware.com.au/WorldTimeWebService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TimeZoneInfo[] GetTimeZones() {
            object[] results = this.Invoke("GetTimeZones", new object[0]);
            return ((TimeZoneInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTimeZonesAsync() {
            this.GetTimeZonesAsync(null);
        }
        
        /// <remarks/>
        public void GetTimeZonesAsync(object userState) {
            if ((this.GetTimeZonesOperationCompleted == null)) {
                this.GetTimeZonesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTimeZonesOperationCompleted);
            }
            this.InvokeAsync("GetTimeZones", new object[0], this.GetTimeZonesOperationCompleted, userState);
        }
        
        private void OnGetTimeZonesOperationCompleted(object arg) {
            if ((this.GetTimeZonesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTimeZonesCompleted(this, new GetTimeZonesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.quantumsoftware.com.au/WorldTimeWebService/GetTimeZoneInfo", RequestNamespace="http://www.quantumsoftware.com.au/WorldTimeWebService/", ResponseNamespace="http://www.quantumsoftware.com.au/WorldTimeWebService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TimeZoneInfo GetTimeZoneInfo(string timeZoneName) {
            object[] results = this.Invoke("GetTimeZoneInfo", new object[] {
                        timeZoneName});
            return ((TimeZoneInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetTimeZoneInfoAsync(string timeZoneName) {
            this.GetTimeZoneInfoAsync(timeZoneName, null);
        }
        
        /// <remarks/>
        public void GetTimeZoneInfoAsync(string timeZoneName, object userState) {
            if ((this.GetTimeZoneInfoOperationCompleted == null)) {
                this.GetTimeZoneInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTimeZoneInfoOperationCompleted);
            }
            this.InvokeAsync("GetTimeZoneInfo", new object[] {
                        timeZoneName}, this.GetTimeZoneInfoOperationCompleted, userState);
        }
        
        private void OnGetTimeZoneInfoOperationCompleted(object arg) {
            if ((this.GetTimeZoneInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTimeZoneInfoCompleted(this, new GetTimeZoneInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.quantumsoftware.com.au/WorldTimeWebService/")]
    public partial class TimeZoneInfo {
        
        private string nameField;
        
        private string daylightNameField;
        
        private string standardNameField;
        
        private string displayNameField;
        
        private long utcOffsetTicksField;
        
        private long currentTimeTicksField;
        
        private bool isInDaylightSavingField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string DaylightName {
            get {
                return this.daylightNameField;
            }
            set {
                this.daylightNameField = value;
            }
        }
        
        /// <remarks/>
        public string StandardName {
            get {
                return this.standardNameField;
            }
            set {
                this.standardNameField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public long UtcOffsetTicks {
            get {
                return this.utcOffsetTicksField;
            }
            set {
                this.utcOffsetTicksField = value;
            }
        }
        
        /// <remarks/>
        public long CurrentTimeTicks {
            get {
                return this.currentTimeTicksField;
            }
            set {
                this.currentTimeTicksField = value;
            }
        }
        
        /// <remarks/>
        public bool IsInDaylightSaving {
            get {
                return this.isInDaylightSavingField;
            }
            set {
                this.isInDaylightSavingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void GetTimeZonesCompletedEventHandler(object sender, GetTimeZonesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTimeZonesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTimeZonesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TimeZoneInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TimeZoneInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void GetTimeZoneInfoCompletedEventHandler(object sender, GetTimeZoneInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTimeZoneInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTimeZoneInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TimeZoneInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TimeZoneInfo)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591