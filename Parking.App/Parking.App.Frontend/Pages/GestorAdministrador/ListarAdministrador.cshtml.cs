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
    public class ListarAdministradorModel : PageModel
    {
        private readonly IRepositorioAdministrador repositorioAdministrador;
        public ListarAdministradorModel(IRepositorioAdministrador repositorioAdministrador)
        {
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public IEnumerable<Administrador>administradores;
        public void OnGet()
        {
             administradores=repositorioAdministrador.getAllAdministrador();
        }
    }
}
