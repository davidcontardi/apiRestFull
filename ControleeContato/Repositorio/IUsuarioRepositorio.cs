using ControleeContato.Models;

namespace ControleeContato.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(ContatoModel contato);

        UsuarioModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
