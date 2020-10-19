using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiLivros.Models
{
    public class Usuario : IdentityUser
    {

        [Required]
        [MaxLength(25)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(10)]
        public string CEP { get; set; }

        [Required]
        [MaxLength(25)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(25)]
        public string Municipio { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(2)]
        public string UF { get; set; }
    }
}
