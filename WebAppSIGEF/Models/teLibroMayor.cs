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
    
    public partial class teLibroMayor
    {
        public int iLibroMayor_id { get; set; }
        public System.DateTime dtLibroMayor_fecha { get; set; }
        public int iSolicitudFondo_id { get; set; }
        public string Property1 { get; set; }
    
        public virtual teSolicitudFondo teSolicitudFondo { get; set; }
    }
}
