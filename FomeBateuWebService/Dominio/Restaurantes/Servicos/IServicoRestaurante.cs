using FomeBateuWebService.Dominio.Restaurantes.Dto;
using System.Collections.Generic;

namespace FomeBateuWebService.Services.Restaurantes
{
    public interface IServicoRestaurante
    {
        List<RestauranteDto> Listar();
        RestauranteDto ObterPorId(int id);
        List<RestauranteDto> ObterPorDescricao(string descricao);
    }
}