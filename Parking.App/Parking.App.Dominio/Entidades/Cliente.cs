using System;

namespace Parking.App.Dominio

{
    public class Cliente:Persona
    {
        public Vehiculo Vehiculo { get; set; }

        public int IdCliente { get; set; }
        public DateTime fecha_Registro { get; set; }

    }
}