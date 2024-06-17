using Microsoft.EntityFrameworkCore;

namespace PaseoExpress.Shared.Data
{
    [Keyless]
    public class ObtenerVehiculosSinExistenciaHoy
    {
        public int IdVehiculo { get; set; }
        public string? Imagen { get; set; }
        public int? Anio { get; set; }
        public string? Placa { get; set; }
        public int? TarifaDiaria { get; set; }
        public int? TarifaAhorro { get; set; }
    }
}
