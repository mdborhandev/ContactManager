using ContactManager.Domain.Common;
using ContactManager.Domain.Users;
using ContactManager.Domain.Contacts;

namespace ContactManager.Domain.Tags;

public class Tag : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Color { get; set; } // Hex value or name

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<ContactTag> ContactTags { get; set; } = new List<ContactTag>();
}

public class ContactTag
{
    public int ContactId { get; set; }
    public Contact Contact { get; set; } = null!;

    public int TagId { get; set; }
    public Tag Tag { get; set; } = null!;
}
