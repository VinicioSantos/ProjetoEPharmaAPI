using System;
using System.Collections.Generic;

namespace ProjetoEPharma.Crosscutting.DTO
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<PlanoDto> Planos { get; set; }
    }
}

