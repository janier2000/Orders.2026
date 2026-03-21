//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Orders.Backend.UnitsOfWork.Interfaces;
//using Orders.Shared.DTOs;
//using Orders.Shared.Entities;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController2 : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController2(DataContext context )
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAsync(int Id)
        {
            var country = await _context.Countries.FindAsync(Id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Country country)
        {
            _context.Update(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }
         
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            var country = await _context.Countries.FindAsync(Id);
            if (country == null)
            {
                return NotFound();
            }
            _context.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}



//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

//public class CountriesController : GenericController<Country>
//{
//    private readonly ICountriesUnitOfWork _countriesUnitOfWork;

//    public CountriesController(IGenericUnitOfWork<Country> unitOfWork, ICountriesUnitOfWork countriesUnitOfWork) : base(unitOfWork)
//    {
//        _countriesUnitOfWork = countriesUnitOfWork;
//    }

//    [AllowAnonymous]
//    [HttpGet("combo")]
//    public async Task<IActionResult> GetComboAsync()
//    {
//        return Ok(await _countriesUnitOfWork.GetComboAsync());
//    }

//    [HttpGet("full")]
//    public override async Task<IActionResult> GetAsync()
//    {
//        var response = await _countriesUnitOfWork.GetAsync();
//        if (response.WasSuccess)
//        {
//            return Ok(response.Result);
//        }
//        return BadRequest();
//    }


//    [HttpGet]
//    public override async Task<IActionResult> GetAsync(PaginationDTO pagination)
//    {
//        var response = await _countriesUnitOfWork.GetAsync(pagination);
//        if (response.WasSuccess)
//        {
//            return Ok(response.Result);
//        }
//        return BadRequest();
//    }

//    [HttpGet("{id}")]
//    public override async Task<IActionResult> GetAsync(int id)
//    {
//        var response = await _countriesUnitOfWork.GetAsync(id);
//        if (response.WasSuccess)
//        {
//            return Ok(response.Result);
//        }
//        return NotFound(response.Message);
//    }

//    [HttpGet("totalPages")]
//    public override async Task<IActionResult> GetPagesAsync([FromQuery] PaginationDTO pagination)
//    {
//        var action = await _countriesUnitOfWork.GetTotalPagesAsync(pagination);
//        if (action.WasSuccess)
//        {
//            return Ok(action.Result);
//        }
//        return BadRequest();
//    }
//}
