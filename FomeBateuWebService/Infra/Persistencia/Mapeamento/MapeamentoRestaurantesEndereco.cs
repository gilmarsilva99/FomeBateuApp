using FomeBateuWebService.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Infra.Persistencia.Mapeamento
{
    public class MapeamentoRestaurantesEndereco : EntityTypeConfiguration<RestaurantesEndereco>
    {
        public MapeamentoRestaurantesEndereco() 
        {
            HasKey(p => p.Id);
            ToTable("RestaurantesEndereco");
            Property(p => p.Id)
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
               .HasColumnType("int");
            Property(p => p.Cep)
               .IsRequired()
               .HasColumnType("nvarchar");
            Property(p => p.Cidade)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Uf)
               .IsRequired()
               .HasColumnType("char");
            Property(p => p.Complemento)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Bairro)
                .HasColumnType("varchar");
            Property(p => p.Endereco)
                .HasColumnType("varchar");
            Property(p => p.RestauranteId)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}