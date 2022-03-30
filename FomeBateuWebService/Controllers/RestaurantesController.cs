using FomeBateuWebService.Services.Restaurantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FomeBateuWebService.Infra.Repositorio;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using FomeBateuWebService.Dominio.Restaurantes.Dto;
using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;

namespace FomeBateuWebService.Controllers
{
    public class RestaurantesController : ApiController
    {
        private readonly IServicoRestaurante _servico;

        public RestaurantesController(IServicoRestaurante servico)
        {
            _servico = servico;
        }

        public RestaurantesController() 
        {
            _servico = new ServicoRestaurante(new RepositorioRestaurante());
        }

        [HttpGet]
        //[Authorize]
        [Route("api/v1/restaurantes/listar/")]
        public IHttpActionResult Listar()
        {
            WsResposta wsResposta = new WsResposta();

            List<RestauranteDto> lista = _servico.Listar();

            try
            {
                if (lista == null)
                {
                    wsResposta.MensagemErro = "Nenhum restaurante encontrado.";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(lista);
                }
            }
            catch (Exception ex)
            {
                wsResposta.Codigo = EnumWsCodigo.EXCECAO;
                wsResposta.Mensagem = "Erro ao carregar dados";
                wsResposta.MensagemErro = ex.ToString();
            }
            return Ok(wsResposta);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/v1/restaurantes/obterporid/{id:int}")]
        public IHttpActionResult ObterPorId(int id)
        {
            WsResposta wsResposta = new WsResposta();

            RestauranteDto restaurante = _servico.ObterPorId(id);

            try
            {
                if (restaurante == null)
                {
                    wsResposta.MensagemErro = "Restaurante não encontrado.";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(restaurante);
                }
            }
            catch (Exception ex)
            {
                wsResposta.Codigo = EnumWsCodigo.EXCECAO;
                wsResposta.Mensagem = "Erro ao carregar dados";
                wsResposta.MensagemErro = ex.ToString();
            }
            return Ok(wsResposta);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/v1/restaurantes/obterpordescricaobusca")]
        public IHttpActionResult ObterPorDescricao(string descricao)
        {
            WsResposta wsResposta = new WsResposta();

            List<RestauranteDto> lista = _servico.ObterPorDescricao(descricao);

            try
            {
                if (lista == null)
                {
                    wsResposta.MensagemErro = "Nenhum restaurante encontrado.";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(lista);
                }
            }
            catch (Exception ex)
            {
                wsResposta.Codigo = EnumWsCodigo.EXCECAO;
                wsResposta.Mensagem = "Erro ao carregar dados";
                wsResposta.MensagemErro = ex.ToString();
            }
            return Ok(wsResposta);
        }
    }
}