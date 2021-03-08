using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Domain.Entities;
using System;

namespace ProjetoEPharma.Domain.Maps
{
    public class ClienteMapper
    {
        public ClienteEntity MapearEntidade(SalvaClienteDto dto)
        {
            return new ClienteEntity
            {
                Nome = dto.Nome,
                CNPJ = dto.CNPJ,
                CPF = dto.CPF,
                DataCadastro = DateTime.Now,
                DataNascimento = dto.DataNascimento,
                Email = dto.Email,
                RG = dto.RG,
                Telefone = dto.Telefone
            };
        }
    }
}
