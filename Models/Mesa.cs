using System.ComponentModel.DataAnnotations;

namespace ProjetoRestaurante.Models;

public class Mesa
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Numero { get; set; }

    public bool EstaOcupada { get; set; } = false;

    public string TokenAcesso { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);
}