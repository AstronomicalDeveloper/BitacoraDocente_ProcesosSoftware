using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Utilidades
{
    public static class EntidadValidador
    {
        public static List<ValidationResult> ValidarCamposRequeridosCore(object entidad)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(entidad, serviceProvider: null, items: null);
            Validator.TryValidateObject(entidad, contexto, resultados, validateAllProperties: true);

            // Validar que las propiedades string marcadas como [Required] no estén vacías
            var tipo = entidad.GetType();
            var propiedades = tipo.GetProperties();

            foreach (var propiedad in propiedades)
            {
                var requiredAttr = propiedad.GetCustomAttributes(typeof(RequiredAttribute), inherit: true).FirstOrDefault();
                if (requiredAttr != null && propiedad.PropertyType == typeof(string))
                {
                    var valor = propiedad.GetValue(entidad) as string;
                    if (string.IsNullOrWhiteSpace(valor)) // "" o solo espacios
                    {
                        resultados.Add(new ValidationResult("El campo es requerido y no puede estar vacío.", new[] { propiedad.Name }));
                    }
                }
            }

            // Validar que las enumeraciones son validas.
            // Validar que tengan la longitud minima o maxima

            return resultados;
        }

        public static ResultadoOperacion<bool> ValidarCamposRequeridos(object entidad)
        {
            var errores = ValidarCamposRequeridosCore(entidad);
            if (errores.Any())
            {
                var mensajeErrores = string.Join("\r\n", errores.Select(e =>
                {
                    var campo = string.Join(", ", e.MemberNames);
                    var traducido = TraductorErroresValidacion.Traducir(e.ErrorMessage ?? "", campo);
                    return $"Error en {campo}: {traducido}";
                }));

                return ResultadoOperacion<bool>.SetError(mensajeErrores);
            }

            return ResultadoOperacion<bool>.SetExito(true);
        }
    }
}
