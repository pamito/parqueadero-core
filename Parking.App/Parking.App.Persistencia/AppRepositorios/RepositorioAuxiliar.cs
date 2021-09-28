using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Parking.app.Persistencia{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly Contexto _contexto;

        public RepositorioAuxiliar(Contexto context){
            this._contexto = context;
        }
        public Auxiliar addAuxiliar(Auxiliar auxiliar)
        {
            Auxiliar nuevoAuxiliar = _contexto.Add(auxiliar).Entity;
            _contexto.SaveChanges();
            return nuevoAuxiliar;
        }

        public Auxiliar editAuxiliar(Auxiliar auxiliar)
        {
            Auxiliar auxiliarAEditar = _contexto.Auxiliares.FirstOrDefault(f => f.Id == auxiliar.Id);
            if(auxiliarAEditar != null){
                auxiliarAEditar.Nombre = auxiliar.nombre;
                auxiliarAEditar.Identificacion = auxiliar.identificacion;
                auxiliarAEditar.Telefono = auxiliar.telefono;
                auxiliarAEditar.Direccion = auxiliar.direccion;
                auxiliarAEditar.Email = auxiliar.email;
                auxiliarAEditar.Contrasena = auxiliar.contrasena;
                auxiliarAEditar.Fecha_nacimento = auxiliar.fecha_nacimiento;
                auxiliarAEditar.Turno = auxiliar.turno;
                
                _contexto.SaveChanges();
            }
            return auxiliarAEditar;
        }

        /*public IEnumerable<Auxiliar> getAllAuxiliar()
        {
            return _contexto.Auxiliares.Include("familiar").Include("medico").Include("enfermera");
        }
        */
        public Auxiliar getAuxiliar(string identificacion)
        {
            return _contexto.Auxiliares.FirstOrDefault(x => x.identificacion == identificacion);
        }

        public void removeAuxiliar(string identificacion)
        {
            Auxiliar auxiliar = _contexto.Auxiliares.FirstOrDefault(x => x.identificacion == identificacion);
            if(auxiliar != null){
                _contexto.Auxliares.Remove(auxiliar);
                _contexto.SaveChanges();
            }

        }
    }
}