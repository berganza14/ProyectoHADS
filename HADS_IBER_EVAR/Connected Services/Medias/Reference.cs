﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HADS_IBER_EVAR.Medias {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Medias.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/obtenerMedia", ReplyAction="http://tempuri.org/IService/obtenerMediaResponse")]
        double obtenerMedia(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/obtenerMedia", ReplyAction="http://tempuri.org/IService/obtenerMediaResponse")]
        System.Threading.Tasks.Task<double> obtenerMediaAsync(string codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : HADS_IBER_EVAR.Medias.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<HADS_IBER_EVAR.Medias.IService>, HADS_IBER_EVAR.Medias.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double obtenerMedia(string codigo) {
            return base.Channel.obtenerMedia(codigo);
        }
        
        public System.Threading.Tasks.Task<double> obtenerMediaAsync(string codigo) {
            return base.Channel.obtenerMediaAsync(codigo);
        }
    }
}
