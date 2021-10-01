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
    public class ListarGerenteModel : PageModel
    {
         public IEnumerable<Gerente>gerentes;
        private readonly IRepositorioGerente repositorioGerente;
        public ListarGerenteModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet()
        {
            gerentes = repositorioGerente.getAllGerente();
        }
    }
}
