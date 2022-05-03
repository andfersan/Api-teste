using Api_Data.ORMMapping;
using Microsoft.EntityFrameworkCore;

namespace Api_Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set;}

        public MyContext (DbContextOptions<MyContext> options) : base(options) { }
        
        // Serve para fazer  o mapeamento e gerar a tabela
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Cria um novo User Map e Configura na modelbuilder
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
        
    }
}
