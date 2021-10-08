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
    public class CrearGerenteModel : PageModel
    {
        private IRepositorioGerente repositorioGerente;
        public Gerente gerente { get; set; }

        public CrearGerenteModel (IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet()
        {
            Gerente gerente = new Gerente();
        }
        public IActionResult OnPost (Gerente gerente)
        {
            repositorioGerente.addGerente(gerente);
            return RedirectToPage("./ListarGerente");
        }
    }
}
