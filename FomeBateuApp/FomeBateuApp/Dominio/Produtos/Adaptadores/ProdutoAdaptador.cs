using FomeBateuWebService.Dominio.Produtos.Dto;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Produtos.Adaptadores
{
    public class ProdutoAdaptador
    {

        public static List<ProdutoDto> ConverterMapParaDto(List<Models.Produtos> produtoMaps) 
        {
            if (produtoMaps == null)
            {
                return null;
            }

            List<ProdutoDto> produtoDtos = new List<ProdutoDto>();

            foreach (Models.Produtos produtoMap in produtoMaps) 
            {
                ProdutoDto produtoDto = new ProdutoDto() 
                {
                    Id = produtoMap.Id,
                    Ativo = produtoMap.Ativo,
                    Descricao = produtoMap.Descricao,
                    FornecedorId = produtoMap.FornecedorId,
                    Observacao = produtoMap.Observacao,
                    Valor = produtoMap.Valor,
                };

                produtoDtos.Add(produtoDto);
            }

            return produtoDtos;
        }
    }
}
