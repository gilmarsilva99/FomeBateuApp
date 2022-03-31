using FomeBateuWebService.Data;
using FomeBateuWebService.Dominio.Restaurantes.Mapeamento;
using FomeBateuWebService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FomeBateuWebService.Infra.Repositorio
{
    public class RepositorioRestaurante : IRepositorioRestaurante
    {
        private DataAccess _contexto;

        public RepositorioRestaurante()
        {
            _contexto = new DataAccess();
        }

        public List<Restaurantes> ListarRestaurantes()
        
        {
            List <Restaurantes> retorno = _contexto.RestauranteMaps.Include(a => a.Enderecos).Include(a => a.Produto).OrderBy(p => p.RazaoSocial).ToList();
            return retorno; 
        }

        public Restaurantes ObterPorId(int idRestaurante)
        {
            return _contexto.RestauranteMaps.Include(a => a.Enderecos).FirstOrDefault(b=>b.Id == idRestaurante);
        }

        public List<Restaurantes> ObtertPorDescricao(string descricao) 
        {
            descricao = descricao.ToLower();

            List<Restaurantes> lista = _contexto.ProdutoMaps.Include(o => o.Restaurante)
                .Where(a => a.Descricao.ToLower().Contains(descricao)
                || a.Observacao.ToLower().Contains(descricao)).Select(p => p.Restaurante).Distinct().ToList();

            lista.AddRange(_contexto.RestauranteMaps.Where(a=>a.NomeFantasia.ToLower().Contains(descricao)));

            return lista.Distinct().ToList();
        }
    }
}
