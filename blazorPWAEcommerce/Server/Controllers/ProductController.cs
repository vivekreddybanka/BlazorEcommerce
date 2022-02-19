using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blazorPWAEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> ProductListDetails = new List<Product>
        {
            new Product
            {
                ProductID = 1,
                ProductName = "The Hitchhiker's Guide to the Galaxy",
                ProductDescription = "The Hitchhiker's Guide to the Galaxy",
                ProductUrl = "/images/H2G2_UK_front_cover.jpg",
                ProductPrice = 9.99m
            },
            new Product
            {
                ProductID = 2,
                ProductName= "Ready Player One",
                ProductDescription = "Ready Player One is a 2018 American science fiction adventure film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg.",
                ProductUrl = "/images/Ready_Player_One_(film).png",
                ProductPrice = 19.99m
            },
            new Product
            {
                ProductID = 3,
                ProductDescription = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell",
                ProductUrl = "/images/1984first.jpg",
                ProductPrice = 29.99m
            }
        };

        [HttpGet]

        public async Task<IActionResult> GetProduct()
        {
            return  Ok(ProductListDetails);
        }
    }
}
