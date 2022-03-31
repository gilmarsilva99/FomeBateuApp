using FomeBateuWebService.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;
using FomeBateuWebService.Dominio;

namespace FomeBateuWebService.Dominio.Restaurantes.Dto
{
    public class RestauranteDto
    {
        public int Id { get;  set; }
        public string Contato { get;  set; }
        public string Fone1 { get;  set; }
        public string Fone2 { get;  set; }
        public string InscricaoEstadual { get;  set; }        
        public string RazaoSocial { get;  set; }
        public string Cnpj { get;  set; }
        public string Email { get;  set; }        
        public string NomeFantasia { get; set; }
        public string TempoEspera { get; set; }
        public string Frete { get; set; }
        public string TempoFrete => $"Tempo/Entrega: {TempoEspera} - {Frete}";
        public List<RestaurantesEndereco> Enderecos { get; set; }    
        
        public List<Produtos.Mapeamento.Produtos> Produtos { get; set; }

    }
}
