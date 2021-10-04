using System.Collections.Generic;
using System.Linq;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador
    {
        private readonly AppContext _contexto;

        public RepositorioAdministrador(AppContext contexto){
            this._contexto = contexto;
        }
        public Administrador addAdministrador(Administrador administrador)
        {
            Administrador nuevoAdministrador = _contexto.Add(administrador).Entity;
            _contexto.SaveChanges();
            return nuevoAdministrador;
        }


        public Administrador editAdministrador(Administrador administrador)
        {
            Administrador administradorAEditar = _contexto.Administradores.FirstOrDefault(f => f.IdAdministrador == administrador.IdAdministrador);
            if(administradorAEditar != null){
                administradorAEditar.Nombre = administrador.Nombre;
                administradorAEditar.Identificacion = administrador.Identificacion;
                administradorAEditar.Telefono = administrador.Telefono;
                administradorAEditar.Direccion = administrador.Direccion;
                administradorAEditar.Email = administrador.Email;
                administradorAEditar.Contrasena = administrador.Contrasena;
                administradorAEditar.Fecha_nacimiento = administrador.Fecha_nacimiento;
                                
                _contexto.SaveChanges();
            }
            return administradorAEditar;
        }

        

        public IEnumerable<Administrador> getAllAdministrador()
        {
            return _contexto.Administradores;
        }

        public Administrador getAdministrador(int Id)
        {
            Administrador administradorencontrado = _contexto.Administradores.FirstOrDefault(a => a.Id == Id);
            return administradorencontrado;
        }

        public void removeAdministrador(string identificacion)
        {
            Administrador administrador = _contexto.Administradores.FirstOrDefault(x => x.Identificacion == identificacion);
            if(administrador != null){
                _contexto.Administradores.Remove(administrador);
                _contexto.SaveChanges();
            }

        }

       
    }
}