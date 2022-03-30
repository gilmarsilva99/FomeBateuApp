using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Produtos.Dto
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public int FornecedorId { get; set; }
    }
}
