using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioCliente
    {
        //Consultar todos los clientes
        IEnumerable<Cliente> getAllCliente();
        //Añadir Cliente
        Cliente addCliente(Cliente Cliente);
        //Editar Cliente
        Cliente editCliente(Cliente Cliente);
        //Eliminar Cliente
        void removeCliente(string Identificacion);

        Cliente getCliente(int Id);
    }
}