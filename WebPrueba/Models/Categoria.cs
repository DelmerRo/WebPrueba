using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Helpers;

namespace WebPrueba.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [StringLength(Restrictions.MaxNomCat, MinimumLength = Restrictions.MinNomCat, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Nombre { get; set; }
       
    }
}
