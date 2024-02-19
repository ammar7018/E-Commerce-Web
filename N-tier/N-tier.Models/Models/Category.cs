using N_tier.Models.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace N_tier.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage="Enter valid Range")]
        public int DisplayOrder { get; set; }

        public List<Product>? products { get; set; } = new List<Product>();
    }
}
