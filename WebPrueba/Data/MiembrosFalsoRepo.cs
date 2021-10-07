using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Models;

 namespace WebPrueba.Data
{
    public class MiembrosFalsoRepo
    {
        public static List<Miembro> GetMiembros()
        {
            Miembro miem1 = new Miembro() {  Nombre = "Jorge", Apellido = "Castillo", Email = "Jorge@gmail.com", FechaAlta = DateTime.Today, Telefono = "1122540454", Passsword = "12345678", UserName = "koki" };
            Miembro miem2 = new Miembro() {  Nombre = "Manuel", Apellido = "Gutierrez", Email = "Manuel@gmail.com", FechaAlta = DateTime.Today, Telefono = "1168062288", Passsword = "12345778", UserName = "Manu" };
            Miembro miem3 = new Miembro() {  Nombre = "Maria", Apellido = "Gonzalez", Email = "Maru@gmail.com", FechaAlta = DateTime.Today, Telefono = "11225784956", Passsword = "1258744677", UserName = "Maru" };

            List<Miembro> miembros = new List<Miembro>();
            miembros.Add(miem1);
            miembros.Add(miem2);
            miembros.Add(miem3);
            return miembros;
        }
    }
}
