using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Modelo
{
    public class Planificacion
    {
        public int PlanificacionId { get; set; }
        public int AreaCurricularId { get; set; }
        public DateOnly AnioEscolar { get; set; }
        public string Proposito { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string SeccionGrado { get; set; } = string.Empty;

        public virtual AreaCurricular AreaCurricular { get; set; } = new AreaCurricular();
        public virtual ICollection<UnidadDidactica> { get; set; } = new List<UnidadDidactica>();

        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }
    }
}
