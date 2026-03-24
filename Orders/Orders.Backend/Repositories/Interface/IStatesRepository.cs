using Orders.Shared.Entities;
using Orders.Shared.Entities.Responses;
//using Orders.Shared.Responses;
//using Orders.Shared.DTOs;

namespace Orders.Backend.Repositories.Interfaces
{
    public interface IStatesRepository
    {
        Task<ActionResponse<State>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<State>>> GetAsync();

        //Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

        //Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);


    }
}