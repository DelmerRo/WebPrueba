using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Entrada
    {
        [Key]
        public int IdEntrada { get; set; }

        [Display(Name = Alias.Titulo)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxTituloEntrada, MinimumLength = Restrictions.MinTituloEntrada, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Titulo { get; set; }

        [Display(Name = Alias.Descripcion)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxDescEntrada, MinimumLength = Restrictions.MinDescEntrada, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.DateTime, ErrorMessage = ErrMsgs.ErrMsgNotValid)]
        public DateTime Fecha { get; set; }

        public Boolean Privada { get; set; }


        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public int IdCatergia { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Categoria Categoria { get; set; }

        //Dudas sobre como tiene que se la relacion
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public int IdMiembro { get; set; }
        
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public Miembro Miembro { get; set; }
        
        //public List<Miembro> MiembrosHabilitados { get; set; }
    }
}
