using FomeBateuWebService.Dominio.Produtos.Dto;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using FomeBateuWebService.Infra.Repositorio;
using FomeBateuWebService.Serviços.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;

namespace FomeBateuWebService.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly IServicoProduto _servico;

        public ProdutosController()
        {
            _servico = new ServicoProduto(new RepositorioProduto());
        }

        [HttpGet]
        //[Authorize]
        [Route("api/v1/produtos/obterpordescricaobusca")]
        public IHttpActionResult ObterPorDescricao(string descricao)
        {
            WsResposta wsResposta = new WsResposta();

            List<ProdutoDto> produtos = _servico.ObterPorDescricao(descricao);

            try
            {
                if (produtos == null)
                {
                    wsResposta.MensagemErro = "Nenhum produto encontrado.";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(produtos);
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
        [Route("api/v1/produtos/obterporrestaurante/{idRestaurante:int}")]
        public IHttpActionResult ObterPorIdFornecedor(int idRestaurante)
        {
            WsResposta wsResposta = new WsResposta();

            List<ProdutoDto> produtos = _servico.ObterPorIdFornecedor(idRestaurante);

            try
            {
                if (produtos == null)
                {
                    wsResposta.MensagemErro = "Produtos não encontrado.";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(produtos);
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