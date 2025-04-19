using Application.Viewmodels;

namespace Application.Repositories
{
    public sealed class ProductRepository
    {
        private ProductRepository()
        {
        }

        public static ProductRepository Instance { get; } = new();

        public ProductListViewModel Products { get; set; } = new();
    }
}
