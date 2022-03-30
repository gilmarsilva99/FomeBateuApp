using FomeBateuWebService.Dominio.Usuario.Dto;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using FomeBateuWebService.Infra.Repositorio;
using FomeBateuWebService.Serviços.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;

namespace FomeBateuWebService.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IServicoUsuario _servico;

        public UsuariosController(IServicoUsuario servico)
        {
            _servico  = servico;
        }
        public UsuariosController()
        {
            _servico = new ServicoUsuario(new RepositorioUsuario());
        }

        [HttpGet]        
        [Route("api/v1/usuarios/autenticar")]
        public IHttpActionResult Autenticar(string email, string senha)
        {
            WsResposta wsResposta = new WsResposta();
            try
            {
                UsuarioDto usuarioDto = _servico.ObterPorEmail(email);

                if (usuarioDto == null || !_servico.ValidarSenha(usuarioDto.Email, senha))
                {
                    wsResposta.MensagemErro = "Usuário e/ou senha inválidos";
                    wsResposta.Codigo = Constantes.EnumWsCodigo.ERRO;
                }
                else 
                {
                    wsResposta.Conteudo = JsonUtils.Serializar(usuarioDto);
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