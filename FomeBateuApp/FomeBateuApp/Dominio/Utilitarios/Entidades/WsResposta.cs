using static FomeBateuWebService.Dominio.Utilitarios.Entidades.Constantes;


namespace FomeBateuWebService.Dominio.Utilitarios.Entidades
{
    public class WsResposta
    {
        public EnumWsCodigo Codigo { get; set; }
        public string Mensagem { get; set; }
        public string MensagemErro { get; set; }
        public string Conteudo { get; set; }
        public WsResposta()
        {
            Codigo = EnumWsCodigo.OK;
            Mensagem = string.Empty;
            MensagemErro = string.Empty;
            Conteudo = string.Empty;
        }
    }
}
