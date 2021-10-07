using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Models;

namespace WebPrueba.Data
{
    public class UsuarioFalsoRepo
    {
        public static List<Usuario> GetUsuarios()
        {
            Usuario u1 = new Usuario() {  Nombre = "Mateo", Apellido = "Hyland", Email = "Hyland@gmail.com", FechaAlta = DateTime.Today,  Passsword = "12345678", UserName = "Mat" };
            Usuario u2 = new Usuario() {  Nombre = "Ursula", Apellido = "Martinez", Email = "Ursu@gmail.com", FechaAlta = DateTime.Today,  Passsword = "12345778", UserName = "Ursu" };
            Usuario u3 = new Usuario() {  Nombre = "Gonzalp", Apellido = "Florentin", Email = "Gonza@gmail.com", FechaAlta = DateTime.Today,  Passsword = "1258744677", UserName = "Gonza" };

            //Usuario m1 = new Miembro() { Nombre = "Jorge", Apellido = "Castillo", Email = "Jorge@gmail.com", FechaAlta = DateTime.Today, Telefono = "1122540454", Passsword = "12345678", UserName = "koki" };
            //Usuario m2 = new Miembro() { Nombre = "Manuel", Apellido = "Gutierrez", Email = "Manuel@gmail.com", FechaAlta = DateTime.Today, Telefono = "1168062288", Passsword = "12345778", UserName = "Manu" };
            //Usuario m3 = new Miembro() { Nombre = "Maria", Apellido = "Gonzalez", Email = "Maru@gmail.com", FechaAlta = DateTime.Today, Telefono = "11225784956", Passsword = "1258744677", UserName = "Maru" };
            //usuarios.Add(m1);
            //usuarios.Add(m2);
            //usuarios.Add(m3);
            
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(u1);
            usuarios.Add(u2);
            usuarios.Add(u3);
            return usuarios;
        }
    }
}
