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
    public class ListarParqueaderoModel : PageModel
    {
        public IEnumerable<Parqueadero> parqueaderos;
        private readonly IRepositorioParqueadero repositorioparqueadero;
        public ListarParqueaderoModel(IRepositorioParqueadero repositorioparqueadero)
        {
            this.repositorioparqueadero = repositorioparqueadero;
        }
        public void OnGet()
        {
            parqueaderos = repositorioparqueadero.getAllParqueaderos();
        }
    }
}
