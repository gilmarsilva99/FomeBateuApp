using FomeBateuWebService.Models;
using System.Collections.Generic;

namespace FomeBateuWebService.Infra.Repositorio
{
    public interface IRepositorioRestaurante
    {
        List<Restaurantes> ListarRestaurantes();
        Restaurantes ObterPorId(int idRestaurante);
        List<Restaurantes> ObtertPorDescricao(string descricao);
    }
}