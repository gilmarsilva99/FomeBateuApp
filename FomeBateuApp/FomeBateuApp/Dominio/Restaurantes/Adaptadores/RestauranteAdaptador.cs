using FomeBateuWebService.Dominio.Restaurantes.Dto;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Restaurantes.Adaptadores
{
    public class RestauranteAdaptador
    {
        public static List<RestauranteDto> ConverterMapParaDto(List<Models.Restaurantes> restauranteMaps)
        {
            if (restauranteMaps == null)
            {
                return null;
            }

            List<RestauranteDto> restauranteDtos = new List<RestauranteDto>();

            foreach (Models.Restaurantes restauranteMap in restauranteMaps)
            {
                RestauranteDto restauranteDto = new RestauranteDto() 
                {
                    Id = restauranteMap.Id,
                    RazaoSocial = restauranteMap.RazaoSocial,
                    Contato = restauranteMap.Contato,
                    Email = restauranteMap.Email,
                    Fone1 = restauranteMap.Fone1,
                    Fone2 = restauranteMap.Fone2,
                    InscricaoEstadual = restauranteMap.InscricaoEstadual,
                    DataAtualizacaoCadastro = restauranteMap.DataAtualizacaoCadastro,
                    Cidade = restauranteMap.Endereco.Cidade,
                    Uf = restauranteMap.Endereco.Uf,
                    Cep = restauranteMap.Endereco.Cep,
                    Endereco = restauranteMap.Endereco.Endereco,
                    Cnpj = restauranteMap.Cnpj,
                    Complemento = restauranteMap.Endereco.Complemento,
                    NomeFantasia = restauranteMap.NomeFantasia

                };

                restauranteDtos.Add(restauranteDto);

            }

            return restauranteDtos;
        }


        public static RestauranteDto ConverterMapParaDto(Models.Restaurantes restauranteMap)
        {
            if (restauranteMap == null)
            {
                return null;
            }
            RestauranteDto restauranteDto = new RestauranteDto()
            {
                Id = restauranteMap.Id,
                RazaoSocial = restauranteMap.RazaoSocial,
                Contato = restauranteMap.Contato,
                Email = restauranteMap.Email,
                Fone1 = restauranteMap.Fone1,
                Fone2 = restauranteMap.Fone2,
                InscricaoEstadual = restauranteMap.InscricaoEstadual,
                DataAtualizacaoCadastro = restauranteMap.DataAtualizacaoCadastro,
                Cidade = restauranteMap.Endereco.Cidade,
                Uf = restauranteMap.Endereco.Uf,
                Cep = restauranteMap.Endereco.Cep,
                Endereco = restauranteMap.Endereco.Endereco,
                Cnpj = restauranteMap.Cnpj,
                Complemento = restauranteMap.Endereco.Complemento,
                NomeFantasia = restauranteMap.NomeFantasia

            };

            return restauranteDto;
        }
    }
}
