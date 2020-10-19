using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiLivros.Models
{
    public class Pedido
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        [Required]
        public Usuario Usuario { get; set; }  
    }
}
