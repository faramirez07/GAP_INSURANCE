using GAP.Seguros.Entidades;
using GAP.Seguros.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GAP.Seguros.Servicio.Controllers
{
    public class ClienteController : ApiController
    {
        public IEnumerable<Cliente> Get()
        {
            using (var context = new EntidadesGAP())
            {
                var listado = context.Clientes.ToList();
                return listado;
            }
        }
    }
}
