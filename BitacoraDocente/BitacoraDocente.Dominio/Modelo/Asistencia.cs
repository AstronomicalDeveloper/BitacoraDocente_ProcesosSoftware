using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Modelo
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public int EstudianteId { get; set; } 
        public int SesionId { get; set; }   
        public int FechaId { get; set; }     

        public string Observacion { get; set; } = string.Empty;
        public bool Estado { get; set; }

        public virtual Estudiante Estudiante { get; set; } = new Estudiante();
        public virtual ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }