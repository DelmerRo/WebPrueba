using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

         [Display(Name = Alias.UserName)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength( Restrictions.MaxNomUser, MinimumLength = Restrictions.MinNomUser, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string UserName { get; set; }

        [Display(Name = Alias.Nombre)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxNom, MinimumLength = Restrictions.MinNom, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Nombre { get; set; }

        [Display(Name = Alias.Apellido)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictions.MaxApe, MinimumLength =Restrictions.MinApe, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Apellido { get; set; }

        [Display(Name = Alias.Email)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.EmailAddress, ErrorMessage = ErrMsgs.NoValido)]
        public string Email { get; set; }

        [Display(Name = Alias.FechaAlta)]
        [DataType(DataType.DateTime, ErrorMessage = ErrMsgs.ErrMsgNotValid)]
        public DateTime FechaAlta { get; set; }

        [Display(Name = Alias.Contraseña)]
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.Password, ErrorMessage = ErrMsgs.NoValido)]
        [StringLength(Restrictions.MaxPassword, MinimumLength = Restrictions.MinPassword, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Passsword { get; set; }
       
        [Display(Name = Alias.NombreCompleto)]
        public string NombreCompleto
        {
            get
            {
                return $"{Apellido.ToUpper()}, {Nombre}";
            }
        }
    }
}
