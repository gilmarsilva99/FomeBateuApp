using FomeBateuWebService.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FomeBateuWebService.Models
{
    public class Restaurantes
    {      
        public int Id { get; set; }
        public string Contato { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }        
        public string InscricaoEstadual { get; set; }         
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }        
        public string Email { get; set; }        
        public List<RestaurantesEndereco> Enderecos { get; set; }        
        public List<Produtos> Produto { get; set; }

    }
}
