using Servicios_18_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_18_20.Clases
{
    public class clsTipoTelefono
    {
        private DBSuperEntities dbSuper = new DBSuperEntities();
        public IQueryable LlenarCombo()
        {
            return from T in dbSuper.Set<TIpoTElefono>()
                   orderby T.Nombre
                   select new
                   {
                       Codigo = T.Codigo,
                       Nombre = T.Nombre
                   };
        }
    }
}