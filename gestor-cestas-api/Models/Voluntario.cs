using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestor_cestas_api.Models
{

    [Table("Voluntarios")]
    [SwaggerSchema(Required = new[] { "Description" })]
    public class Voluntario : LinksHATEOS
    {
        [Key]
        [SwaggerSchema("Identificador", ReadOnly = true)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        [Required]
        [JsonIgnore]
        public string Password { get; set; }

        [SwaggerSchema("Endereço")]
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public List<RegistroCesta> RegistroCesta { get; set; }

    }
}
