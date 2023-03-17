using Shared.Models;

namespace ProductManager.CORE.Domain.Entities
{
    public class Product : IAggregateRoot
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public Guid? ProductCode { get; set; }
    }
}
