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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class ImagenesProducto
    {
        public int idImagen { get; set; }
        public string NombreImagen { get; set; }
        public int idProducto { get; set; }
        [JsonIgnore]
        public virtual PRODucto PRODucto { get; set; }
    }
}
