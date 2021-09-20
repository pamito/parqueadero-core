using System;

namespace Parking.App.Dominio
{
    public class Usuario:Persona
    {
        public int Id_User {get; set;}
        public string Posicion {get; set;}
        public string Contraseña {get; set;}
        public string Nom_User {get; set;}
                
    }
}