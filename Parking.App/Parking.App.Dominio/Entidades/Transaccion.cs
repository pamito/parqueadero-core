using System;

namespace Parking.App.Dominio
{
   public class Transaccion
   {
        public int Id_Transaccion {get; set; }
        
        public DateTime Hora_Inicio{ get; set; }
        public DateTime Hora_Final{ get; set; }

    }
 }