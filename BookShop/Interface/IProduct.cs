using BookShop.Models;

namespace BookShop.Interface
{
    public interface IProduct
    {
        Task<List<ProductVIewModel>> GetAllProduct();
    }
}
