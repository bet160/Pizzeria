//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoBD2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provision()
        {
            this.Receta = new HashSet<Receta>();
            this.ProvisionDirecta = new HashSet<ProvisionDirecta>();
        }
    
        public int Id { get; set; }
        public string nombre { get; set; }
        public short noExistencias { get; set; }
        public string ubicacion { get; set; }
        public string stockMinimo { get; set; }
        public double costoUnitario { get; set; }
        public string unidadMedida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Receta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvisionDirecta> ProvisionDirecta { get; set; }
    }
}
