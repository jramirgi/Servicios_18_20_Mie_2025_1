using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_18_20.Models
{
    public class FacturaDetalle
    {
        public FACTura factura { get; set; }
        public DEtalleFActura detalle { get; set; }
    }
}