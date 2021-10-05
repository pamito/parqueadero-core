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
    public class DetalleReservaClienteModel : PageModel
    {
        private readonly IRepositorioReserva repositorioreserva;
        public Reserva reserva { get; set; }
        public DetalleReservaClienteModel(IRepositorioReserva repositorioreserva)
        {
            this.repositorioreserva = repositorioreserva;
        }
        public void OnGet(int Id)
        {
            reserva = repositorioreserva.getReserva(Id);
        }

    }
}
