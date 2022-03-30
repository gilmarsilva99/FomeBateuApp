using FomeBateuWebService.Infra.Persistencia.Mapeamento;
using FomeBateuWebService.Mapeamento;
using FomeBateuWebService.Models;
using System;
using System.Data.Entity;

namespace FomeBateuWebService.Data
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("FomeBateuBD")
        {            
            Database.SetInitializer<DataAccess>(null);            
        }

        public virtual DbSet<Restaurantes> RestauranteMaps { get; set; }
        public virtual DbSet<RestaurantesEndereco> RestauranteEnderecoMaps { get; set; }
        public virtual DbSet<Produtos> ProdutoMaps { get; set; }
        public virtual DbSet<Usuarios> UsuarioMaps { get; set; }
        public virtual DbSet<UsuariosEndereco> UsuarioEnderecoMaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Configurations.Add(new MapeamentoRestaurantes());
                modelBuilder.Configurations.Add(new MapeamentoUsuario());
                modelBuilder.Configurations.Add(new MapeamentoProdutos());
                modelBuilder.Configurations.Add(new MapeamentoRestaurantesEndereco());
                modelBuilder.Configurations.Add(new MapeamentoUsuarioEndereco());
                
            }
            catch (Exception ex)
            {
                //Log.AddLog("SQLiteBD.OnModelCreating", ex.Message, ex.ToString());
            }
        }

    }
}
