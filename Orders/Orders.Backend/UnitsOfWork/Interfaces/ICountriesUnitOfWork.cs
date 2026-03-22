//using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Entities.Responses;
//using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Interfaces
{
    public interface ICountriesUnitOfWork
    {
        Task<ActionResponse<Country>> GetAsync(int id);
        Task<ActionResponse<IEnumerable<Country>>> GetAsync();

        //Task<IEnumerable<Country>> GetComboAsync();
        //Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);
        //Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}