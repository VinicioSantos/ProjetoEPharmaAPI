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
            optionsBuilder.UseSqlServer("Server=DESKTOP-0L3GQTK\\LOCALHOST;Database=epharma;User Id=sa;Password=root;");
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
