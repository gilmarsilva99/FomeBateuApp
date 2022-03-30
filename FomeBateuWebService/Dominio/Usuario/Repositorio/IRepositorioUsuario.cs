using FomeBateuWebService.Models;

namespace FomeBateuWebService.Infra.Repositorio
{
    public interface IRepositorioUsuario
    {
        Usuarios ObterPorEmail(string email);
        bool ValidarSenha(string senhaUsuario, string senhaDigitada);

    }
}