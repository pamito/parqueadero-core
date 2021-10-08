using System.Collections.Generic;
using System.Linq;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly AppContext _contexto;

        public RepositorioAuxiliar(AppContext contexto){
            this._contexto = contexto;
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
                auxiliarAEditar.Nombre = auxiliar.Nombre;
                auxiliarAEditar.Identificacion = auxiliar.Identificacion;
                auxiliarAEditar.Telefono = auxiliar.Telefono;
                auxiliarAEditar.Direccion = auxiliar.Direccion;
                auxiliarAEditar.Email = auxiliar.Email;
                auxiliarAEditar.Contrasena = auxiliar.Contrasena;
                auxiliarAEditar.Fecha_nacimiento = auxiliar.Fecha_nacimiento;
                auxiliarAEditar.Turno = auxiliar.Turno;
                
                _contexto.SaveChanges();
            }
            return auxiliarAEditar;
        }

        

        public IEnumerable<Auxiliar> getAllAuxiliar()
        {
            return _contexto.Auxiliares;
        }

        public Auxiliar getAuxiliar(int Id)
        {
            Auxiliar auxiliarencontrado = _contexto.Auxiliares.FirstOrDefault(a => a.Id == Id);
            return auxiliarencontrado;
        }

        public void removeAuxiliar(string identificacion)
        {
            Auxiliar auxiliar = _contexto.Auxiliares.FirstOrDefault(x => x.Identificacion == identificacion);
            if(auxiliar != null){
                _contexto.Auxiliares.Remove(auxiliar);
                _contexto.SaveChanges();
            }

        }

        
    }
}