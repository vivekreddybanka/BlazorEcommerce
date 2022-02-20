namespace blazorPWAEcommerce.Client.Services
{
    public interface IProductService
    {
        List<Product> products { get; set; }
        Task GetProducts();
    }
}
