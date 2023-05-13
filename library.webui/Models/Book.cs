using System.ComponentModel.DataAnnotations;

namespace library.webui.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Book Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Name cannot exceed 15 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 10000)]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(25, ErrorMessage = "Description cannot exceed 25 characters.")]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "CategoryId is required")]
        public int? CategoryId { get; set; }

    }
}