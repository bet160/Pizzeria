﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteItaliaPizza.Servicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CuentaUsuario", Namespace="http://schemas.datacontract.org/2004/07/AccesoBD2")]
    [System.SerializableAttribute()]
    public partial class CuentaUsuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteItaliaPizza.Servicio.Empleado EmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCuentaUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreUsuarioField;
        
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
        public ClienteItaliaPizza.Servicio.Empleado Empleado {
            get {
                return this.EmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpleadoField, value) != true)) {
                    this.EmpleadoField = value;
                    this.RaisePropertyChanged("Empleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCuentaUsuario {
            get {
                return this.IdCuentaUsuarioField;
            }
            set {
                if ((this.IdCuentaUsuarioField.Equals(value) != true)) {
                    this.IdCuentaUsuarioField = value;
                    this.RaisePropertyChanged("IdCuentaUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.contraseñaField, value) != true)) {
                    this.contraseñaField = value;
                    this.RaisePropertyChanged("contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreUsuarioField, value) != true)) {
                    this.nombreUsuarioField = value;
                    this.RaisePropertyChanged("nombreUsuario");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/AccesoBD2")]
    [System.SerializableAttribute()]
    public partial class Empleado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteItaliaPizza.Servicio.CuentaUsuario CuentaUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string correoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string rolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
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
        public ClienteItaliaPizza.Servicio.CuentaUsuario CuentaUsuario {
            get {
                return this.CuentaUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.CuentaUsuarioField, value) != true)) {
                    this.CuentaUsuarioField = value;
                    this.RaisePropertyChanged("CuentaUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEmpleado {
            get {
                return this.IdEmpleadoField;
            }
            set {
                if ((this.IdEmpleadoField.Equals(value) != true)) {
                    this.IdEmpleadoField = value;
                    this.RaisePropertyChanged("IdEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apellidoMaterno {
            get {
                return this.apellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidoMaternoField, value) != true)) {
                    this.apellidoMaternoField = value;
                    this.RaisePropertyChanged("apellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apellidoPaterno {
            get {
                return this.apellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidoPaternoField, value) != true)) {
                    this.apellidoPaternoField = value;
                    this.RaisePropertyChanged("apellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                if ((object.ReferenceEquals(this.correoField, value) != true)) {
                    this.correoField = value;
                    this.RaisePropertyChanged("correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rol {
            get {
                return this.rolField;
            }
            set {
                if ((object.ReferenceEquals(this.rolField, value) != true)) {
                    this.rolField = value;
                    this.RaisePropertyChanged("rol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicio.IServicioPizzaItaliana", CallbackContract=typeof(ClienteItaliaPizza.Servicio.IServicioPizzaItalianaCallback))]
    public interface IServicioPizzaItaliana {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/IniciarSesion")]
        void IniciarSesion(string nombreUsuario, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/IniciarSesion")]
        System.Threading.Tasks.Task IniciarSesionAsync(string nombreUsuario, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/CerrarSesion")]
        void CerrarSesion(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/CerrarSesion")]
        System.Threading.Tasks.Task CerrarSesionAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/GuardarCuentaUsuario")]
        void GuardarCuentaUsuario(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/GuardarCuentaUsuario")]
        System.Threading.Tasks.Task GuardarCuentaUsuarioAsync(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/ModificarCuentaUsuario")]
        void ModificarCuentaUsuario(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/ModificarCuentaUsuario")]
        System.Threading.Tasks.Task ModificarCuentaUsuarioAsync(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPizzaItalianaCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/Respuesta")]
        void Respuesta(string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPizzaItaliana/DevuelveCuenta")]
        void DevuelveCuenta(ClienteItaliaPizza.Servicio.CuentaUsuario cuenta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPizzaItalianaChannel : ClienteItaliaPizza.Servicio.IServicioPizzaItaliana, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPizzaItalianaClient : System.ServiceModel.DuplexClientBase<ClienteItaliaPizza.Servicio.IServicioPizzaItaliana>, ClienteItaliaPizza.Servicio.IServicioPizzaItaliana {
        
        public ServicioPizzaItalianaClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServicioPizzaItalianaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServicioPizzaItalianaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPizzaItalianaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPizzaItalianaClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void IniciarSesion(string nombreUsuario, string contraseña) {
            base.Channel.IniciarSesion(nombreUsuario, contraseña);
        }
        
        public System.Threading.Tasks.Task IniciarSesionAsync(string nombreUsuario, string contraseña) {
            return base.Channel.IniciarSesionAsync(nombreUsuario, contraseña);
        }
        
        public void CerrarSesion(string nombreUsuario) {
            base.Channel.CerrarSesion(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task CerrarSesionAsync(string nombreUsuario) {
            return base.Channel.CerrarSesionAsync(nombreUsuario);
        }
        
        public void GuardarCuentaUsuario(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario) {
            base.Channel.GuardarCuentaUsuario(cuentaUsuario);
        }
        
        public System.Threading.Tasks.Task GuardarCuentaUsuarioAsync(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario) {
            return base.Channel.GuardarCuentaUsuarioAsync(cuentaUsuario);
        }
        
        public void ModificarCuentaUsuario(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario) {
            base.Channel.ModificarCuentaUsuario(cuentaUsuario);
        }
        
        public System.Threading.Tasks.Task ModificarCuentaUsuarioAsync(ClienteItaliaPizza.Servicio.CuentaUsuario cuentaUsuario) {
            return base.Channel.ModificarCuentaUsuarioAsync(cuentaUsuario);
        }
    }
}