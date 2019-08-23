﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JinRi.Notify.ServiceAgent.BuilderReceiveServiceSOA {
    using System;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessagePriorityEnum", Namespace="http://schemas.datacontract.org/2004/07/JinRi.Notify.Model")]
    public enum MessagePriorityEnum : byte {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Middle = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Low = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="PushResultEnum", Namespace="http://schemas.datacontract.org/2004/07/JinRi.Notify.Model")]
    public enum PushResultEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Abort = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pushing = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuilderReceiveServiceSOA.IDirectReceiveService")]
    public interface IDirectReceiveService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDirectReceiveService/Receive", ReplyAction="http://tempuri.org/IDirectReceiveService/ReceiveResponse")]
        JinRi.Notify.DTO.NotifyMessageResult Receive(JinRi.Notify.DTO.NotifyMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDirectReceiveService/Receive", ReplyAction="http://tempuri.org/IDirectReceiveService/ReceiveResponse")]
        System.Threading.Tasks.Task<JinRi.Notify.DTO.NotifyMessageResult> ReceiveAsync(JinRi.Notify.DTO.NotifyMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDirectReceiveService/ReceiveList", ReplyAction="http://tempuri.org/IDirectReceiveService/ReceiveListResponse")]
        JinRi.Notify.DTO.NotifyMessageResult ReceiveList(JinRi.Notify.DTO.NotifyMessage[] array);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDirectReceiveService/ReceiveList", ReplyAction="http://tempuri.org/IDirectReceiveService/ReceiveListResponse")]
        System.Threading.Tasks.Task<JinRi.Notify.DTO.NotifyMessageResult> ReceiveListAsync(JinRi.Notify.DTO.NotifyMessage[] array);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDirectReceiveServiceChannel : JinRi.Notify.ServiceAgent.BuilderReceiveServiceSOA.IDirectReceiveService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DirectReceiveServiceClient : System.ServiceModel.ClientBase<JinRi.Notify.ServiceAgent.BuilderReceiveServiceSOA.IDirectReceiveService>, JinRi.Notify.ServiceAgent.BuilderReceiveServiceSOA.IDirectReceiveService {
        
        public DirectReceiveServiceClient() {
        }
        
        public DirectReceiveServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DirectReceiveServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DirectReceiveServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DirectReceiveServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public JinRi.Notify.DTO.NotifyMessageResult Receive(JinRi.Notify.DTO.NotifyMessage message) {
            return base.Channel.Receive(message);
        }
        
        public System.Threading.Tasks.Task<JinRi.Notify.DTO.NotifyMessageResult> ReceiveAsync(JinRi.Notify.DTO.NotifyMessage message) {
            return base.Channel.ReceiveAsync(message);
        }
        
        public JinRi.Notify.DTO.NotifyMessageResult ReceiveList(JinRi.Notify.DTO.NotifyMessage[] array) {
            return base.Channel.ReceiveList(array);
        }
        
        public System.Threading.Tasks.Task<JinRi.Notify.DTO.NotifyMessageResult> ReceiveListAsync(JinRi.Notify.DTO.NotifyMessage[] array) {
            return base.Channel.ReceiveListAsync(array);
        }
    }
}