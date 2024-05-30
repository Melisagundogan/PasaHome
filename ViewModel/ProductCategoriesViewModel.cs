using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PasaHome.Models.Data;
namespace PasaHome.ViewModel
{
    public class ProductCategoriesViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category>Categories { get; set; }
    }
}
