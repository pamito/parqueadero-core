using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
{
    public class CrearParqueaderoModel : PageModel
    {
        private readonly IRepositorioParqueadero repositorioParqueadero;
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public Parqueadero parqueadero { get; set; }
        public List<SelectListItem> vehiculos { get; set; }

        public int IdVehiculo { get; set; }
        public CrearParqueaderoModel(IRepositorioParqueadero repositorioParqueadero, IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioParqueadero = repositorioParqueadero;
            this.repositorioVehiculo = repositorioVehiculo;
            parqueadero = new Parqueadero();
            vehiculos = repositorioVehiculo.getAllVehiculo().Select(
                p => new SelectListItem
                {
                    Text = p.Placa,
                    Value = Convert.ToString(p.Id)

                }
            ).ToList();
        }


        public void OnGet()
        {
            //Parqueadero parqueadero = new Parqueadero();
        }
        public IActionResult OnPost(Parqueadero parqueadero, int IdVehiculo)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    Vehiculo vehiculo = repositorioVehiculo.getVehiculo(IdVehiculo);

                    repositorioParqueadero.addParqueadero(parqueadero);

                    parqueadero.Vehiculo = vehiculo;


                    return RedirectToPage("./ListarParqueadero");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}

