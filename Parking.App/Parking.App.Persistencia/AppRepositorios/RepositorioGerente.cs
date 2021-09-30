using System.Collections.Generic;
using System.Linq;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly AppContext _contexto;

        public RepositorioGerente(AppContext context){
            this._contexto = context;
        }
        public Gerente addGerente(Gerente gerente)
        {
            Gerente nuevoGerente = _contexto.Add(gerente).Entity;
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

       
        public Gerente getGerente(string identificacion)
        {
            return _contexto.Gerentes.FirstOrDefault(x => x.Identificacion == identificacion);
        }

        public void removeGerente(string identificacion)
        {
            Gerente gerente = _contexto.Gerentes.FirstOrDefault(e => e.Identificacion == identificacion);
            if(gerente != null){
                _contexto.Gerentes.Remove(gerente);
                _contexto.SaveChanges();
            }

        }
    }
}