using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Domain.Entities;
using System;

namespace ProjetoEPharma.Domain.Maps
{
    public class PlanoMapper
    {
        public PlanoEntity MapearEntidade(PlanoDto dto)
        {
            return new PlanoEntity
            {
                InicioVigencia = dto.InicioVigencia,
                FimVigencia = dto.FimVigencia,
                PermitePessoaJuridica = dto.PermitePessoaJuridica,
                DataCadastro = dto.DataCadastro
            };
        }
    }
}
