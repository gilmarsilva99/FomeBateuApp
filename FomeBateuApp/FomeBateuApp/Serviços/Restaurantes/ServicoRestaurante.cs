using FomeBateuWebService.Data;
using FomeBateuWebService.Dominio.Restaurantes.Adaptadores;
using FomeBateuWebService.Dominio.Restaurantes.Dto;
using FomeBateuWebService.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Services.Restaurantes
{
    public class ServicoRestaurante : IServicoRestaurante
    {
        private readonly IRepositorioRestaurante _repositorioRestaurante;

        public ServicoRestaurante(IRepositorioRestaurante repositorioRestaurante) 
        {
            _repositorioRestaurante = repositorioRestaurante;
        }

        public List<RestauranteDto> Listar() 
        {
            return RestauranteAdaptador.ConverterMapParaDto(_repositorioRestaurante.ListarRestaurantes());
        }

        public RestauranteDto ObterPorId(int id) 
        {
            return RestauranteAdaptador.ConverterMapParaDto(_repositorioRestaurante.ObterPorId(id));
        }
        public List<RestauranteDto> ObterPorDescricao(string descricao) 
        {
            if (string.IsNullOrEmpty(descricao))
            {
                return null;
            }
            return RestauranteAdaptador.ConverterMapParaDto(_repositorioRestaurante.ObtertPorDescricao(descricao));
        }
    }
}
