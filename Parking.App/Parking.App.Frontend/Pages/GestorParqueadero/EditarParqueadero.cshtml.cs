using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.app.Persistencia;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
{
    public class EditarParqueaderoModel : PageModel
    {
        private readonly IRepositorioParqueadero repositorioparqueadero;
        public Parqueadero parqueadero { get; set; }
        public EditarParqueaderoModel(IRepositorioParqueadero repositorioparqueadero)
        {
            this.repositorioparqueadero = repositorioparqueadero;
        }
        public void OnGet(string Espacio)
        {
            parqueadero = repositorioparqueadero.getParqueadero(Espacio);
        }
        public IActionResult OnPost(Parqueadero Parqueadero)
        {            
                repositorioparqueadero.editParqueadero(Parqueadero);
                return RedirectToPage("./ListarParqueadero");            
        }
    }
}
