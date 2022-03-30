using System.ComponentModel;
using System.Globalization;
using Xamarin.Forms;

namespace FomeBateuWebService.Dominio.Utilitarios.Entidades
{
    public class Constantes
    {
        public static CultureInfo CultureBR()
        {
            return new CultureInfo("pt-BR");
        }

        public static string DescricaoEnum(object val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }


        public static Color CorPrimaria = Color.FromHex("#66bb6a");

        public static Color CorSecundaria = Color.FromHex("#338a3e");

        public enum TipoMensagem
        {
            OK = 0,
            CONFIRMACAO = 1,
            INTEIRO = 2,
            VALOR = 3,
            TEXTO = 3,
            DATA = 4
        }

        /*public enum ETipoSanguineo
        {
            INDEFINIDO = 0,
            A_POS = 1,
            A_NEG = 2,
            B_POS = 3,
            B_NEG = 4,
            AB_POS = 5,
            AB_NEG = 6,
            O_POS = 7,
            O_NEG = 8
        };*/

        public enum EnumWsCodigo
        {
            OK = 0,
            EXCECAO = 1,
            ERRO = 2,
            ALERTA = 3
        };

        public enum TipoAlteracaoSenha
        {
            CADASTRO = 1,
            ESQUECEU = 2
        }

        public enum Configuracao
        {
            [Description("CONEXAO")]
            CONEXAO = 1,
            [Description("SENHA_BIOMETRIA")]
            SENHA_BIOMETRIA = 2,
            [Description("LOGIN_USUARIO")]
            LOGIN_USUARIO = 3,
            [Description("TOKEN_FIREBASE")]
            TOKEN_FIREBASE = 4
        };

        public enum TipoViewLista
        {
            CADASTRO = 1,
            CONSULTA = 2,
            VINCULO = 3
        }

        public enum EnumTipoCampoSelecao
        {
            CIDADE = 1,
            TIPO_SANGUINEO = 2,
            ESTADO = 3,
            USUARIO = 4,
            EQUIPE = 5,
            CAMPO = 6,
            TIPO_USUARIO = 7,
            CUSTO = 8,
            PERFIL_USUARIO = 9,
            BANCO = 10,
            FORMA_PAGAMENTO = 11,
            TIPO_CHAVE_PIX = 12,
            CONTAS = 13,
            TIPO_ANEXO
        }

        public enum EnumTipoUsuario
        {
            NORMAL = 0,
            ADM = 1,
            MASTER = 2
        }

        public enum EnumSituacaoUsuario
        {
            PENDENTE = 0,
            APROVADO = 1,
            REPROVADO = 2
        }

        public enum EnumSituacaoEventoUsuario
        {
            PENDENTE = 0,
            AGUARDANDO = 1,
            APROVADO = 2,
            REPROVADO = 3,
            PAGO = 4,
            CONCLUIDO = 5
        }

        public enum EnumFinanceiroOrigemTipo
        {
            EVENTO = 0
        }

        public enum EnumPerfilPrivilegio
        {
            [Description("Cadastro de Equipe")]
            CADASTRO_EQUIPE = 1,
            [Description("Cadastro de Campos")]
            CADASTRO_CAMPO = 2,
            [Description("Cadastro de Eventos")]
            CADASTRO_EVENTO = 3,
            [Description("Liberação de Operadores")]
            LIBERACAO_USUARIO = 4,
            [Description("Perfil de operadores")]
            PERFIL = 5
        }

        public enum EnumSituacaoEvento
        {
            ABERTO = 1,
            ENCERRADO = 2,
            CANCELADO = 3,
            REAGENDADO = 4
        }

        public enum EnumFormaPagamento
        {
            [Description("Pix")]
            PIX = 1,
            [Description("Conta Corrente")]
            CONTA_CORRENTE = 2
        }

        public enum EnumTipoPix
        {
            [Description("Cpf/Cnpj")]
            CPF_CNPJ = 1,
            [Description("Telefone")]
            TELEFONE = 2,
            [Description("E-mail")]
            EMAIL = 3
        }

        public enum EnumComandoMenu
        {
            SAIR = 1,
            EDITAR_USUARIO  = 2
        }

        public static string MascaraTelefone = "(XX) XXXXX-XXXX";

        public static string MascaraCpf = "XXX.XXX.XXX-XX";

        public static string MascaraRg = "XX.XXX.XXX";

        public static string ChaveFCM = "AAAAOBmX9dU:APA91bHwLacE_fofwcSLruUHFtqPn-69Jpln0LC2eSl2_yxbiNM3N-TUCG59sXrMMMDuOmQ_IEBsyM9vRsKGrPl7QBKdMFSANYyb3GsaEe53DaCj0ZIx61uD6oeqBCWmupNrqopS56Iz";
    }
}
