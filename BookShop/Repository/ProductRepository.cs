using BookShop.Data;
using BookShop.Interface;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) 
        { 
            _context = context;
        }


        public async Task<List<ProductVIewModel>> GetAllProduct()
        {
            return await _context.Product.Select(x => new ProductVIewModel {
                Id = x.Id,
                Price=x.Price,
                Name=x.Name,
                Qty=x.Qty,
            
            }).ToListAsync();
        }
    }
}
