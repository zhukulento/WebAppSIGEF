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
    
    public partial class coCredito : coSolicitudCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coCredito()
        {
            this.coCouta = new HashSet<coCouta>();
            this.coCarteraVigente = new HashSet<coCarteraVigente>();
            this.coCarteraMora = new HashSet<coCarteraMora>();
            this.coCarteraEjecucion = new HashSet<coCarteraEjecucion>();
            this.coHistoricoCredito = new HashSet<coHistoricoCredito>();
        }
    
        public System.DateTime dtCredito_aprobacion { get; set; }
        public System.DateTime dtCredito_desembolso { get; set; }
        public int iCredito_cuotas { get; set; }
        public System.DateTime dtCredito_vencimiento { get; set; }
        public int iCredito_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coCouta> coCouta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coCarteraVigente> coCarteraVigente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coCarteraMora> coCarteraMora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coCarteraEjecucion> coCarteraEjecucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coHistoricoCredito> coHistoricoCredito { get; set; }
    }
}
