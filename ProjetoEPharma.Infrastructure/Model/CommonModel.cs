using Microsoft.EntityFrameworkCore;
using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Infrastructure.Model
{
    public class CommonModel : GenericContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public CommonModel(DbContextOptions<CommonModel> options)
            : base(options)
        { 
        
        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<PlanoEntity> Plano { get; set; }
        public DbSet<PlanoClienteEntity> PlanoCliente { get; set; }

    }
}
