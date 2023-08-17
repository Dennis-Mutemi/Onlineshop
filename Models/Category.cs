using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecomerce.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(100)]
        public string name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1,200,ErrorMessage="The display Order Value Must be between 1-200")]
        public int displayorder { get; set; }
    }
}
