using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        //Consultar todos los Vehiculo
        IEnumerable<Vehiculo> getAllVehiculo();
        //Añadir Vehiculo
        Vehiculo addVehiculo(Vehiculo Vehiculo);
        //Editar Vehiculo
        Vehiculo editVehiculo(Vehiculo Vehiculo);
        //Eliminar Vehiculo
        void removeVehiculo(string Placa);

        Vehiculo getVehiculo(string Placa);
    }
}