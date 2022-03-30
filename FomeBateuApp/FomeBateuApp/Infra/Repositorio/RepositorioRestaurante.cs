using FomeBateuWebService.Data;
using FomeBateuWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            return _contexto.RestauranteMaps.Include(a=>a.Endereco).OrderBy(p=>p.RazaoSocial).ToList();
        }

        public Restaurantes ObterPorId(int idRestaurante)
        {
            return _contexto.RestauranteMaps.Include(a => a.Endereco).FirstOrDefault(b=>b.Id == idRestaurante);
        }

        public List<Restaurantes> ObtertPorDescricao(string descricao) 
        {
            return _contexto.RestauranteMaps.Where(a=>a.NomeFantasia.Contains(descricao)).ToList();
        }
    }
}
