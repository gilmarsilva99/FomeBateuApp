using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Infra.Persistencia.Mapeamento
{
    public class MapeamentoUsuario : EntityTypeConfiguration<Usuarios>
    {
        public MapeamentoUsuario() 
        {
            HasKey(p => p.Id);
            ToTable("Usuarios");
            Property(p => p.Id)
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
               .HasColumnType("int");
            Property(p => p.NomeCompleto)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Situacao)               
               .HasColumnType("bit");
            Property(p => p.UltimoAcesso)
               .IsRequired()
               .HasColumnType("datetime");
            Property(p => p.Fone)
               .IsRequired()
               .HasColumnType("varchar");
            Property(p => p.Cpf)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(11);          
            Property(p => p.Email)
                 .HasColumnType("varchar");
            Property(p => p.Senha)
                .HasColumnType("varchar");

           

            HasMany(p => p.Endereco)
               .WithRequired(c => c.Usuario)
               .HasForeignKey(p => p.UsuarioId);
        }

    }
}