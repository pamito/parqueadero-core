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
    public class EditarClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }
        public EditarClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet(string Identificacion)
        {
            cliente = repositorioCliente.getCliente(Identificacion);
        }
        
        public IActionResult OnPost(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                repositorioCliente.editCliente(cliente);
                return RedirectToPage ("./ListarCliente");
            }
            else
            {
                return Page();
            }
        }    
    }
}
