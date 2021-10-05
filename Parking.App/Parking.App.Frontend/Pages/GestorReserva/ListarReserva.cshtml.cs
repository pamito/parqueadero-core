using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.app.Persistencia;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend.Pages
{
    public class ListarReservaModel : PageModel
    {
        public IEnumerable<Reserva> reservar;
        private readonly IRepositorioReserva repositorioreserva;
        public ListarReservaModel(IRepositorioReserva repositorioreserva)
        {
            this.repositorioreserva = repositorioreserva;
        }

        public void OnGet()
        {
            reservar = repositorioreserva.getAllReservas();
        }
    }
}