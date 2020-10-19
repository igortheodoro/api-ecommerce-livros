using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiLivros.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(25)]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }
    }
}
