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
    public class EditarGerenteModel : PageModel
    {
       private readonly IRepositorioGerente repositorioGerente;
        public Gerente gerente { get; set; }
        public EditarGerenteModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet(int Id)
        {
            gerente = repositorioGerente.getGerente(Id);
        }
        public IActionResult OnPost(Gerente gerente)
        {
            if (ModelState.IsValid)
            {
                repositorioGerente.editGerente(gerente);
                return RedirectToPage ("./ListarGerente");
            }
            else
            {
                return Page();
            }

        }
    }
}
