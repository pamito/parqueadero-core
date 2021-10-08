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
    public class ListarClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        public ListarClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public IEnumerable<Cliente>clientes;
        public void OnGet()
        {
            clientes=repositorioCliente.getAllCliente();
        }
    }
}
