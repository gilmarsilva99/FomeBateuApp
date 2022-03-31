using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FomeBateuApp.Dto
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public int RestauranteId { get; set; }
        public string ValorFormatado => String.Format(new CultureInfo("pt-BR"), "{0:C2}", Valor);

        [JsonIgnore]
        public Restaurantes Restaurante { get; set; }
    }
}
