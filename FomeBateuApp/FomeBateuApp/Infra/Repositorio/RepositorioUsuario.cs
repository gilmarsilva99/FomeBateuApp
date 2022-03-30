using FomeBateuWebService.Data;
using FomeBateuWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FomeBateuWebService.Infra.Repositorio
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private DataAccess _contexto;

        public RepositorioUsuario()
        {
            _contexto = new DataAccess();
        }

        public Usuarios ObterPorId(int idUsuario) 
        {
            return _contexto.UsuarioMaps.Include(a=>a.Endereco).FirstOrDefault(b=>b.Id == idUsuario);
        }
    }
}
