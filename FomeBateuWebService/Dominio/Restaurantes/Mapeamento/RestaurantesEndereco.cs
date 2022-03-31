﻿using FomeBateuWebService.Dominio.Restaurantes.Mapeamento;
using FomeBateuWebService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FomeBateuWebService.Mapeamento
{
    public class RestaurantesEndereco
    {        
        public int Id { get; set; }
        public string Endereco { get;  set; }
        public string Cep { get;  set; }
        public string Cidade { get;  set; }
        public string Uf { get;  set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int RestauranteId { get; set; }

        [JsonIgnore]
        public Restaurantes Restaurantes { get; set; }

}
}
