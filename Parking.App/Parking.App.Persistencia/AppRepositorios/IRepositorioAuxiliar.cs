using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        //Consultar todos los Auxiliar
        IEnumerable<Auxiliar> getAllAuxiliar();
        //Añadir Auxiliar
        Auxiliar addAuxiliar(Auxiliar Auxiliar);
        //Editar Auxiliar
        Auxiliar editAuxiliar(Auxiliar Auxiliar);
        //Eliminar Auxiliar
        void removeAuxiliar(int Identificacion);

        Auxiliar getAuxiliar(int Identificacion);
    }
}