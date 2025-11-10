using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Modelo
{
    public class UnidadDidactica
    {
        public int UnidadDidacticaId { get; set; }
        public int PlanificacionId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Proposito { get; set; } = string.Empty;
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public virtual ICollection<Sesion> Sesiones { get; set; } = new List<Sesion>();

        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }
    }
}
