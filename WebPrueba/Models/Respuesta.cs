using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Respuesta
    {
     
        public int IdRespuesta { get; set; }

        public int IdPregunta { get; set; }

        public int IdMiembro { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxDescRespuesta, MinimumLength = Restrictions.MinDescRespuesta, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Pregunta Pregunta { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Miembro Miembro { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.DateTime, ErrorMessage = ErrMsgs.ErrMsgNotValid)]
        public DateTime Fecha { get; set; }

        public List<Reaccion> Reacciones { get; set; }
    }
}
