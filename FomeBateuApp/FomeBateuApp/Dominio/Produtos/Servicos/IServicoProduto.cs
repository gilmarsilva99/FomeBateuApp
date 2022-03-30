using FomeBateuWebService.Dominio.Produtos.Dto;
using System.Collections.Generic;

namespace FomeBateuWebService.Serviços.Produtos
{
    public interface IServicoProduto
    {
        List<ProdutoDto> ObterPorIdFornecedor(int idFornecedor);
        List<ProdutoDto> ObterPorDescricao(string descricao);
    }
}