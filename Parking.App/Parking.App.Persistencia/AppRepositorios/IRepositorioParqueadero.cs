using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioParqueadero
    {
        //Consultar todos los Parqueadero
        IEnumerable<Parqueadero> getAllParqueaderos();
        //Añadir Parqueadero
        Parqueadero addParqueadero(Parqueadero Parqueadero);
        //Editar Parqueadero
        Parqueadero editParqueadero(Parqueadero Parqueadero);
        //Eliminar Parqueadero
        void removeParqueadero(int Id);

        Parqueadero getParqueadero(int Id);
    }
}