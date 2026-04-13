using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.Repositories.Interface
{
    public interface IProductsRepository
    {
        Task<ActionResponse<Product>> GetAsync(int id);
    }
}