using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        //Consultar todos los Administrador
        IEnumerable<Administrador> getAllAdministrador();
        //Añadir Administrador
        Administrador addAdministrador(Administrador Administrador);
        //Editar Administrador
        Administrador editAdministrador(Administrador Administrador);
        //Eliminar Administrador
        void removeAdministrador(string Identificacion);

        Administrador getAdministrador(int Id);
    }
}