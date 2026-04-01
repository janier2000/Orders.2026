using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Entities.Responses;

namespace Orders.Backend.Repositories.Interface
{
    public interface ICitiesRepository
    {
        Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
        Task<IEnumerable<City>> GetComboAsync(int stateId);
    }
}