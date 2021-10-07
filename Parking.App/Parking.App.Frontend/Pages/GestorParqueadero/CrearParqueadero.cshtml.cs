using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
{
    public class CrearParqueaderoModel : PageModel
    {
        private IRepositorioParqueadero repositorioparqueadero;
        public Parqueadero parqueadero { get; set; }
        public CrearParqueaderoModel(IRepositorioParqueadero repositorioParqueadero){
            this.repositorioparqueadero = repositorioParqueadero;
        }
        public void OnGet()
        {
            Parqueadero parqueadero = new Parqueadero();
        }
        public IActionResult OnPost(Parqueadero parqueadero){
            try {    
            repositorioparqueadero.addParqueadero(parqueadero);
            return RedirectToPage("./ListarParqueadero"); 
                } 
        catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
