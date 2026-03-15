using SmartLeads.Domain.Interfaces.Repositories;
using SmartLeads.Infrastructure.Persistence;
using SmartLeads.Infrastructure.Repositories.Implementation;

namespace SmartLeads.Infrastructure.Repositories;

public class UnitOfWork : Domain.Interfaces.Repositories.IUnitOfWork
{
    protected readonly ApplicationDbContext _dbContext;

    #region Repositories
    public IContactRepository contactRepository { get; private set; }
    #endregion

    public UnitOfWork(ApplicationDbContext context)
    {
        _dbContext = context;
        contactRepository = new ContactRepository(context);
    }

    public async Task SaveAsync(CancellationToken token = default)
    {
        await _dbContext.SaveChangesAsync(token);
    }

    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
    }
}
