using System.Collections.Generic;
using System.Linq;
using Parking.app.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Parking.app.Persistencia{
    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly Contexto _contexto;

        public RepositorioGerente(Contexto context){
            this._contexto = context;
        }
        public Gerente addGerente(Gerente gerente)
        {
            Gerente nuevoGerente = _contexto.Add(Gerente).Entity;
            _contexto.SaveChanges();
            return nuevoGerente;
        }

        public Gerente editGerente(Gerente Gerente)
        {
            Gerente GerenteAEditar = _contexto.Gerentes.FirstOrDefault(f => f.Id == Gerente.Id);
            if(GerenteAEditar != null){
                GerenteAEditar.Nombre = Gerente.nombre;
                GerenteAEditar.Identificacion = Gerente.identificacion;
                GerenteAEditar.Telefono = Gerente.telefono;
                GerenteAEditar.Direccion = Gerente.direccion;
                GerenteAEditar.Email = Gerente.email;
                GerenteAEditar.Contrasena = Gerente.contrasena;
                GerenteAEditar.Fecha_nacimento = Gerente.fecha_nacimento;
                _contexto.SaveChanges();
            }
            return GerenteAEditar;
        }
		/*
        public IEnumerable<Gerente> getAllGerentes()
        {
            return _contexto.Gerentes.Include("familiar").Include("medico").Include("enfermera");
        }
		*/
        public Gerente getGerente(string identificacion)
        {
            return _contexto.Gerentes.FirstOrDefault(x => x.identificacion == identificacion);
        }

        public void removeGerente(string identificacion)
        {
            Gerente gerente = _contexto.Gerentes.FirstOrDefault(e => e.identificacion == identificacion);
            if(gerente != null){
                _contexto.Gerentes.Remove(gerente);
                _contexto.SaveChanges();
            }

        }
    }
}