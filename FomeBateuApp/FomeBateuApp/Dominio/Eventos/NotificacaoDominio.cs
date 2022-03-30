using System;
using System.Collections.Generic;
using System.Text;

namespace FomeBateuWebService.Dominio.Eventos
{
    public class NotificacaoDominio 
    {
        public string Chave { get; private set; }
        public string Valor { get; private set; }
        public DateTime Data { get; private set; }

        public DateTime Date { get; private set; }

        public NotificacaoDominio(string chave, string valor)
        {
            Chave = chave;
            Valor = valor;
            Data = DateTime.Now;
        }
    }
}
