using FomeBateuWebService.Dominio.Produtos.Dto;
using FomeBateuWebService.Dominio.Produtos.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Produtos.Adaptadores
{
    public class ProdutoAdaptador
    {

        public static List<ProdutoDto> ConverterMapParaDto(List<Mapeamento.Produtos> produtoMaps) 
        {
            if (produtoMaps == null)
            {
                return null;
            }

            List<ProdutoDto> produtoDtos = new List<ProdutoDto>();

            foreach (Mapeamento.Produtos produtoMap in produtoMaps) 
            {
                ProdutoDto produtoDto = new ProdutoDto() 
                {
                    Id = produtoMap.Id,
                    Ativo = produtoMap.Ativo,
                    Descricao = produtoMap.Descricao,
                    FornecedorId = produtoMap.RestauranteId,
                    Observacao = produtoMap.Observacao,
                    Valor = produtoMap.Valor,
                };

                produtoDtos.Add(produtoDto);
            }

            return produtoDtos;
        }
    }
}
