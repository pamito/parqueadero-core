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
    public class EliminarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar {get; set; }

        public EliminarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(int Id)
        {
            auxiliar = repositorioAuxiliar.getAuxiliar(Id);
        }

        public IActionResult OnPost(Auxiliar auxiliar){
            try{
                repositorioAuxiliar.removeAuxiliar(auxiliar.Identificacion);
                return RedirectToPage("./index");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
