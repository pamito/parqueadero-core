using System;

namespace Parking.App.Dominio
{
    public class Reserva
   {
        public int Id {get; set; }
        
        public DateTime Hora_Inicio{ get; set; }
        public DateTime Hora_Final{ get; set; }
        public string Estado_Reserva{ get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Persona Persona { get; set; }
        public Parqueadero Parqueadero { get; set; }

    }
 }