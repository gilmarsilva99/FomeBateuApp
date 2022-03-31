using FomeBateuWebService.Dominio.Restaurantes.Dto;
using FomeBateuWebService.Dominio.Restaurantes.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Restaurantes.Adaptadores
{
    public class RestauranteAdaptador
    {
        public static List<RestauranteDto> ConverterMapParaDto(List<Restaurantes.Mapeamento.Restaurantes> restauranteMaps)
        {
            if (restauranteMaps == null)
            {
                return null;
            }

            List<RestauranteDto> restauranteDtos = new List<RestauranteDto>();

            foreach (Restaurantes.Mapeamento.Restaurantes restauranteMap in restauranteMaps)
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
                    Enderecos = restauranteMap.Enderecos,
                    Cnpj = restauranteMap.Cnpj,                    
                    NomeFantasia = restauranteMap.NomeFantasia,
                    Frete = restauranteMap.Frete,
                    TempoEspera = restauranteMap.TempoEspera,
                    Produtos = restauranteMap.Produto
                    

                };

                restauranteDtos.Add(restauranteDto);

            }

            return restauranteDtos;
        }


        public static RestauranteDto ConverterMapParaDto(Restaurantes.Mapeamento.Restaurantes restauranteMap)
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
                Cnpj = restauranteMap.Cnpj,
                Enderecos = restauranteMap.Enderecos,
                NomeFantasia = restauranteMap.NomeFantasia,
                Produtos = restauranteMap.Produto,
                Frete = restauranteMap.Frete,
                TempoEspera = restauranteMap.TempoEspera

            };

            return restauranteDto;
        }
    }
}
