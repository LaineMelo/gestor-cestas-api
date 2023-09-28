using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace gestor_cestas_api.Models
{
    public class Beneficiario : LinksHATEOS
    {
        [Key]
        [SwaggerSchema("Identificador", ReadOnly = true)]
        public int Id { get; set; }
       
        [Required]  
        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string Foto { get; set; }

        public List<RegistroCesta> RegistroCesta { get; set; }
        public List<ListaNecessidade> ListaNecessidade { get; set; }
        public List<Dependente> Dependente { get; set; }
    }
}
