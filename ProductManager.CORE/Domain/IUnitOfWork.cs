using ProductManager.CORE.Domain.Repositories;

namespace ProductManager.CORE.Domain
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        Task<int> CompleteAsync();
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
