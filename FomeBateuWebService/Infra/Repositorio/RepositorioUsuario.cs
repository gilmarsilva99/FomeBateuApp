using FomeBateuWebService.Data;
using FomeBateuWebService.Dominio.Usuario.Dto;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FomeBateuWebService.Infra.Repositorio
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private DataAccess _contexto;

        public RepositorioUsuario()
        {
            _contexto = new DataAccess();
        }

        public Usuarios ObterPorEmail(string email)
        {
            Usuarios usuarioConsultado = _contexto.UsuarioMaps.Include(a => a.Endereco).FirstOrDefault(b => b.Email == email);

            return usuarioConsultado;
        }

        public bool ValidarSenha(string senhaUsuario, string senhaDigitada)
        {
            string senhaEncriptada = Criptografia.EncriptarSenha(senhaDigitada);

            return senhaEncriptada == senhaUsuario;            
        }



    }
}
