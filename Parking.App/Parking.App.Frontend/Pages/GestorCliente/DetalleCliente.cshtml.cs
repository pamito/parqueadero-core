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
    public class DetalleClienteModel : PageModel
    {
       private readonly IRepositorioCliente repositorioCliente;
        public Cliente cliente { get; set; }

        public DetalleClienteModel(IRepositorioCliente repositorioCliente){
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet(int Id)
        {
            cliente = repositorioCliente.getCliente(Id);
        }
    }
}
