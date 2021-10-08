using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioGerente
    {
        //Consultar todos los Gerente
        IEnumerable<Gerente> getAllGerente();
        //Añadir Gerente
        Gerente addGerente(Gerente Gerente);
        //Editar Gerente
        Gerente editGerente(Gerente Gerente);
        //Eliminar Gerente
        void removeGerente(string Identificacion);

        Gerente getGerente(int Id);
    }
}