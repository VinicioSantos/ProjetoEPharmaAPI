using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoEPharma.Domain.Entities
{
    [Table("Plano")]
    public class PlanoEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public bool PermitePessoaJuridica { get; set; }
        public DateTime DataCadastro { get; set; }
        [JsonIgnore]
        public ICollection<PlanoClienteEntity> Clientes { get; set; }

    }
}
