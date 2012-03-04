﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clienttasks.meetingsservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MeetingData", Namespace="http://schemas.datacontract.org/2004/07/services.datamodel")]
    [System.SerializableAttribute()]
    public partial class MeetingData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MeetingEventsData", Namespace="http://schemas.datacontract.org/2004/07/services.datamodel")]
    [System.SerializableAttribute()]
    public partial class MeetingEventsData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartsAtField;
        
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
        public string EventName {
            get {
                return this.EventNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EventNameField, value) != true)) {
                    this.EventNameField = value;
                    this.RaisePropertyChanged("EventName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StartsAt {
            get {
                return this.StartsAtField;
            }
            set {
                if ((object.ReferenceEquals(this.StartsAtField, value) != true)) {
                    this.StartsAtField = value;
                    this.RaisePropertyChanged("StartsAt");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="meetingsservice.IMeetingsService")]
    public interface IMeetingsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeetingsService/GetAllMeetings", ReplyAction="http://tempuri.org/IMeetingsService/GetAllMeetingsResponse")]
        clienttasks.meetingsservice.MeetingData[] GetAllMeetings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeetingsService/GetAllEventsInMeeting", ReplyAction="http://tempuri.org/IMeetingsService/GetAllEventsInMeetingResponse")]
        clienttasks.meetingsservice.MeetingEventsData[] GetAllEventsInMeeting(string theMeetingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeetingsServiceChannel : clienttasks.meetingsservice.IMeetingsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeetingsServiceClient : System.ServiceModel.ClientBase<clienttasks.meetingsservice.IMeetingsService>, clienttasks.meetingsservice.IMeetingsService {
        
        public MeetingsServiceClient() {
        }
        
        public MeetingsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MeetingsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeetingsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeetingsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public clienttasks.meetingsservice.MeetingData[] GetAllMeetings() {
            return base.Channel.GetAllMeetings();
        }
        
        public clienttasks.meetingsservice.MeetingEventsData[] GetAllEventsInMeeting(string theMeetingId) {
            return base.Channel.GetAllEventsInMeeting(theMeetingId);
        }
    }
}
