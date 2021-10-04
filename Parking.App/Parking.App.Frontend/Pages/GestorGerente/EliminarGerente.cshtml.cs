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
    public class EliminarGerenteModel : PageModel
    {

        private readonly IRepositorioGerente repositorioGerente;
        public Gerente gerente { get; set; }
        public EliminarGerenteModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet(string Identificacion)
        {
            gerente = repositorioGerente.getGerente(Identificacion);
        }
        
        public IActionResult OnPost(Gerente gerente)
        {
           try{
                repositorioGerente.removeGerente(gerente.Identificacion);
                return RedirectToPage("./ListarGerente");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }  
    }
}
