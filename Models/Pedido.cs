using System.ComponentModel.DataAnnotations;

namespace ProjetoRestaurante.Models;

public class Pedido
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int MesaId { get; set; }
    public Mesa? Mesa{ get; set; }

    public DateTime DataHora {get; set;} = DateTime.Now;

    public string Status { get; set; } = "Pendente";

    public decimal ValorTotal { get; set; }

    public List<ItemPedido> Itens {get; set; } = new();
}

public class ItemPedido
{
    public int Id { get; set; }

    public int PedidoId { get; set; }

    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }

    public int Quantidade { get; set; }
    public decimal PrecoNoMomento { get; set; }
}