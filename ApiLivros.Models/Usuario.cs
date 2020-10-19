using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApiLivros.Models
{
    public class Usuario : IdentityUser
    {

        [MaxLength(25)]
        public string Bairro { get; set; }

        [MaxLength(10)]
        public string CEP { get; set; }

        [MaxLength(25)]
        public string Complemento { get; set; }

        [MaxLength(50)]
        public string Endereco { get; set; }

        [MaxLength(25)]
        public string Municipio { get; set; }

        [MaxLength(15)]
        public string Telefone { get; set; }

        [MaxLength(2)]
        public string UF { get; set; }
    }
}
