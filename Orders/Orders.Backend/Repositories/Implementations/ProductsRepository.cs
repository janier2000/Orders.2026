using Orders.Backend.Data;
using Orders.Shared.Entities;
using Orders.Backend.Repositories.Interface;


namespace Orders.Backend.Repositories.Implementations
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly DataContext _context;
       

        public ProductsRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        // async Task<Shared.Responses.ActionResponse<Product>> IProductsRepository.GetAsync(int id)
        //{
        //    var product = await _context.Products
        //                                .Include(x => x.ProductImages)
        //                                .Include(x => x.ProductCategories!)
        //                                .ThenInclude(x => x.Category)
        //                                .FirstOrDefaultAsync(x => x.Id == id);
        //    if (product == null)
        //    {
        //        return new Shared.Responses.ActionResponse<Product>
        //        {
        //            WasSuccess = false,
        //            Message = "Estado no existe"
        //        };
        //    }
        //    return new Shared.Responses.ActionResponse<Product>
        //    {
        //        WasSuccess = true,              
        //        Result = product
        //    };
        //}


        //public override async Task<ActionResponse<Product>> GetAsync(int id)
        //{
        //    var product = await _context.Products
        //                            .Include(s => s.ProductCategories)
        //                            .FirstOrDefaultAsync(s => s.Id == id);

        //    //var product = await _context.Products
        //    //    .Include(x => x.ProductImages)
        //    //    .Include(x => x.ProductCategories!)
        //    //    .ThenInclude(x => x.Category)
        //    //    .FirstOrDefaultAsync(x => x.Id == id);
        //    if (product == null)
        //    {
        //        return new ActionResponse<Product>
        //        {
        //            WasSuccess = false,
        //            Message = "Estado no existe"
        //        };
        //    }
        //    return new ActionResponse<Product>
        //    {
        //        WasSuccess = true,
        //        Message = "Estado no existe"
        //        //Result = product
        //    };
        //}





        //public override async Task<ActionResponse<Product>> GetAsync(int id)
        //{
        //    var product = await _context.Products
        //        .Include(x => x.ProductImages)
        //        .Include(x => x.ProductCategories!)
        //        .ThenInclude(x => x.Category)
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (product == null)
        //    {
        //        return new ActionResponse<Product>
        //        {
        //            WasSuccess = false,
        //            Message = "Producto no existe"
        //        };
        //    }

        //    return new ActionResponse<Product>
        //    {
        //        WasSuccess = true,
        //        Result = product
        //    };
        //}

    }
}
