using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace FomeBateuWebService.Infra.Persistencia.Mapeamento
{
    public class MapeamentoRestaurantes : EntityTypeConfiguration<Restaurantes>
    {
        public MapeamentoRestaurantes() 
        
        {
            HasKey(p => p.Id);
            ToTable("Restaurantes");
            Property(p => p.Id)
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
               .HasColumnType("int");           
            Property(p => p.Contato)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.InscricaoEstadual)
               .IsRequired()
               .HasColumnType("nvarchar");
            Property(p => p.RazaoSocial)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Fone1)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Fone2)                
                .HasColumnType("varchar");
            Property(p => p.TempoEspera)
                .HasColumnType("varchar");
            Property(p => p.Frete)
                .HasColumnType("varchar");
            Property(p => p.Cnpj)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnType("nchar");
            Property(p => p.Email)
                 .HasColumnType("varchar");
            Property(p => p.NomeFantasia)
                .HasColumnType("varchar");

            HasMany(p => p.Enderecos)
               .WithRequired(c => c.Restaurantes)
               .HasForeignKey(p => p.RestauranteId);

            HasMany(p => p.Produto)
               .WithRequired(c => c.Restaurante)
               .HasForeignKey(p => p.RestauranteId);
        }
    }
}