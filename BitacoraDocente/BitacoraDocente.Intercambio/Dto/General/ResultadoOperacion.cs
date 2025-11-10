using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Intercambio.Dto.General
{
    public class ResultadoOperacion<T>
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public T? Datos { get; set; } = default;

        //Cuando el resultado es exitoso.
        public static ResultadoOperacion<T> SetExito(T datos)
        {
            return new ResultadoOperacion<T>
            {
                Exito = true,
                Mensaje = string.Empty,
                Datos = datos
            };
        }

        //Cuando el resultado tiene un error.
        public static ResultadoOperacion<T> SetError(string mensaje)
        {
            return new ResultadoOperacion<T>
            {
                Exito = false,
                Mensaje = mensaje,
                Datos = default
            };
        }
    }
}
