using System;

namespace Parking.App.Dominio
{
    public class Vehiculo
    {
     
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        public Tipo Tipo { get; set; }
        public string Placa { get; set; }
        public Cliente Cliente { get; set; }
    }
}