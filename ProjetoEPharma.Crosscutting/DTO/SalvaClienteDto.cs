using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Crosscutting.DTO
{
    public class SalvaClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<int> IdsPlanos { get; set; }
    }
}
