using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Intercambio.Dto
{
    public class EstudianteDto
    {
        public int EstudianteId { get; set; }
        public GeneralDto? TipoDocumentoDto { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public GeneralDto? Genero { get; set; }
        public string NombreTutor { get; set; } = string.Empty;
        public string TelefonoTutor { get; set; } = string.Empty;
    }
}
