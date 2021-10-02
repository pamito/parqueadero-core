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
    public class ListarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public ListarVehiculoModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public IEnumerable<Vehiculo>vehiculos;
        public void OnGet()
        {
            vehiculos=repositorioVehiculo.getAllVehiculos();
        }
    }
}
