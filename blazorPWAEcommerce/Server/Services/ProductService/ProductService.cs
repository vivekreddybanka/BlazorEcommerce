namespace blazorPWAEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dataContext.Products.ToListAsync()
            };
            return response;
        }

        public async  Task<ServiceResponse<Product>> GetProductSingleAsync(int productID) {
            var response = new ServiceResponse<Product>();
            var product = await _dataContext.Products.FirstOrDefaultAsync(s => s.ProductID == productID);
            if (product == null)
            {
                response.Message = "Sorry, This Product does not exist.";
                response.Success = false;
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

       
    }
}
