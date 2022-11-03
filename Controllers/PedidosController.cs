using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Api.Data;
using Api.Models;
using ApiServices;
using ProyectoFinal.Models;
using Prueba;

namespace ProyectoFinal.Controllers
{
    [RoutePrefix("Pedidos")]

    public class PedidosController : ApiController
    {

     


        /// <summary>
        /// Alta Pedido
        /// </summary>

        [HttpPost]
        [Route("AltaPedido")]
        public IEnumerable<PedidosDto> AltaPedido(PedidosDto pedidoDto)

        {
            PedidosServices pedidosServices = new PedidosServices();
            return pedidosServices.AltaPedido(pedidoDto);
        }



        /// <summary>
        /// Cancelar Pedido
        /// </summary>

        [HttpPost]
        [Route("CancelarPedido")]
        public IEnumerable<PedidosDto> CancelarPedido(int idMesa , int idPedido)

        {
            PedidosServices pedidosServices = new PedidosServices();
            return pedidosServices.CancelarPedido(idMesa,idPedido);
        }

        /// <summary>
        /// Pagar Pedido
        /// </summary>

        [HttpPost]
        [Route("PagarPedido")]
        public IEnumerable<PedidosDto> PagarPedido(int idMesa, int idPedido)

        {
            PedidosServices pedidosServices = new PedidosServices();
            return pedidosServices.CancelarPedido(idMesa, idPedido);
        }
        //public PedidoWeb pe(int IdMesa) 
        //{

        //}
        //// GET: api/Pedidoes/5
        //[ResponseType(typeof(Pedido))]
        //public IHttpActionResult GetPedido(int id)
        //{
        //    Pedido pedido = db.Pedido.Find(id);
        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(pedido);
        //}

        //// PUT: api/Pedidoes/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutPedido(int id, Pedido pedido)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != pedido.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(pedido).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PedidoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Pedidoes
        //[ResponseType(typeof(Pedido))]
        //public IHttpActionResult PostPedido(Pedido pedido)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Pedido.Add(pedido);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = pedido.Id }, pedido);
        //}

        //// DELETE: api/Pedidoes/5
        //[ResponseType(typeof(Pedido))]
        //public IHttpActionResult DeletePedido(int id)
        //{
        //    Pedido pedido = db.Pedido.Find(id);
        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Pedido.Remove(pedido);
        //    db.SaveChanges();

        //    return Ok(pedido);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool PedidoExists(int id)
        //{
        //    return db.Pedido.Count(e => e.Id == id) > 0;
        //}
    }
}