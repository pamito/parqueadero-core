using System.Collections.Generic;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public interface IRepositorioReserva
    {
        //Consultar todos los Reserva
        IEnumerable<Reserva> getAllReservas();
        //Añadir Reserva
        Reserva addReserva(Reserva Reserva);
        //Editar Reserva
        Reserva editReserva(Reserva Reserva);
        //Eliminar Reserva
        void removeReserva(int Id);

        Reserva getReserva(int Id);
    }
}