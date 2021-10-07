using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Pregunta
    {
        [Key]
        public int IdPregunta { get; set; }

        public int IdMiembro { get; set; }

        public int IdEntrada { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxDescPregunta, MinimumLength = Restrictions.MinDescPregunta, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.DateTime, ErrorMessage = ErrMsgs.ErrMsgNotValid)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Boolean Activa { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Entrada Entrada { get; set; }

        public List<Respuesta> Respuestas { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Miembro Miembro { get; set; }
    }
}
