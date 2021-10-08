using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext _contexto;
        
        public RepositorioCliente(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Cliente addCliente(Cliente cliente)
        {
            Cliente newCliente = _contexto.Add(cliente).Entity;
            _contexto.SaveChanges();
            return newCliente;
        }

        public Cliente editCliente(Cliente cliente)
        {
            Cliente clienteAEditar = _contexto.Clientes.FirstOrDefault(c=> c.Id == cliente.Id);
            if(clienteAEditar != null)
            {
                clienteAEditar.Identificacion= cliente.Identificacion;
                clienteAEditar.Nombre = cliente.Nombre;
                clienteAEditar.Email = cliente.Email;
                clienteAEditar.Direccion = cliente.Direccion;
                clienteAEditar.Contrasena = cliente.Contrasena;
                clienteAEditar.Fecha_nacimiento = cliente.Fecha_nacimiento;
                clienteAEditar.fecha_Registro= cliente.fecha_Registro;
                clienteAEditar.Telefono= cliente.Telefono;
                _contexto.SaveChanges();

            }
            return clienteAEditar;
        }

        public IEnumerable<Cliente> getAllCliente()
        {
           return _contexto.Clientes;
        }


        public Cliente getCliente(int Id)
        {
            return _contexto.Clientes.FirstOrDefault(x=> x.Id == Id);
        }

        public void removeCliente(string Identificacion)
        {
         
            Cliente cliente = _contexto.Clientes.FirstOrDefault(c => c.Identificacion == Identificacion);
            if(cliente != null){
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}