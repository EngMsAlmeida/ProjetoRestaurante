using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace ProjetoRestaurante.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    public string Nome { get; set; } = string.Empty;
    public string? Descricao { get; set; }

    [Required]
    public decimal Preco { get; set; }

    public string? Categoria { get; set; } // Ex: Bebidas, Lanches, Sobremesas

    public bool Disponivel { get; set; } = true;
}