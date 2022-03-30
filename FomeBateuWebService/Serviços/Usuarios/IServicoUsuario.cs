using FomeBateuWebService.Dominio.Usuario.Dto;

namespace FomeBateuWebService.Serviços.Usuarios
{
    public interface IServicoUsuario
    {
        UsuarioDto ObterPorEmail(string email);

        bool ValidarSenha(string email, string senha);
    }
}