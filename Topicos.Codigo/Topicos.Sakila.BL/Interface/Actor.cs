using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Interface
{
    public class Actor
    {
        public Model.Models.Actor? BuscarPorID(int id)
        {
            var Repositorio = new Repository.Actor();
            var Resultado = Repositorio.BuscarPorID(id);
            return Resultado;
        }
        public IList<Model.Models.Actor> BuscarTodos()
        {
            var Repositorio = new Repository.Actor();
            var Resultado = Repositorio.BuscarTodos();
            return Resultado;
        }

    }
}
