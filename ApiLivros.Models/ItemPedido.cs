using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiLivros.Models
{
    public class ItemPedido
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Pedido Pedido { get; set; }

        [Required]
        public Produto Produto { get; set; }

        [Required]
        public decimal PrecoUnitario { get; set; }

        [Required]
        public int Quantidade { get; set; }
    }
}
