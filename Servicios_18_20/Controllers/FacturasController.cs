﻿using Servicios_18_20.Clases;
using Servicios_18_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Servicios_18_20.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Facturas")]
    [Authorize]
    public class FacturasController : ApiController
    {
        [HttpGet]
        [Route("ListarProductos")]
        public IQueryable ListarProductos(int NumeroFactura)
        {
            clsFactura Factura = new clsFactura();
            return Factura.ListarProductos(NumeroFactura);
        }
        [HttpPost]
        [Route("GrabarFactura")]
        public string GrabarFactura([FromBody] FacturaDetalle factura)
        {
            clsFactura Factura = new clsFactura();
            Factura.factura = factura.factura;
            Factura.detalleFactura = factura.detalle;
            return Factura.GrabarFactura();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int NumeroDetalle)
        {
            clsFactura Factura = new clsFactura();
            return Factura.EliminarProducto(NumeroDetalle);
        }
    }
}