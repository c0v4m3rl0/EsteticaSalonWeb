using EsteticaSalonWeb.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EsteticaSalonWeb.Models
{
    public class DetalleServicio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CitaId { get; set; }

        [Required]
        public int ServicioApiId { get; set; } // ID del servicio que viene de la API externa

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        // Propiedad de navegación
        [ForeignKey("CitaId")]
        public Cita? Cita { get; set; }
    }
}