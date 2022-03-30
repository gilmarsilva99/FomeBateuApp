using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Infra.Persistencia.Mapeamento
{
    public class MapeamentoProdutos : EntityTypeConfiguration<Produtos>
    {
        public MapeamentoProdutos() 
        {
            HasKey(p => p.Id);
            ToTable("Produtos");
            Property(p => p.Id)
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
               .HasColumnType("int");
            Property(p => p.Descricao)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Ativo)
               .IsRequired()
               .HasColumnType("bit");
            Property(p => p.Valor)
               .IsRequired()
               .HasColumnType("money");
            Property(p => p.Observacao)              
               .HasColumnType("varchar");
            Property(p => p.RestauranteId)
                .IsRequired()
                .HasColumnType("int");           
        }
    }
}