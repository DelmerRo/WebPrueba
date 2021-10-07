using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Miembro:Usuario
    {
        [Display(Name = Alias.Telefono)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(15, MinimumLength = 8, ErrorMessage = ErrMsgs.StrMaxMin)]
        [DataType(DataType.PhoneNumber, ErrorMessage = ErrMsgs.NoValido)]
        public string Telefono { get; set; }
        //Como Hago para tener  una lista de Miembros habilitados paraque puedan visualizar mis entradas
       // public List<Reaccion> PreguntasYRespuestasQueMeGustan { get; set; }

        //public List<Entrada> Entradas { get; set; }

        //public List<Pregunta> Preguntas { get; set; }

        //public List<Respuesta> Respuestas { get; set; }
    }
}
