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
    public class EditarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar { get; set; }
        public EditarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(int Id)
        {
            auxiliar = repositorioAuxiliar.getAuxiliar(Id);
        }

        public IActionResult OnPost(Auxiliar auxiliar)
        {
            if (ModelState.IsValid)
            {
                repositorioAuxiliar.editAuxiliar(auxiliar);
                return RedirectToPage ("./index");
            }
            else
            {
                return Page();
            }

        }
    }
}
