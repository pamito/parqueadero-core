using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.app.Persistencia;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
{
    public class indexModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public indexModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public IEnumerable<Auxiliar>auxiliares;
        public void OnGet()
        {
            auxiliares=repositorioAuxiliar.getAllAuxiliar();
        }
    }
}
