using EsteticaSalonWeb.DTOs;
using System.Net.Http.Json;

namespace EsteticaSalonWeb.Data
{
    public class SaludApiService
    {
        private readonly HttpClient _http;

        // Recibimos el HttpClient mediante Inyección de Dependencias
        public SaludApiService(HttpClient http)
        {
            _http = http;
        }

        // 1. Endpoint: Listado general de servicios de salud
        public async Task<List<ServicioApiDto>> ObtenerServiciosAsync()
        {
            try
            {
                var servicios = await _http.GetFromJsonAsync<List<ServicioApiDto>>("api/salud/servicios");
                return servicios ?? new List<ServicioApiDto>();
            }
            catch (Exception)
            {
                // En caso de que la API falle o esté caída, devolvemos una lista vacía para no romper la app
                return new List<ServicioApiDto>();
            }
        }

        // 2. Endpoint: Filtrar servicios por especialidad
        public async Task<List<ServicioApiDto>> ObtenerServiciosPorEspecialidadAsync(int especialidadId)
        {
            try
            {
                var servicios = await _http.GetFromJsonAsync<List<ServicioApiDto>>($"api/salud/servicios/especialidad/{especialidadId}");
                return servicios ?? new List<ServicioApiDto>();
            }
            catch (Exception)
            {
                return new List<ServicioApiDto>();
            }
        }
    }
}