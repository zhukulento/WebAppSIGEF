﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelSIGEFContainer : DbContext
    {
        public ModelSIGEFContainer()
            : base("name=ModelSIGEFContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<baUnidadFinanciera> baUnidadFinanciera { get; set; }
        public virtual DbSet<baModulo> baModulo { get; set; }
        public virtual DbSet<baADM_USER> baADM_USER { get; set; }
        public virtual DbSet<baAdmin> baAdmin { get; set; }
        public virtual DbSet<paSucursal> paSucursal { get; set; }
        public virtual DbSet<caPAC> caPAC { get; set; }
        public virtual DbSet<caSolitudCaptacion> caSolitudCaptacion { get; set; }
        public virtual DbSet<mcCaja> mcCaja { get; set; }
        public virtual DbSet<mcTransaccion> mcTransaccion { get; set; }
        public virtual DbSet<mcLibroCaja> mcLibroCaja { get; set; }
        public virtual DbSet<mcConciliacionCaja> mcConciliacionCaja { get; set; }
        public virtual DbSet<mcDetalleCheque> mcDetalleCheque { get; set; }
        public virtual DbSet<peCliente> peCliente { get; set; }
        public virtual DbSet<peCAportacion> peCAportacion { get; set; }
        public virtual DbSet<msFuncionario> msFuncionario { get; set; }
        public virtual DbSet<msUsuario> msUsuario { get; set; }
        public virtual DbSet<msPassword> msPassword { get; set; }
        public virtual DbSet<msRol> msRol { get; set; }
        public virtual DbSet<msPrivilegio> msPrivilegio { get; set; }
        public virtual DbSet<msBitacora> msBitacora { get; set; }
        public virtual DbSet<teSolicitudFondo> teSolicitudFondo { get; set; }
        public virtual DbSet<teBoveda> teBoveda { get; set; }
        public virtual DbSet<teLibroMayor> teLibroMayor { get; set; }
        public virtual DbSet<teConciliacionLM> teConciliacionLM { get; set; }
        public virtual DbSet<acCajaAhorro> acCajaAhorro { get; set; }
        public virtual DbSet<acTarjetaDebito> acTarjetaDebito { get; set; }
        public virtual DbSet<acDPF> acDPF { get; set; }
        public virtual DbSet<acDetalleCajaAhorro> acDetalleCajaAhorro { get; set; }
        public virtual DbSet<acDetalleDPF> acDetalleDPF { get; set; }
        public virtual DbSet<acDetalleCredito> acDetalleCredito { get; set; }
        public virtual DbSet<coSolicitudCredito> coSolicitudCredito { get; set; }
        public virtual DbSet<coCouta> coCouta { get; set; }
        public virtual DbSet<coRequisito> coRequisito { get; set; }
        public virtual DbSet<coCarteraVigente> coCarteraVigente { get; set; }
        public virtual DbSet<coCarteraMora> coCarteraMora { get; set; }
        public virtual DbSet<coCarteraEjecucion> coCarteraEjecucion { get; set; }
        public virtual DbSet<coHistoricoCredito> coHistoricoCredito { get; set; }
        public virtual DbSet<oaATM> oaATM { get; set; }
        public virtual DbSet<oaTarjetaRetenida> oaTarjetaRetenida { get; set; }
        public virtual DbSet<oaLibroATM> oaLibroATM { get; set; }
    }
}
