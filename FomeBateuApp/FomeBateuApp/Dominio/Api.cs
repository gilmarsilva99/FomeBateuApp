
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;

namespace AirsoftMobile.Utils
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

        //public static string CaminhoWebService = "http://" + Ferramentas.Instancia.Conexao.Ip + ":" +
        //    Ferramentas.Instancia.Conexao.Porta.ToString() + "/";

        //public static string CaminhoApi = CaminhoWebService + "Api/";
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
                //Ws = CaminhoApi,
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
