using System.Collections.Generic;
using System.Linq;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioGerente : IRepositorioGerente
    {
       private readonly AppContext _contexto;

        public RepositorioGerente(AppContext contexto){
            this._contexto = contexto;
        }
        public Gerente addGerente(Gerente Gerente)
        {
            Gerente nuevoGerente = _contexto.Add(Gerente).Entity;
            _contexto.SaveChanges();
            return nuevoGerente;
        }


        public Gerente editGerente(Gerente Gerente)
        {
            Gerente GerenteAEditar = _contexto.Gerentes.FirstOrDefault(f => f.Id == Gerente.Id);
            if(GerenteAEditar != null){
                GerenteAEditar.Nombre = Gerente.Nombre;
                GerenteAEditar.Identificacion = Gerente.Identificacion;
                GerenteAEditar.Telefono = Gerente.Telefono;
                GerenteAEditar.Direccion = Gerente.Direccion;
                GerenteAEditar.Email = Gerente.Email;
                GerenteAEditar.Contrasena = Gerente.Contrasena;
                GerenteAEditar.Fecha_nacimiento = Gerente.Fecha_nacimiento;
                
                
                _contexto.SaveChanges();
            }
            return GerenteAEditar;
        }

        

        public IEnumerable<Gerente> getAllGerente()
        {
            return _contexto.Gerentes;
        }

        public Gerente getGerente(int Id)
        {
            Gerente Gerenteencontrado = _contexto.Gerentes.FirstOrDefault(a => a.Id == Id);
            return Gerenteencontrado;
        }

        public void removeGerente(string identificacion)
        {
            Gerente Gerente = _contexto.Gerentes.FirstOrDefault(x => x.Identificacion == identificacion);
            if(Gerente != null){
                _contexto.Gerentes.Remove(Gerente);
                _contexto.SaveChanges();
            }

        }
  
    }
}