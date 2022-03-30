using FomeBateuWebService.Data;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FomeBateuWebService.Infra.Repositorio
{
    public class RepositorioProduto : IRepositorioProduto
    {
        private DataAccess _contexto;

        public RepositorioProduto() 
        {
            _contexto = new DataAccess();
        }

        public List<Produtos> ObterPorIdFornecedor (int idFornecedor)
        {
            return _contexto.ProdutoMaps.Where(a=>a.FornecedorId == idFornecedor).ToList();
        }

        public List<Produtos> ObterPorDescricao(string descricao) 
        {
            return _contexto.ProdutoMaps.Where(a=>a.Descricao.Contains(descricao) || a.Observacao.Contains(descricao)).ToList();
        }
    }
}
