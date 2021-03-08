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
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public ICollection<PlanoClienteEntity> PlanoCliente { get; set; }
    }
}
