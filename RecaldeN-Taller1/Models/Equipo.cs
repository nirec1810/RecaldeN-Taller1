using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RecaldeN_Taller1.Models;

namespace RecaldeN_Taller1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 500)]
        public string Historia { get; set; }
        [DisplayName("Logo del equipo")]
        public string Logo { get; set; }
        [DisplayName("Nombre del estadio")]
        public string NombreEstadio { get; set; }
    }
}
