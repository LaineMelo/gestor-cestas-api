using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestor_cestas_api.Models
{

    [Table("RegistroCesta")]
    [SwaggerSchema(Required = new[] { "Description" })]
    public class RegistroCesta
    {
        [Key]
        public int Id { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdVoluntario { get; set; }
        public int QuantidadeCesta { get; set; }
        public DateTime DataEntrega { get; set; }

        // Propriedades de navegação para as chaves estrangeiras
        public Beneficiario Beneficiario { get; set; }
        public Voluntario Voluntario { get; set; }

    }
}
