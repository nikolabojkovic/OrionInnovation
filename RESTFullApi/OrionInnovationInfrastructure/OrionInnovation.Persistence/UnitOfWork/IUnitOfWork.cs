using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrionInnovation.Persistence
{
    public interface IUnitOfWork
    {
        DbSet<T> Data<T>() where T : class;
        Task<int> Commit();
    }
}