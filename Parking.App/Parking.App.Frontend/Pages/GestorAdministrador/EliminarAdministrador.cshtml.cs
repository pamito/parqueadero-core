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
    public class EliminarAdministradorModel : PageModel
    {
        private readonly IRepositorioAdministrador repositorioAdministrador;
        public Administrador administrador {get; set; }

        public EliminarAdministradorModel(IRepositorioAdministrador repositorioAdministrador){
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public void OnGet(int Id)
        {
            administrador = repositorioAdministrador.getAdministrador(Id);
        }

        public IActionResult OnPost(Administrador administrador){
            try{
                repositorioAdministrador.removeAdministrador(administrador.Identificacion);
                return RedirectToPage("./ListarAdministrador");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
