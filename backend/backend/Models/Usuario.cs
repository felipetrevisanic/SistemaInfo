using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
  public class Usuario
  {
    [Column("id")]
    public int Id { get; set; }
    [Column("codigo")]
    public required string Codigo { get; set; }
    [Column("nome")]
    public required string Nome { get; set; }
    [Column("cpf")]
    public required string Cpf { get; set; }
    [Column("rua")]
    public string? Rua { get; set; }
    [Column("numero")]
    public int Numero { get; set; }
    [Column("bairro")]
    public string? Bairro { get; set; }
    [Column("cidade")]
    public string? Cidade { get; set; }
    [Column("telefone")]
    public string? Telefone { get; set; }
  }
}
