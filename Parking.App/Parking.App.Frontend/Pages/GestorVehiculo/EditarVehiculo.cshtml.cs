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
    public class EditarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioCliente repositorioCliente;
        public Vehiculo vehiculo { get; set; }
        public List<SelectListItem> clientes { get; set;}
        public int IdCliente { get; set; }

        public EditarVehiculoModel(IRepositorioVehiculo repositorioVehiculo, IRepositorioCliente repositorioCliente)
        {
            this.repositorioVehiculo = repositorioVehiculo;
            this.repositorioCliente = repositorioCliente;
            clientes = repositorioCliente.getAllCliente().Select(
                c => new SelectListItem
                {
                    Text = c.Identificacion,
                    Value = Convert.ToString(c.Id)
                }
            ).ToList();
        
        }
        public void OnGet(int Id)
        {
            vehiculo = repositorioVehiculo.getVehiculo(Id);
        }

        public IActionResult OnPost(Vehiculo vehiculo, int IdCliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente cliente = repositorioCliente.getCliente(IdCliente);

                    vehiculo.Cliente = cliente;

                    repositorioVehiculo.editVehiculo(vehiculo);

                    return RedirectToPage("./ListarVehiculo");
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
