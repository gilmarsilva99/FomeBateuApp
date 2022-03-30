using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FomeBateuWebService.Dominio.Eventos
{
    public static class EventoDominio
    {
        public static IContainer Container { get; set; }

        public static void Disparar<T>(T args) where T : IEventoDominio
        {
            try
            {
                if (Container == null)
                {
                    return;
                }

                object obj = Container.ObterServico(typeof(IManipulador<T>));
                ((IManipulador<T>)obj).Manipular(args);
            }
            catch
            {
                //throw;
            }
        }
    }
}
