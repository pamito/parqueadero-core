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
    public class EliminarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public Vehiculo vehiculo {get; set; }

        public EliminarVehiculoModel(IRepositorioVehiculo repositorioVehiculo){
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public void OnGet(int Id)
        {
            vehiculo = repositorioVehiculo.getVehiculo(Id);
        }

        public IActionResult OnPost(Vehiculo vehiculo){
            try{
                repositorioVehiculo.removeVehiculo(vehiculo.Placa);
                return RedirectToPage("./ListarVehiculo");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
