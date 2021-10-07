using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Reaccion
    {
        [Key]
        public int IdReaccion { get; set; }

        public int IdRespuesta { get; set; }

        public int IdMiembro { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Respuesta Respuesta { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Miembro Miembro { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.DateTime, ErrorMessage = ErrMsgs.ErrMsgNotValid)]
        public DateTime Fecha { get; set; }

        public Boolean MeGusta { get; set; }
    }
}
