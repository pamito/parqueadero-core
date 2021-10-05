using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend.Pages
{
    public class ListarReservaClienteModel : PageModel
    {
         public IEnumerable<Reserva> reservar;
        private readonly IRepositorioReserva repositorioreserva;
        public ListarReservaClienteModel(IRepositorioReserva repositorioreserva)
        {
            this.repositorioreserva = repositorioreserva;
        }

        public void OnGet()
        {
            reservar = repositorioreserva.getAllReservas();
        }
    }
}
