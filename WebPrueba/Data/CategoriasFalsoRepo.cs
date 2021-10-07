using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Models;

namespace WebPrueba.Data
{
    public class CategoriasFalsoRepo
    {
        public static List<Categoria> GetCategorias()
        {
        Categoria cat1 = new Categoria() { Nombre = "Tecnología" };
        Categoria cat2 = new Categoria() { Nombre = "Espectáculo" };
        Categoria cat3 = new Categoria() { Nombre = "Cine" };
        Categoria cat4 = new Categoria() { Nombre = "Música" };
        Categoria cat5 = new Categoria() { Nombre = "Cine" };
        Categoria cat6 = new Categoria() { Nombre = "Entretenimiento" };

        List<Categoria> categorias = new List<Categoria>();
            categorias.Add(cat1);
            categorias.Add(cat2);
            categorias.Add(cat3);
            categorias.Add(cat4);
            categorias.Add(cat5);
            categorias.Add(cat6);
            return categorias;
        }
    }
}
