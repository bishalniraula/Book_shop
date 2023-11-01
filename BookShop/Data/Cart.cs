using System.ComponentModel.DataAnnotations;

namespace BookShop.Data
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductQty { get; set; }
        public int Price { get; set; }
    }
}
