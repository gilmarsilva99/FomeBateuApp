using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio
{
    public interface IContainer
    {
        T ObterServico<T>();
        object ObterServico(Type serviceType);
        IEnumerable<T> ObterServicos<T>();
        IEnumerable<object> ObterServicos(Type serviceType);
    }
}
