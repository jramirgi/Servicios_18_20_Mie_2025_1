//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_18_20.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRoductoPRoveedor
    {
        public int Codigo { get; set; }
        public string Documento { get; set; }
        public int CodigoProducto { get; set; }
        public int ValorUnitario { get; set; }
        public System.DateTime FechaCotizacion { get; set; }
        public System.DateTime FechaValidez { get; set; }
    
        public virtual PRODucto PRODucto { get; set; }
        public virtual PROVeedor PROVeedor { get; set; }
    }
}
