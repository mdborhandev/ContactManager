using ContactManager.Domain.Common;
using ContactManager.Domain.Contacts;

namespace ContactManager.Domain.Notes;

public class Note : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    
    public int ContactId { get; set; }
    public Contact Contact { get; set; } = null!;
}
