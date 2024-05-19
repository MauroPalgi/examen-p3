using Datos.ContextoEF;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class RepositorioProducto
    {
        public PreparacionContext Contexto { get; set; }
        public RepositorioProducto(PreparacionContext context)
        {
            Contexto = context;
        }

        public void Eliminar(int id)
        {

        }

        public Producto obtenerProducto(int id)
        {
            return new Producto();
        }
    }
}
