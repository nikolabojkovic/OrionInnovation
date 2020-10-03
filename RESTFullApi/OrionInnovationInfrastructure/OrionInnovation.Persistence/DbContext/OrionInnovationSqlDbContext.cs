using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using OrionInnovation.Domain;

namespace OrionInnovation.Persistence
{
    public class OrionInnovationSqlDbContext : DbContext
    {
        public OrionInnovationSqlDbContext(DbContextOptions<OrionInnovationSqlDbContext> options)
            :base(options) { }

           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.UseEntityTypeConfiguration(typeof(TextConfiguration).Assembly);
            RegisterEntities(modelBuilder);
        }

        private void RegisterEntities(ModelBuilder modelBuilder)
        {
            MethodInfo entityMethod = typeof(ModelBuilder).GetMethods()
                                                          .First(m => m.Name == "Entity" 
                                                                   && m.IsGenericMethod);

            var entityTypes = Assembly.GetAssembly(typeof(Text))
                .GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Entity)) 
                         && !x.IsAbstract);

            foreach (var type in entityTypes)
            {
                entityMethod.MakeGenericMethod(type)
                            .Invoke(modelBuilder, new object[] { });
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}