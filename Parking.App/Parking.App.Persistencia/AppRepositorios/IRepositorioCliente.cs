using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioCliente
    {
        //Consultar todos los clientes
        IEnumerable<Cliente> getAllClientes();
        //Añadir Cliente
        Cliente addCliente(Cliente cliente);
        //Editar Cliente
        Cliente editCliente(Cliente cliente);
        //Eliminar Cliente
        void removeCliente(string Identificacion);

        Cliente getCliente(int Id);
    }
}