
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Required(ErrorMessage = "Category Id is required")]
    public int Id { get; set; }


    [Required(ErrorMessage = "Name is required.")]
    [MaxLength(15, ErrorMessage = "Name cannot exceed 15 characters.")]
    public string Name { get; set; }
}