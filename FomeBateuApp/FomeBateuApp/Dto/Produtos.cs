using System;
using System.Collections.Generic;
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
        public Restaurantes Restaurante { get; set; }
    }
}
