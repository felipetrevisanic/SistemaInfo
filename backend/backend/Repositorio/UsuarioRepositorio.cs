using backend.Data;
using backend.Models;
using backend.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositorio
{
  public class UsuarioRepositorio : iUsuario
  {
    private readonly DataContext _dataContext;
    public UsuarioRepositorio(DataContext dataContext)
    {
      _dataContext = dataContext;
    }
    public async Task<Usuario> BuscarPorId(int id)
    {
      return await _dataContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Usuario>> BuscarTodosUsuarios()
    {
      return await _dataContext.Usuarios.ToListAsync();
    }

    public async Task<Usuario> Adicionar(Usuario usuario)
    {
      await _dataContext.Usuarios.AddAsync(usuario);
      await _dataContext.SaveChangesAsync();

      return usuario;
    }

    public async Task<Usuario> Atualizar(Usuario usuario, int id)
    {
      Usuario usuarioId = await BuscarPorId(id);
      if(usuarioId == null)
      {
        throw new Exception($"Usuario para o ID: {id} bão foi encontrado no banco de dados");
      }


      usuarioId.Nome = usuario.Nome;
      usuarioId.Rua = usuario.Rua;
      usuarioId.Numero = usuario.Numero;
      usuarioId.Bairro = usuario.Bairro;
      usuarioId.Cidade = usuario.Cidade;
      usuarioId.Telefone = usuario.Telefone;

      _dataContext.Usuarios.Update(usuarioId);
      await _dataContext.SaveChangesAsync();

      return usuarioId;
  }

    public async Task<bool> Deletar(int id)
    {
      Usuario usuarioId = await BuscarPorId(id) ?? throw new Exception($"Usuario para o ID: {id} bão foi encontrado no banco de dados");
      _dataContext.Usuarios.Remove(usuarioId);
      await _dataContext.SaveChangesAsync();

      return true;
    }
  }
}
