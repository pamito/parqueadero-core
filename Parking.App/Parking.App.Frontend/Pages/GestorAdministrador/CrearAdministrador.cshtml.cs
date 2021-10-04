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
    public class CrearAdministradorModel : PageModel
    {
        private IRepositorioAdministrador repositorioAdministrador;
        public Administrador administrador { get; set; }

        public CrearAdministradorModel (IRepositorioAdministrador repositorioAdministrador)
        {
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public void OnGet()
        {
            Administrador administrador = new Administrador();
        }
        public IActionResult OnPost (Administrador administrador)
        {
            repositorioAdministrador.addAdministrador(administrador);
            return RedirectToPage("./ListarAdministrador");
        }
    }    
}
