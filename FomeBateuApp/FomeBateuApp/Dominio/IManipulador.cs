using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio
{
    public interface IManipulador<T> : IDisposable where T : IEventoDominio
    {
        void Manipular(T args);
        IEnumerable<T> Notificar();
        bool PossuiNotificacoes();
    }
}
