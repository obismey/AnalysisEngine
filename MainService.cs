/*
 * Created by SharpDevelop.
 * User: obeyis
 * Date: 20/05/2015
 * Time: 15:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace XmlaService
{
	[WebServiceBinding(Namespace="urn:schemas-microsoft-com:xml-analysis")]
	[WebService(Namespace="urn:schemas-microsoft-com:xml-analysis")]
	public class MainService : System.Web.Services.WebService
	{
		public Session SessionValue {get ; set ;}
		
		public BeginSession BeginSession {get ; set ;}
		
		public EndSession EndSession {get ; set ;}
		
        [SoapHeader("EndSession")]
        [SoapHeader("SessionValue", Direction=SoapHeaderDirection.InOut)]
        [SoapHeader("BeginSession")]
        [SoapDocumentMethod("urn:schemas-microsoft-com:xml-analysis:Discover", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        [return: XmlElementAttribute("DiscoverResponse", Namespace="urn:schemas-microsoft-com:xml-analysis")]
        public DiscoverResponse Discover([XmlElementAttribute("Discover", Namespace="urn:schemas-microsoft-com:xml-analysis")] DiscoverRequest DiscoverRequest)
        {
            return null;
        }      
        
        /// <remarks/>
        [SoapHeader("EndSession")]
        [SoapHeader("Session", Direction=SoapHeaderDirection.InOut)]
        [SoapHeader("BeginSession")]
        [SoapDocumentMethod("urn:schemas-microsoft-com:xml-analysis:Execute", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        [return: XmlElementAttribute("ExecuteResponse", Namespace="urn:schemas-microsoft-com:xml-analysis")]
        public ExecuteResponse Execute([XmlElementAttribute("Execute", Namespace="urn:schemas-microsoft-com:xml-analysis")] ExecuteRequest ExecuteRequest)
        {
            return null;
        }
        
	}
	
	 /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    [XmlRootAttribute(Namespace="urn:schemas-microsoft-com:xml-analysis", IsNullable=false)]
    public partial class EndSession : System.Web.Services.Protocols.SoapHeader
    {
        
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string SessionId;
        
        /// <remarks/>
        [XmlAttributeAttribute()]
        public int mustUnderstand;
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool mustUnderstandSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    [XmlRootAttribute(Namespace="urn:schemas-microsoft-com:xml-analysis", IsNullable=false)]
    public partial class Session : System.Web.Services.Protocols.SoapHeader
    {
        
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string SessionId;
        
        /// <remarks/>
        [XmlAttributeAttribute()]
        public int mustUnderstand;
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool mustUnderstandSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    [XmlRootAttribute(Namespace="urn:schemas-microsoft-com:xml-analysis", IsNullable=false)]
    public partial class BeginSession : System.Web.Services.Protocols.SoapHeader
    {
        
        /// <remarks/>
        [XmlAttributeAttribute()]
        public int mustUnderstand;
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool mustUnderstandSpecified;
    }
    
     /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    public partial class DiscoverRequest
    {
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string RequestType;
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Xml.XmlElement Restrictions;
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Xml.XmlElement Properties;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    public partial class DiscoverResponse
    {
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Xml.XmlElement @return;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    public partial class ExecuteRequest
    {
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Xml.XmlElement Command;
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Xml.XmlElement Properties;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "4.3.3.9663-463ee024")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="urn:schemas-microsoft-com:xml-analysis")]
    public partial class ExecuteResponse
    {
        
        /// <remarks/>
        [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Xml.XmlElement @return;
    }
}
