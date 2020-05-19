using System;
using AccesoBD2;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Data.Entity;
using System.ComponentModel.Design;

namespace ServidrorPizzaItaliana
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]

    public partial class Servicios : IBuscarProducto
    {
        private BDPizzaEntities db = new BDPizzaEntities();

        public Servicios()
        {

        }

        public void BuscarPorNombre(string nombreProducto)
        {

            db.Configuration.ProxyCreationEnabled = false;

            try
            {
                var provision = (from prod in db.ProvisionSet where prod.nombre == nombreProducto select prod).First();
                Callback.Provision(provision);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback.ErrorAlRecuperarProducto("Ocurrio un error al recuperar producto");
            }
        }

        public void BuscarPorID(int idProducto)
        {
            db.Configuration.ProxyCreationEnabled = false;

            try
            {
                var provisionDirecta = (from provi in db.ProvisionDirectaSet where provi.Provision.Id == idProducto select provi).First();

                Callback.ProvicionDirecta(provisionDirecta);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback.ErrorAlRecuperarProducto("Ocurrio un error al recuperar producto");
            }
        }

        IBuscarProductoCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IBuscarProductoCallback>();
            }
        }
    }

    public partial class Servicios : IModificarProducto
    {
        public void Modificar(Provision provision, ProvisionDirecta provDirecta)
        {
            try
            {
                Provision p = new Provision();
                p = provision;

                db.ProvisionSet.Attach(p);
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();

                ProvisionDirecta d = new ProvisionDirecta();
                d = provDirecta;
                db.ProvisionDirectaSet.Attach(d);
                db.Entry(d).State = EntityState.Modified;
                db.SaveChanges();

                Callback2.RespuestaModificarProducto("Cambios Guardados");
            }
            catch (InvalidOperationException)
            {
                Callback2.RespuestaModificarProducto("Error al guardar cambios");
            }

        }

        IModificarProductoCallback Callback2
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IModificarProductoCallback>();
            }
        }
    }

    public partial class Servicios : IRegistrarIngrediente
    {
        public void RegistrarProducto(Provision provision)
        {
            try
            {
                var prov = (from p in db.ProvisionSet where p.nombre == provision.nombre select p).FirstOrDefault();

                if (prov != null) {
                    Callback3.Respuesta("El producto con el nombre: " + provision.nombre + " ya esta registrado");
                }
                else
                {
                    
                    db.ProvisionSet.Add(provision);
                    db.SaveChanges();
                    Callback3.Respuesta("Exito al registrar ingrediente");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback3.Respuesta("Error al registrar ingrediente");
            }
        }

        IRegistrarIngredienteCallback Callback3
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IRegistrarIngredienteCallback>();
            }
        }
    }

    public partial class Servicios : IBuscarIngrediente
    {

        public void BuscarIngredientePorNombre(string nombreProducto)
        {
            db.Configuration.ProxyCreationEnabled = false;

            try
            {
                var ingrediente = (from prod in db.ProvisionSet where prod.nombre == nombreProducto select prod).First();
                Callback4.Ingrediente(ingrediente);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback4.ErrorAlRecuperarIngrediente("Ocurrio un error al recuperar ingrediente");
            }
        }

        public void BuscarIngredientePorID(int idProducto)
        {
            db.Configuration.ProxyCreationEnabled = false;

            try
            {
                var ingrediente = (from provi in db.ProvisionSet where provi.Id == idProducto select provi).First();

                Callback4.Ingrediente(ingrediente);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback4.ErrorAlRecuperarIngrediente("Ocurrio un error al recuperar ingrediente");
            }
        }

        IBuscarIngredienteCallback Callback4
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IBuscarIngredienteCallback>();
            }
        }
    }

    public partial class Servicios : IEditarIngrediente
    {
        public void Editar(Provision provision)
        {
            try
            {
                Provision p = new Provision();
                p = provision;

                db.ProvisionSet.Attach(p);
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();

                Callback5.RespuestaEditarIngrediente("Cambios Guardados");
            }
            catch (InvalidOperationException)
            {
                Callback5.RespuestaEditarIngrediente("Error al guardar cambios");
            }

        }

        IEditarIngredienteCallback Callback5
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IEditarIngredienteCallback>();
            }
        }
    }

    public partial class Servicios : IRecuperarProductos
    {

        public void RecuperarProductos()
        {
            try
            {
                List<Producto> productos = new List<Producto>();

                var productosRecuperados = db.ProvisionSet.ToList();

                foreach (Provision a in productosRecuperados)
                {
                    Producto productoRecuperado = new Producto(a.Id, a.nombre, a.noExistencias, a.ubicacion, a.unidadMedida);
                    productos.Add(productoRecuperado);
                }

                Callback6.Productos(productos);

            }
            catch (InvalidOperationException)
            {
                Callback6.ErrorAlRecuperarProductos("Error al recuperar productos");
            }
        }

        IRecuperarProductosCallback Callback6
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IRecuperarProductosCallback>();
            }
        }
    }

    public partial class Servicios : IRegistrarPedidoADomicilio
    {

        public void ObtenerDatos(int idEmpleado)
        {
            List<ProductoDePedido> productos = new List<ProductoDePedido>();
            List<ProvisionVentaDirecta> provisionesVentaDirectas = new List<ProvisionVentaDirecta>();
            List<Cliente> clientes = new List<Cliente>();
            List<DireccionCliente> di = new List<DireccionCliente>();
            List<TelefonoCliente> telefonosDeCliente = new List<TelefonoCliente>();
            List<EstadoDePedido> estados = new List<EstadoDePedido>();
         
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var productosRecuperados = db.ProductoSet.Include(x => x.Categoria).ToList();
                var provisionesRecuperadas = db.ProvisionDirectaSet.Include(x => x.Provision).ToList();
                var clientesRecuperados = db.ClienteSet.Include(x => x.Direccion).Include(b => b.Telefono).ToList();
                var empleado = (from e in db.EmpleadoSet where e.IdEmpleado == idEmpleado select e).First();
                var estadosRecuperados = db.EstadoSet.ToList();

                foreach (AccesoBD2.Producto a in productosRecuperados)
                {
                    ProductoDePedido productoRecuperado = new ProductoDePedido(a.Id, a.nombre, a.descripcion, a.precioUnitario, a.restricciones, a.Categoria.categoria);
                    productos.Add(productoRecuperado);
                    Console.WriteLine(productoRecuperado.Categoria);
                }

                foreach (ProvisionDirecta a in provisionesRecuperadas)
                {
                    ProvisionVentaDirecta provisionRecuperada = new ProvisionVentaDirecta(a.Id, a.Provision.Id, a.Provision.nombre, a.Provision.costoUnitario, a.descripcion, a.restricciones);
                    provisionesVentaDirectas.Add(provisionRecuperada);
                    Console.WriteLine(provisionRecuperada.IdProvision.ToString());
                }

                foreach (AccesoBD2.Cliente a in clientesRecuperados)
                {
                    foreach (Direccion b in a.Direccion){
                        DireccionCliente dir = new DireccionCliente(b.calle, b.colonia, b.numeroExterior, b.numeroInterior);
                        di.Add(dir);

                        foreach (Telefono t in a.Telefono)
                        {
                            TelefonoCliente tel = new TelefonoCliente(t.numeroTelefono);
                            telefonosDeCliente.Add(tel);
                        }
                    }

                    Cliente clienteRecuperado = new Cliente(a.Id, a.nombre, a.apellidoPaterno, a.apellidoMaterno, di, telefonosDeCliente);
                    clientes.Add(clienteRecuperado);
                    
                }

                foreach (Estado e in estadosRecuperados)
                {
                    EstadoDePedido estado = new EstadoDePedido(e.Id, e.estadoPedido);
                    estados.Add(estado);
                }

                Callback7.Datos(clientes, productos, provisionesVentaDirectas, empleado, estados);
        }
            catch (Exception e){
                Console.WriteLine(e.StackTrace);
                Callback7.Mensaje("Mensaje de error");
            }
        }

       public void RegistrarPedido(PedidoADomicilio pedido)
        {
            try
            {

                PedidoADomicilio pd = new PedidoADomicilio();
                pd.Cliente = pedido.Cliente;
                pd.ClienteId = pedido.Cliente.Id;
                pd.Estado = pedido.Estado;
                pd.Empleado.Pedido = new List<Pedido>();
                pd.Empleado.Pedido.Add(pedido);
                pd.Cuenta = pedido.Cuenta;
                pd.fecha = pedido.fecha;
                pd.instruccionesEspeciales = pedido.instruccionesEspeciales;
                pd.Producto = pedido.Producto;
                pd.ProvisionDirecta = pedido.ProvisionDirecta;

                db.CuentaSet.Add(pedido.Cuenta);
                db.PedidoSet.Add(pd);
                db.SaveChanges();
                Callback7.Mensaje("Exito al registrar ingrediente");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
                Callback7.Mensaje("Ocurrio un error");
            }
        }

        IRegistrarPedidoADomicilioCallback Callback7
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IRegistrarPedidoADomicilioCallback>();
            }
        }
    }
}
