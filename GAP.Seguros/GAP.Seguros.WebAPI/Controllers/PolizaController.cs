using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GAP.Seguros.ModeloDatos;
namespace GAP.Seguros.WebAPI.Controllers
{
    public class PolizaController : ApiController
    {
        [HttpGet]
        public IEnumerable<Poliza> Get()
        {
            using (var context = new EntidadesGAP())
            {
                var listado = context.Polizas.ToList();
                return listado;
            }

        }

        [HttpGet]
        public Poliza Get(int IdPoliza)
        {
            using (var context = new EntidadesGAP())
            {
                var poliza = context.Polizas.FirstOrDefault(x => x.IdPoliza == IdPoliza);
                return poliza;
            }
        }

        [HttpPost]
        public bool Post(Poliza poliza)
        {
            using (var context = new EntidadesGAP())
            {
                context.Polizas.Add(poliza);
                return context.SaveChanges() > 0;
            }

         }

        [HttpPut]
        public bool Put(Poliza poliza)
        {
            using (var context = new EntidadesGAP())
            {
                var polizaActualizar = context.Polizas.FirstOrDefault(x => x.IdPoliza == poliza.IdPoliza);
                polizaActualizar.IdTipoPoliza = poliza.IdTipoPoliza;
                polizaActualizar.Inicio = poliza.Inicio;
                polizaActualizar.Duracion = poliza.Duracion;
                polizaActualizar.Precio = poliza.Precio;
                poliza.IdTipoRiesgo = poliza.IdTipoRiesgo;
                poliza.Activo = poliza.Activo;
                polizaActualizar.UsuarioModificacion = poliza.UsuarioModificacion;
                polizaActualizar.FechaModificacion = poliza.FechaModificacion;
                return context.SaveChanges() > 0;
            }

         }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new EntidadesGAP())
            {
                var polizaEliminar = context.Polizas.FirstOrDefault(x => x.IdPoliza == id);
                context.Polizas.Remove(polizaEliminar);
                return context.SaveChanges() > 0;
            }
        }
    }
}
