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
    public class DetalleParqueaderoModel : PageModel
    {
        private readonly IRepositorioParqueadero repositorioParqueadero;
        public Parqueadero parqueadero { get; set; }

        public DetalleParqueaderoModel(IRepositorioParqueadero repositorioParqueadero){
            this.repositorioParqueadero = repositorioParqueadero;
        }
        public void OnGet(string Espacio)
        {
            parqueadero = repositorioParqueadero.getParqueadero(Espacio);
        }
    }
}
