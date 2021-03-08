using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoEPharma.Domain.Entities
{
    [Table("PlanoCliente")]
    public class PlanoClienteEntity
    {
        [Key]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdPlano { get; set; }

        [ForeignKey(nameof(IdCliente))]
        public ClienteEntity Cliente { get; set; }

        [ForeignKey(nameof(IdPlano))]
        public PlanoEntity Plano { get; set; }
    }
}
