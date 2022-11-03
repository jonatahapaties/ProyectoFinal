//using AccesoDatos;
using Api.Data;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models.Mapper
{
    public class CategoriasMapper
    {
        public CategoriaDto CreateDTO(Categoria categoria)
        {
            CategoriaDto result = new CategoriaDto
            {
                Id = categoria.Id,
                Descripcion = categoria.Descripcion

            };
            return result;
        }

        public Categoria categoria(CategoriaDto categoriaDto)
        {
            return null;
        }
    }
}