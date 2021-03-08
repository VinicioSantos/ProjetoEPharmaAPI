using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEPharma.Domain.Entities;

namespace ProjetoEPharma.Infrastructure.Map
{
    public class PlanoClienteMap : IEntityTypeConfiguration<PlanoClienteEntity>
    {
        public void Configure(EntityTypeBuilder<PlanoClienteEntity> builder)
        {
            builder
                .HasOne(e => e.Cliente)
                .WithMany(e => e.PlanoCliente)
                .HasForeignKey(e => e.IdCliente);

            builder
                .HasOne(e => e.Plano)
                .WithMany(e => e.Clientes)
                .HasForeignKey(e => e.IdPlano);
        }
    }
}
