namespace EsteticaSalonWeb.DTOs
{
    public class ServicioApiDto
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public decimal precio { get; set; }
        public int especialidadId { get; set; }
        public string nombreEspecialidad { get; set; } = string.Empty;
    }
}