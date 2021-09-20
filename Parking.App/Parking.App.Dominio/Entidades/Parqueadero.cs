using System;
 namespace Parking.App.Dominio
 {
    public class Parqueadero
    {
        public Transaccion Transaccion {get; set;}
         public int Id{get; set; }
         public string Espacio{ get; set; }
         public bool Estado{ get; set; }
 
     }
 }