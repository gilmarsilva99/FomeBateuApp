using System;

namespace FomeBateuWebService.Data
{
    public interface IUnidadeTrabalho : IDisposable
    {
        void Commit();
        void Rollback();
        void BeginTran();
    }
}