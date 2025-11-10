using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;

namespace BitacoraDocente.Dominio.Modelo
{
    public class Desempenio
    {
        public int DesempenioId { get; set; }

        // Foráneas
        public int CapacidadId { get; set; }   
        public int EstudianteId { get; set; }  
        public int SesionId { get; set; }     

        // Estado y fecha
        public bool EstaLogrado { get; set; }
        public DateTime FechaRegistro { get; set; } 

        public virtual Estudiante Estudiante { get; set; } = new Estudiante();
        public virtual Capacidad Capacidad { get; set; } = new Capacidad();
        public virtual Sesion Sesion { get; set; } = new Sesion();


        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }
    }
}
