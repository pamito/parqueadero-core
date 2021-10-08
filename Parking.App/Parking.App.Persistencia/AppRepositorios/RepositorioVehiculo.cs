using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _contexto;

        public RepositorioVehiculo(AppContext contexto){
            this._contexto = contexto;
        }
        public Vehiculo addVehiculo(Vehiculo Vehiculo)
        {
            Vehiculo nuevoVehiculo = _contexto.Add(Vehiculo).Entity;
            _contexto.SaveChanges();
            return nuevoVehiculo;
        }


        public Vehiculo editVehiculo(Vehiculo Vehiculo)
        {
            Vehiculo VehiculoAEditar = _contexto.Vehiculos.FirstOrDefault(f => f.Id == Vehiculo.Id);
            if(VehiculoAEditar != null){
                VehiculoAEditar.Marca = Vehiculo.Marca;
                VehiculoAEditar.Model =Vehiculo.Model;
                VehiculoAEditar.Color = Vehiculo.Color;
                VehiculoAEditar.Tipo = Vehiculo.Tipo;
                VehiculoAEditar.Placa = Vehiculo.Placa;
                VehiculoAEditar.Cliente = Vehiculo.Cliente;
               
                
                _contexto.SaveChanges();
            }
            return VehiculoAEditar;
        }

        

        public IEnumerable<Vehiculo> getAllVehiculo()
        {
            return _contexto.Vehiculos.Include("Cliente");
        }

      

        public Vehiculo getVehiculo(int Id)
        {
             Vehiculo Vehiculo = _contexto.Vehiculos.FirstOrDefault(x => x.Id == Id);
             return Vehiculo;
        }

        public void removeVehiculo(string placa)
        {
            Vehiculo Vehiculo = _contexto.Vehiculos.FirstOrDefault(x => x.Placa == placa);
            if(Vehiculo != null){
                _contexto.Vehiculos.Remove(Vehiculo);
                _contexto.SaveChanges();
            }

        }

        
    }
}