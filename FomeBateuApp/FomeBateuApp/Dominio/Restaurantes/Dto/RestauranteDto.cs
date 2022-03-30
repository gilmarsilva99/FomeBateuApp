using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Restaurantes.Dto
{
    public class RestauranteDto
    {
        public int Id { get;  set; }
        public string Contato { get;  set; }
        public string Fone1 { get;  set; }
        public string Fone2 { get;  set; }
        public string InscricaoEstadual { get;  set; }
        public DateTime DataAtualizacaoCadastro { get;  set; }
        public string RazaoSocial { get;  set; }
        public string Cnpj { get;  set; }
        public string Email { get;  set; }
        public string Endereco { get;  set; }
        public string Cep { get;  set; }
        public string Cidade { get;  set; }
        public string Uf { get;  set; }
        public string Complemento { get; set; }
        public string NomeFantasia { get; set; }
    }
}
