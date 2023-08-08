using backend.Models;
using backend.Repositorio.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuarioController : ControllerBase
  {
    private readonly iUsuario _usuarioRepositorio;
    public UsuarioController(iUsuario usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult<List<Models.Usuario>>> BuscarTodosUsuarios()
    {
      List<Usuario> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
      return Ok(usuarios);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<Models.Usuario>>> BuscarPorId(int id)
    {
      Usuario usuarios = await _usuarioRepositorio.BuscarPorId(id);
      return Ok(usuarios);
    }

    [HttpPost]
    public async Task<ActionResult<Usuario>> Cadastrar([FromBody] Usuario usuarioModel)
    {
      Usuario usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
      return Ok(usuario);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Usuario>> Atualizar([FromBody] Usuario usuarioModel, int id)
    {
      usuarioModel.Id = id;
      Usuario usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);
      return Ok(usuario);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Usuario>> Apagar(int id)
    {
      bool apagado = await _usuarioRepositorio.Deletar(id);
      return Ok(apagado);
    }
  }
}
