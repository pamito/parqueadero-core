using System;
using Parking.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Parking.App.Persistencia 
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Parqueadero> Parqueaderos { get; set; }
        public DbSet<Transaccion> Transaccions { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            if (!options.IsConfigured){
                options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Parking");

                //options.UseNpgsql("Host=localhost;Database=my_db;Username=my_user;Password=my_pw");
            }
        }    
    }
}