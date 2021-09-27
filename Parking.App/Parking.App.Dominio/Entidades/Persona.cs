using System;

namespace Parking.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_nacimento { get; set; }
        public Rol Rol { get; set; }


                
    }
}