
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using System.Collections.Generic;

namespace FomeBateuApp.Utiliarios.Entidades
{
    public class Api
    {   
        public string EndPoint { get; set; }

        public Api()
        {

        }
        
        public Api(string ep)
        {
            EndPoint = ep;
        }

        public static string CaminhoWebService = "http://192.168.1.165:80/";

        public static string CaminhoApi = CaminhoWebService + "api/v1/";
        public WsResposta GetId(int id)
        {
            List<WsParametro> parametros = new List<WsParametro>();
            parametros.Add(new WsParametro()
            {
                Nome = "id",
                Valor = id
            });

            return Get(parametros);
        }       

        public WsResposta Get(List<WsParametro> parametros)
        {
            RestService rs = new RestService()
            {
                Ws = CaminhoApi,
                EndPoint = EndPoint
            };

            return rs.Get(parametros);
        }

        public WsResposta Get()
        {
            return Get(new List<WsParametro>());
        }  
    }
}
