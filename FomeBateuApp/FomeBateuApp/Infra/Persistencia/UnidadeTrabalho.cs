using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Data
{
    public class UnidadeTrabalho : IUnidadeTrabalho
    {
        private readonly DataAccess _contexto;

        public UnidadeTrabalho(DataAccess contexto)
        {
            _contexto = contexto;
        }

        public void Commit()
        {
            _contexto.SaveChanges();
            _contexto.Database.CurrentTransaction?.Commit();
        }

        public void Rollback()
        {
            _contexto.Database.CurrentTransaction?.Rollback();
        }

        public void BeginTran()
        {
            if (_contexto.Database.CurrentTransaction == null)
            {
                _contexto.Database.BeginTransaction();
            }
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

    }
}
