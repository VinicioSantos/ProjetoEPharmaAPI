using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Infrastructure.EntityFramework
{
    public class GenericContext : DbContext
    {
        public GenericContext(DbContextOptions options)
            : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
