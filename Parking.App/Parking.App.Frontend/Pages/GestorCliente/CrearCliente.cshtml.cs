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
    public class CrearClienteModel : PageModel
    {
        private IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }

        public CrearClienteModel (IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet()
        {
            Cliente cliente = new Cliente();
        }
        public IActionResult OnPost (Cliente cliente)
        {
            repositorioCliente.addCliente(cliente);
            return RedirectToPage("./ListarCliente");
        }
    }
}
