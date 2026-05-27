using EsteticaSalonWeb.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EsteticaSalonWeb.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Completada, Cancelada

        // Propiedades de navegación
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }

        public ICollection<DetalleServicio> Detalles { get; set; } = new List<DetalleServicio>();
    }
}