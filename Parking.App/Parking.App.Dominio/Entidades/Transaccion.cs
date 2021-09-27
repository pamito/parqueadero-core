using System;

namespace Parking.App.Dominio
{
   public class Transaccion
   {
        public int Id {get; set; }
        
        public DateTime Hora_Inicio{ get; set; }
        public DateTime Hora_Final{ get; set; }

    }
 }