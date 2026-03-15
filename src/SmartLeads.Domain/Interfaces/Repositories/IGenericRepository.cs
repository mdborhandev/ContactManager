using SmartLeads.Domain.Interfaces.Repositories;
using SmartLeads.Domain.Models;

namespace SmartLeads.Domain.Interfaces.Repositories;

public interface IGenericRepository<TEntity> : IBaseRepository<TEntity, int> where TEntity : BaseEntity
{
}
