using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend.Pages
{
    public class ListarClienteModel : PageModel
    {
        public IEnumerable<Cliente>clientes ;
        private readonly IRepositorioCliente repositoriocliente;
        public ListarClienteModel(IRepositorioCliente repositoriocliente)
        {
            this.repositoriocliente = repositoriocliente;
        }
        public void OnGet()
        {
            clientes = repositoriocliente.getAllClientes();
        }
    }
}

