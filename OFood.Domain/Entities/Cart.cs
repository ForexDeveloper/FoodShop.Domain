using OFood.Domain.Commons;

namespace OFood.Domain.Entities;

public class Cart : Entity<long>
{
    public string Title { get; set; }
}