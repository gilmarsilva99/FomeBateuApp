using FomeBateuWebService.Dominio.Usuario.Dto;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FomeBateuWebService.Dominio.Usuario
{
    public class UsuarioAdaptador
    {
        public static UsuarioDto ConverterMapParaDto(Usuarios usuarioMap)
        {
            if (usuarioMap == null)
            {
                return null;
            }
            UsuarioDto usuarioDto = new UsuarioDto()
            {
                Id = usuarioMap.Id,
                Cpf = usuarioMap.Cpf,
                Endereco = usuarioMap.Endereco,
                Email = usuarioMap.Email,
                Fone = usuarioMap.Fone,
                NomeCompleto = usuarioMap.NomeCompleto,
                Senha = usuarioMap.Senha,                
                Situacao = usuarioMap.Situacao,
                UltimoAcesso = usuarioMap.UltimoAcesso

            };

            return usuarioDto;
        }
    }
}