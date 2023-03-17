using ProductManager.CORE.Domain;
using ProductManager.CORE.Domain.Repositories;
using ProductManager.CORE.Persistence.Repositories;

namespace ProductManager.CORE.Persistence
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly ProductsManagerDbContext _context;
        public IProductRepository ProductRepository { get; private set; }

        public UnitOfWork(ProductsManagerDbContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }
    }
}
