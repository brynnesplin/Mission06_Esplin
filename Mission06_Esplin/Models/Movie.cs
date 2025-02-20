using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Esplin.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue)]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }


    }
}
