using Api.Models;
using ApiServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProyectoFinal.Controllers
{
    [RoutePrefix("Inicio")]

    public class InicioController : ApiController
    {
        [HttpGet,Route("obtenerCategorias")]
        public IEnumerable<CategoriaDto> obtenerCategorias()
        {
            InicioServices categoriasServices = new InicioServices();
            return categoriasServices.ObtenerCategorias();
        }

        [HttpGet, Route("obtenerProductos")]
        public IEnumerable<ProductosDto> obtenerProductos()
        {
            InicioServices productosServices = new InicioServices();
            return productosServices.ObtenerProductos();
        }
    }
}