using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Codigo.dev
{
    public class SakilaConsultas
    {
        public void MenuPrincipal()
        {
            string? opcion = String.Empty;
            while (opcion != "0")
            {
                DesplegarMenu();
                opcion = CapturarOpcion();
                EjecutarOpcion(opcion);
            }
        }

        public void DesplegarMenu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("     Menu Principal      ");
            Console.WriteLine("1 Consultar Actor por ID");
            Console.WriteLine("2 Consultar Actores");
            Console.WriteLine("0 Salir");
            Console.WriteLine("-------------------------");
        }

        private string? CapturarOpcion()
        {
            Console.Write("Digite la opcion deseada: ");
            var opcion = Console.ReadLine();
            return opcion;
        }

        private void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Consultar_Actor_PorId();
                    break;

                case "2":
                    Consultar_Actores();
                    break;
                case "3":

                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opcion Errorena");
                    break;
            }
        }

        private void ImprimaActor(Sakila.Model.Models.Actor elactor)
        {
            Console.WriteLine($"Id: { elactor.ActorId},  Nombre: {elactor.FirstName}, Apellido: {elactor.LastName} ");
        }
        private void Consultar_Actor_PorId()
        {
            Console.Write("Digite el ID del Actor:");
            var actorId = Console.ReadLine();
            var actorIdInt = 0;
            if (int.TryParse(actorId, out actorIdInt))
            {
                var laLogicaDeNegocio = new Sakila.BL.Interface.Actor();
                var elactor = laLogicaDeNegocio.BuscarPorID(actorIdInt);
                if (elactor == null)
                {
                    Console.WriteLine($"No se encontro actor con el ID:{actorId}");
                }
                else
                {
                    ImprimaActor(elactor);
                }
            }
        }
        private void Consultar_Actores()
        {
            var laLogicaDeNegocio = new Sakila.BL.Interface.Actor();
            var losProductos = laLogicaDeNegocio.BuscarTodos();
            if (losProductos.Count == 0)
            {
                Console.WriteLine("No se encontraron");
            }
            else
            {
                foreach (var actor in losProductos)
                {
                    ImprimaActor(actor);
                }

            }
        }
    }
}
