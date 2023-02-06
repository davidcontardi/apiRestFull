using ControleeContato.Models;

namespace ControleeContato.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);

        UsuarioModel BuscarPorLogin(string login);

        UsuarioModel BuscarPorEmailELogin(string email, string login);

        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);

        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);

        bool Apagar(int id);
    }
}
