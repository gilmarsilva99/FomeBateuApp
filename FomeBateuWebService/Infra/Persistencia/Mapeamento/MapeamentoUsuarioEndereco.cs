using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Infra.Persistencia.Mapeamento
{
    public class MapeamentoUsuarioEndereco : EntityTypeConfiguration<UsuariosEndereco>
    {
        public MapeamentoUsuarioEndereco() 
        {
            HasKey(p => p.Id);
            ToTable("UsuariosEndereco");
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
            Property(p => p.UsuarioId)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}