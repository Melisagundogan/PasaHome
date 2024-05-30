using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace PasaHome.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string img { get; set; }=null!;
        public decimal Price { get; set; }

        public string color { get; set; } = null!;

        public string CategoryName=null!;
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;

    }

}