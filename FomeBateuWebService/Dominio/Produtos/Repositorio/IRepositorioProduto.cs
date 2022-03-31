using FomeBateuWebService.Dominio.Produtos.Mapeamento;
using FomeBateuWebService.Models;
using System.Collections.Generic;

namespace FomeBateuWebService.Infra.Repositorio
{
    public interface IRepositorioProduto
    {
        List<Produtos> ObterPorIdFornecedor(int idFornecedor);

        List<Produtos> ObterPorDescricao(string descricao);
    }
}