using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;

namespace FomeBateuWebService.Dominio.Utilitarios.Entidades
{
    public class RestService
    {
        public string Ws { get; set; }
        public string EndPoint { get; set; }
        public WsResposta Post<T>(T body)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(body);
            return Requisitar(request);
        }
        public WsResposta Put<T>(int id, T body)
        {
            var request = new RestRequest(Method.PUT);
            EndPoint += "?id=" + id.ToString();
            request.AddJsonBody(body);
            return Requisitar(request);
        }
        public WsResposta Post<T>(List<WsParametro> parametros, T body)
        {
            var request = new RestRequest(Method.POST);

            string parUrl = "";

            if (parametros != null)
                foreach (WsParametro par in parametros)
                    parUrl += "?" + par.Nome + "=" + par.Valor.ToString();

            EndPoint += parUrl;

            request.AddJsonBody(body);
            return Requisitar(request);
        }

        public WsResposta Post2(List<WsParametro> parametros)
        {
            var request = new RestRequest(Method.POST);

            string parUrl = "";

            if (parametros != null)
                foreach (WsParametro par in parametros)
                    parUrl += (parUrl == "" ? "?" : "&") + par.Nome + "=" + par.Valor.ToString();

            EndPoint += parUrl;
            return Requisitar(request);
        }
        public WsResposta Delete(int id)
        {
            var request = new RestRequest(Method.DELETE);
            request.AddParameter("id", id);
            return Requisitar(request);
        }
        public WsResposta Delete(List<WsParametro> parametros)
        {
            var request = new RestRequest(Method.DELETE);

            if (parametros != null)
                foreach (WsParametro par in parametros)
                    request.AddParameter(par.Nome, par.Valor);

            return Requisitar(request);
        }
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
            return Get<string>(parametros, null);
        }
        public WsResposta Get<T>(List<WsParametro> parametros, T body)
        {
            var request = new RestRequest(Method.GET);

            if (parametros != null)
                foreach (WsParametro par in parametros)
                    request.AddParameter(par.Nome, par.Valor);

            if (body != null)
                request.AddJsonBody(body);
            return Requisitar(request);
        }
        public WsResposta Options<T>(T body)
        {
            var request = new RestRequest(Method.OPTIONS);
            request.AddJsonBody(body);
            return Requisitar(request);
        }
        private WsResposta Requisitar(RestRequest request)
        {
            WsResposta resposta;

            try
            {
                var client = new RestClient(Ws + EndPoint)
                {
                    Authenticator = new HttpBasicAuthenticator("airsoft", "airsoft2021")
                };

                request.RequestFormat = DataFormat.Json;
                request.JsonSerializer = NewtonsoftJsonSerializer.Default;
                request.Timeout = 20000;

                IRestResponse response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    resposta = JsonUtils.Deserializar<WsResposta>(response.Content);
                else
                {
                    resposta = new WsResposta()
                    {
                        Codigo = EnumWsCodigo.ERRO,
                        Mensagem = response.ErrorMessage,
                        MensagemErro = response.Content
                    };
                }
            }
            catch (Exception ex)
            {
                resposta = new WsResposta()
                {
                    Codigo = EnumWsCodigo.EXCECAO,
                    Mensagem = "Erro na comunicação com servidor",
                    MensagemErro = ex.Message
                };
            }

            return resposta;
        }

    }

    public class NewtonsoftJsonSerializer : ISerializer, IDeserializer
    {
        private Newtonsoft.Json.JsonSerializer serializer;

        public NewtonsoftJsonSerializer(Newtonsoft.Json.JsonSerializer serializer)
        {
            this.serializer = serializer;
        }

        public string ContentType
        {
            get { return "application/json"; } // Probably used for Serialization?
            set { }
        }

        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    serializer.Serialize(jsonTextWriter, obj);

                    return stringWriter.ToString();
                }
            }
        }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            var content = response.Content;

            using (var stringReader = new StringReader(content))
            {
                using (var jsonTextReader = new JsonTextReader(stringReader))
                {
                    return serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }

        public static NewtonsoftJsonSerializer Default
        {
            get
            {
                return new NewtonsoftJsonSerializer(new Newtonsoft.Json.JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                });
            }
        }
    }
}
