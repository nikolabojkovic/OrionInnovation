using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrionInnovation.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private OrionInnovationSqlDbContext _context;

        public UnitOfWork(OrionInnovationSqlDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Data<T>() where T : class
        {
            return _context.Set<T>(); 
        }

        public Task<int> Commit()
        {
            return _context.SaveChangesAsync();
        }
    }
}