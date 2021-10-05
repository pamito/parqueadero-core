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
    public class CrearVehiculoModel : PageModel
    {
 private IRepositorioVehiculo repositorioVehiculo;
        public Vehiculo vehiculo { get; set; }

        public CrearVehiculoModel (IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public void OnGet()
        {
            Vehiculo vehiculo = new Vehiculo();
        }
        public IActionResult OnPost (Vehiculo vehiculo)
        {
            repositorioVehiculo.addVehiculo(vehiculo);
            return RedirectToPage("./ListarVehiculo");
        }
    }
}
