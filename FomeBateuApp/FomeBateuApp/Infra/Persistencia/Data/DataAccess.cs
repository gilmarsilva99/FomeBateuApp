using FomeBateuWebService.Infra.Persistencia.Mapeamento;
using FomeBateuWebService.Mapeamento;
using FomeBateuWebService.Models;
using Microsoft.EntityFrameworkCore;

namespace FomeBateuWebService.Data
{
    public class DataAccess : DbContext
    {
        private IDbConn dbConn;

        public DataAccess()
        {
            dbConn = new DbConn 
            {
                server_dbname = "fomebateudb",
                server_name = "localhost",
                server_user = "sa",
                server_pass = "123456"                
            };
        }

        public virtual DbSet<Restaurantes> RestauranteMaps { get; set; }
        public virtual DbSet<RestaurantesEndereco> RestauranteEnderecoMaps { get; set; }
        public virtual DbSet<Produtos> ProdutoMaps { get; set; }
        public virtual DbSet<Usuarios> UsuarioMaps { get; set; }
        public virtual DbSet<UsuariosEndereco> UsuarioEnderecoMaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(dbConn.Connection);
        }
       
    }
}
