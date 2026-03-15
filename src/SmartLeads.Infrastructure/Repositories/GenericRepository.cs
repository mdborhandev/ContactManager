using SmartLeads.Domain.Interfaces.Repositories;
using SmartLeads.Domain.Models;
using SmartLeads.Infrastructure.Persistence;

namespace SmartLeads.Infrastructure.Repositories;

public class GenericRepository<TEntity> : BaseRepository<TEntity, int>, IGenericRepository<TEntity> where TEntity : BaseEntity
{
    public GenericRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
