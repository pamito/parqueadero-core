using System;
using System.ComponentModel.DataAnnotations;

namespace Parking.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Nombre requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Identificación requerida")]
        public string Identificacion { get; set; }

       [Required(ErrorMessage="Número Telefonico requerido")]
        public string Telefono { get; set; }

        
        public string Direccion { get; set; }

       [DataType(DataType.EmailAddress,ErrorMessage = "El email no es correcto")]
        public string Email { get; set; }
        [Required,DataType(DataType.Password),StringLength(12, MinimumLength = 8,ErrorMessage="La contraseña debe tener minimo 8 caracteres")]
        public string Contrasena { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        


                
    }
}