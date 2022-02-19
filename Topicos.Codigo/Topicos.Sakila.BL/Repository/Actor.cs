using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Sakila.Model.Models;

namespace Topicos.Sakila.BL.Repository
{
    internal class Actor
    {
        private readonly sakilaContext _contexto = new();

        public Model.Models.Actor? BuscarPorID(int id)
        {
            var resultado = _contexto.Actors.Find(id);
            return resultado;
        }
        public IList<Model.Models.Actor> BuscarTodos()
        {
            var resultado = _contexto.Actors.ToList();
            return resultado;
        }

    }

}
