//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", ConfigurationName="providerInterfacePing")]
public interface providerInterfacePing
{
    
    // CODEGEN: Generating message contract since the operation pubPing is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute()]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    pubPingResponse1 pubPing(pubPingRequest1 request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubPingRequest
{
    
    private string reqIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubPingResponse
{
    
    private string reqIDField;
    
    private string respCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string respCode
    {
        get
        {
            return this.respCodeField;
        }
        set
        {
            this.respCodeField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubPingRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubPingRequest pubPingRequest;
    
    public pubPingRequest1()
    {
    }
    
    public pubPingRequest1(pubPingRequest pubPingRequest)
    {
        this.pubPingRequest = pubPingRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubPingResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubPingResponse pubPingResponse;
    
    public pubPingResponse1()
    {
    }
    
    public pubPingResponse1(pubPingResponse pubPingResponse)
    {
        this.pubPingResponse = pubPingResponse;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface providerInterfacePingChannel : providerInterfacePing, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class providerInterfacePingClient : System.ServiceModel.ClientBase<providerInterfacePing>, providerInterfacePing
{
    
    public providerInterfacePingClient()
    {
    }
    
    public providerInterfacePingClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public providerInterfacePingClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public providerInterfacePingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public providerInterfacePingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    pubPingResponse1 providerInterfacePing.pubPing(pubPingRequest1 request)
    {
        return base.Channel.pubPing(request);
    }
    
    public pubPingResponse pubPing(pubPingRequest pubPingRequest)
    {
        pubPingRequest1 inValue = new pubPingRequest1();
        inValue.pubPingRequest = pubPingRequest;
        pubPingResponse1 retVal = ((providerInterfacePing)(this)).pubPing(inValue);
        return retVal.pubPingResponse;
    }
}