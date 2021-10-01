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
    public class EditarGerenteModel : PageModel
    {
        private readonly IRepositorioGerente repositorioGerente ;
        public Gerente gerente { get; set; }

        public EditarGerenteModel(IRepositorioGerente repositorioGerente){
            this.repositorioGerente = repositorioGerente; 
        }
        public void OnGet(string Identificacion)
        {
            gerente = repositorioGerente.getGerente(Identificacion);
        }
        public IActionResult OnPost (Gerente gerente)
        {
            repositorioGerente.editGerente(gerente);
            return RedirectToPage("./ListarGerente");
        }
    }
}
