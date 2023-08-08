using backend.Models;

namespace backend.Repositorio.Interface
{
  public interface iUsuario
  {
    Task<List<Usuario>> BuscarTodosUsuarios();
    Task<Usuario> BuscarPorId(int id);
    Task<Usuario> Adicionar(Usuario usuario);
    Task<Usuario> Atualizar(Usuario usuario, int id);
    Task<bool> Deletar(int id);
  }
}
