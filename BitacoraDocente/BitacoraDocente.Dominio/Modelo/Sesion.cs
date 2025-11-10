using BitacoraDocente.Dominio.Utilidades;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Modelo
{
    public class Sesion
    {
        public int SesionId { get; set; }
        public int UnidadId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Proposito { get; set; } = string.Empty;
        public virtual UnidadDidactica UnidadDidactica { get; set; } = new UnidadDidactica();
        public ResultadoOperacion<bool> Validar()
        {
            var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
            return respuesta;
        }
    }
}
