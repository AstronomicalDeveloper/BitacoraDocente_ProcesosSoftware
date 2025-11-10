using BitacoraDocente.Comun.Enumeracion;
using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Modelo
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        [Required]
        public TipoDocumento TipoDocumento { get; set; }
        [Required]
        public string NumeroDocumento { get; set; } = string.Empty;
        [Required]
        public string ApellidoPaterno { get; set; } = string.Empty;
        [Required]
        public string ApellidoMaterno { get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public TipoGenero Genero { get; set; }
        [Required]
        public string NombreTutor { get; set; } = string.Empty;
        [Required]
        public string TelefonoTutor { get; set; } = string.Empty;

        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }
    }
}
