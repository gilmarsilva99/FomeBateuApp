using FomeBateuWebService.Infra.Persistencia.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FomeBateuWebService.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public bool Situacao { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public string Fone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }               
        public string Senha { get; private set; }        
        public List<UsuariosEndereco> Endereco { get; set; }


        //public void AlterarSenha(string senha)
        //{
        //    Senha = Criptografia.EncriptarSenha(senha);
        //    SenhaAlteradaEm = DateTime.Now.Date;
        //}

    }
}
