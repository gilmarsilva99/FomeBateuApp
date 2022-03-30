using FomeBateuWebService.Dominio.Produtos.Adaptadores;
using FomeBateuWebService.Dominio.Produtos.Dto;
using FomeBateuWebService.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Serviços.Produtos
{
    public class ServicoProduto : IServicoProduto
    {
        private readonly IRepositorioProduto _repositorioProduto;

        public ServicoProduto(IRepositorioProduto repositorioProduto) 
        {
            _repositorioProduto = repositorioProduto;
        }

        public List<ProdutoDto> ObterPorIdFornecedor(int idFornecedor) 
        {
            return ProdutoAdaptador.ConverterMapParaDto(_repositorioProduto.ObterPorIdFornecedor(idFornecedor));
        }

        public List<ProdutoDto> ObterPorDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
            {                
                return null;
            }
            
            return ProdutoAdaptador.ConverterMapParaDto(_repositorioProduto.ObterPorDescricao(descricao));
        }
    }
}
