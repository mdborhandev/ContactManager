using SmartLeads.Domain.Interfaces.Repositories;

namespace SmartLeads.Domain.Interfaces.Repositories;

public interface IUnitOfWork : IAsyncDisposable
{
    IContactRepository contactRepository { get; }
    
    Task SaveAsync(CancellationToken token = default);
}
