using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GAP.Seguros.WebAPI
{
    public class PolizaController2 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<GAP.Seguros.ModeloDatos.Poliza> Get()
        {
            using (var context = new GAP.Seguros.ModeloDatos.EntidadesGAP())
            {
                var listado = context.Polizas.ToList();
                return listado;
            }
            }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}