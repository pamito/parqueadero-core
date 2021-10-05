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
    public class DetalleVehiculoModel : PageModel
    {
         private readonly IRepositorioVehiculo repositorioVehiculo;
        public Vehiculo vehiculo { get; set; }

        public DetalleVehiculoModel(IRepositorioVehiculo repositorioVehiculo){
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public void OnGet(int Id)
        {
            vehiculo = repositorioVehiculo.getVehiculo(Id);
        }
    }
}
