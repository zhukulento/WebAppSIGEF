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
    
    public partial class mcTransaccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mcTransaccion()
        {
            this.mcLibroCaja = new HashSet<mcLibroCaja>();
            this.mcDetalleCheque = new HashSet<mcDetalleCheque>();
            this.acDetalleCajaAhorro = new HashSet<acDetalleCajaAhorro>();
            this.acDetalleDPF = new HashSet<acDetalleDPF>();
            this.acDetalleCredito = new HashSet<acDetalleCredito>();
            this.oaLibroATM = new HashSet<oaLibroATM>();
        }
    
        public int iTransaccion_id { get; set; }
        public Nullable<int> iCaja_id { get; set; }
        public string iTipoTransaccion_fl { get; set; }
        public System.DateTime dtTransaccion_fecha { get; set; }
        public string iMoneda_fl { get; set; }
        public decimal dTransaccion_monto { get; set; }
        public int iCliente_id { get; set; }
        public string sTransaccion_desc { get; set; }
        public Nullable<int> iATM_id { get; set; }
        public int oaLibroATM_oaLibroATM_id { get; set; }
    
        public virtual mcCaja mcCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mcLibroCaja> mcLibroCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mcDetalleCheque> mcDetalleCheque { get; set; }
        public virtual peCliente peCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acDetalleCajaAhorro> acDetalleCajaAhorro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acDetalleDPF> acDetalleDPF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acDetalleCredito> acDetalleCredito { get; set; }
        public virtual oaATM oaATM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<oaLibroATM> oaLibroATM { get; set; }
    }
}