using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FomeBateuWebService.Mapeamento
{
    public class RestaurantesEndereco
    {
        [Key]
        public int Id { get; set; }
        public string Endereco { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
    }
}
