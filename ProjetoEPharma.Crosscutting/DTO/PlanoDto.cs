using System;

namespace ProjetoEPharma.Crosscutting.DTO
{
    public class PlanoDto
    {
        public int Id { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime FimVigencia { get; set; }
        public char PermitePessoaJuridica { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}

