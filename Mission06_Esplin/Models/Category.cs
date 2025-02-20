using System.ComponentModel.DataAnnotations;

namespace Mission06_Esplin.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
