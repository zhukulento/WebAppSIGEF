//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppSIGEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class teSolicitudFondo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public teSolicitudFondo()
        {
            this.teLibroMayor = new HashSet<teLibroMayor>();
            this.mcLibroCaja = new HashSet<mcLibroCaja>();
        }
    
        public int iSolicitudFondo_id { get; set; }
        public System.DateTime dtSolicitud_fecha { get; set; }
        public decimal dSolicitud_monto { get; set; }
        public int iMoneda_fl { get; set; }
        public int iBoveda_id { get; set; }
        public int iCaja_id { get; set; }
    
        public virtual teBoveda teBoveda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<teLibroMayor> teLibroMayor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mcLibroCaja> mcLibroCaja { get; set; }
        public virtual mcCaja mcCaja { get; set; }
    }
}
