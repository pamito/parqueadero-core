using System;
 namespace Parking.App.Dominio
 {
    public class Parqueadero
    {
       
         public int Id{get; set; }
         public Espacio Espacio{ get; set; }
         public Vehiculo Vehiculo { get; set; }
         public DateTime Hora_Entrada {get; set;}
         public DateTime Hora_Salida { get; set; }
            
 
     }
 }