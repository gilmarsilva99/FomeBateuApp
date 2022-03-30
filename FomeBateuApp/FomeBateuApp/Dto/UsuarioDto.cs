using System;
using System.Collections.Generic;

namespace FomeBateuApp.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public bool Situacao { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public string Fone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime SenhaAlteradaEm { get; set; }
        public string Senha { get; set; }
        public List<UsuariosEndereco> Endereco { get; set; }
    }
}