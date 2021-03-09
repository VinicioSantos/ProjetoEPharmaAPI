using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoEPharma.Domain.Entities
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(11)")]
        public string CPF { get; set; }
        [Column(TypeName = "varchar(18)")]
        public string CNPJ { get; set; }
        [Column(TypeName = "varchar(9)")]
        public string RG { get; set; }
        public DateTime? DataNascimento { get; set; }
        [Column(TypeName = "varchar(16)")]
        public string Telefone { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public ICollection<PlanoClienteEntity> PlanoCliente { get; set; }
    }
}
