using FomeBateuWebService.Dominio.Usuario;
using FomeBateuWebService.Dominio.Usuario.Dto;
using FomeBateuWebService.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Serviços.Usuarios
{
    public class ServicoUsuario : IServicoUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario) 
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public UsuarioDto ObterPorEmail(string email) 
        {
            if (string.IsNullOrEmpty(email))
            {
                return null;
            }
            return UsuarioAdaptador.ConverterMapParaDto(_repositorioUsuario.ObterPorEmail(email));
        } 

        public bool ValidarSenha(string email, string senhaDigitada) 
        {
            UsuarioDto usuarioEcontrado = UsuarioAdaptador.ConverterMapParaDto(_repositorioUsuario.ObterPorEmail(email));

            if (usuarioEcontrado == null)
            {
                return false;
            }

            return _repositorioUsuario.ValidarSenha(usuarioEcontrado.Senha, senhaDigitada);                     
        }
    }
}