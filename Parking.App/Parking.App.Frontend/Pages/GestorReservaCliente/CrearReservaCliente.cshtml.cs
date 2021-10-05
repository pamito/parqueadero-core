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
    public class CrearReservaClienteModel : PageModel
    {
        private IRepositorioReserva repositorioreserva;
        public Reserva reserva { get; set; }
        public CrearReservaClienteModel(IRepositorioReserva repositorioReserva){
            this.repositorioreserva = repositorioReserva;
        }
        public void OnGet()
        {
            Reserva reserva = new Reserva();
        }

        public IActionResult OnPost(Reserva reserva){
            try {    
            repositorioreserva.addReserva(reserva);
            return RedirectToPage("./ListarReservaCliente"); 
                } 
        catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
