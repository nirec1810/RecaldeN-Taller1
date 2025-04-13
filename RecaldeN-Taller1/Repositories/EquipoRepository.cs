using Microsoft.AspNetCore.Mvc;
using RecaldeN_Taller1.Models;

namespace RecaldeN_Taller1.Repositories
{
    public class EquipoRepository
    {
        public static List<Equipo> Equipos;

        static EquipoRepository()
        {
            Equipos = new List<Equipo>
            {
                new Equipo
                {
                    Id = 1,
                    Nombre = "LDU",
                    PartidosJugados = 6,
                    PartidosGanados = 3,
                    PartidosPerdidos = 2,
                    PartidosEmpatados = 1,
                    Historia = "Liga Deportiva Universitaria, conocido también como LDU, es un club deportivo ecuatoriano, originario de la ciudad de Quito. " +
                           "Fue fundado el 11 de enero de 1930, aunque sus actividades iniciaron el 23 de octubre de 1918 como un equipo deportivo estudiantil de la Universidad Central del Ecuador (UCE), " +
                           "llamado Club Universitario.",
                    Logo = "~/Imagenes/LDU.png",
                    NombreEstadio = "Estadio Rodrigo Paz Delgado"
                },
                new Equipo
                {
                    Id = 2,
                    Nombre = "Barcelona SC",
                    PartidosJugados = 6,
                    PartidosGanados = 5,
                    PartidosPerdidos = 0,
                    PartidosEmpatados = 1,
                    Historia = "Barcelona Sporting Club es un club deportivo ecuatoriano con sede en Guayaquil. Fundado el 1 de mayo de 1925 por un grupo de jóvenes ecuatorianos y un español, " +
                           "es uno de los clubes más populares y laureados del país.",
                    Logo = "~/Imagenes/Barcelona.jpg",
                    NombreEstadio = "Estadio Monumental Isidro Romero Carbo"
                },
                new Equipo
                {
                    Id = 3,
                    Nombre = "U Catolica",
                    PartidosJugados = 7,
                    PartidosGanados = 3,
                    PartidosPerdidos = 3,
                    PartidosEmpatados = 1,
                    Historia = "El Club Deportivo Universidad Católica es una institución deportiva ecuatoriana con sede en Quito, fundado el 15 de mayo de 1963. " +
                           "Está estrechamente vinculado a la Pontificia Universidad Católica del Ecuador.",
                    Logo = "~/Imagenes/Catolica.png",
                    NombreEstadio = "Estadio Olímpico Atahualpa"
                },
                new Equipo
                {
                    Id = 4,
                    Nombre = "Independiente",
                    PartidosJugados = 7,
                    PartidosGanados = 3,
                    PartidosPerdidos = 3,
                    PartidosEmpatados = 1,
                    Historia = "El Club Independiente del Valle es un club de fútbol ecuatoriano con sede en Sangolquí, cerca de Quito. " +
                           "Fundado el 1 de marzo de 1958, ha ganado reconocimiento en los últimos años por su enfoque en el desarrollo de jóvenes talentos.",
                    Logo = "~/Imagenes/Independiente.png",
                    NombreEstadio = "Estadio Banco Guayaquil"
                }
            };
        }


        public IEnumerable<Equipo> DevuelveListaRepositories()
        {
            var listado = Equipos.OrderByDescending(item => item.PartidosGanados);
            return listado;
        }

        public Equipo DevuelveEquipoPorID(int Id)
        {
            var equipo = Equipos.First(item => item.Id == Id);
            return equipo;
        }        

        public bool ActualizarEquipo(Equipo equipo)
        {
            //Logica de actualizacion
            var equipoExistente = Equipos.First(item => item.Id == equipo.Id);
            if (equipoExistente != null)
            {
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                return true;
            }
            return false; 
        }
    }
}
