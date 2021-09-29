using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioParqueadero : IRepositorioParqueadero
    {
        private readonly AppContext _contexto;

        public RepositorioParqueadero(AppContext contexto){
            this._contexto = contexto;
        }
        public Parqueadero addParqueadero(Parqueadero Parqueadero)
        {
            Parqueadero nuevoParqueadero = _contexto.Add(Parqueadero).Entity;
            _contexto.SaveChanges();
            return nuevoParqueadero;
        }


        public Parqueadero editParqueadero(Parqueadero Parqueadero)
        {
            Parqueadero ParqueaderoAEditar = _contexto.Parqueaderos.FirstOrDefault(f => f.Espacio == Parqueadero.Espacio);
            if(ParqueaderoAEditar != null){
                ParqueaderoAEditar.Piso = Parqueadero.Piso;
                ParqueaderoAEditar.Espacio =Parqueadero.Espacio;
                ParqueaderoAEditar.Estado = Parqueadero.Estado;
                              
                
                _contexto.SaveChanges();
            }
            return ParqueaderoAEditar;
        }

        

        public IEnumerable<Parqueadero> getAllParqueadero()
        {
            return _contexto.Parqueaderos.Include("cliente");
        }

        public IEnumerable<Parqueadero> getAllParqueaderos()
        {
            throw new System.NotImplementedException();
        }

        public Parqueadero getParqueadero(string Espacio)
        {
             Parqueadero Parqueadero = _contexto.Parqueaderos.FirstOrDefault(x => x.Espacio == Espacio);
             return Parqueadero;
        }

        public void removeParqueadero(string Espacio)
        {
            Parqueadero Parqueadero = _contexto.Parqueaderos.FirstOrDefault(x => x.Espacio == Espacio);
            if(Parqueadero != null){
                _contexto.Parqueaderos.Remove(Parqueadero);
                _contexto.SaveChanges();
            }

        }

        
    }
}