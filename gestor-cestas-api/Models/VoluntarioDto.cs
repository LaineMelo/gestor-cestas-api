using System.ComponentModel.DataAnnotations;

namespace gestor_cestas_api.Models
{
    public class VoluntarioDto
    {
        public int? Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }

    }
}
