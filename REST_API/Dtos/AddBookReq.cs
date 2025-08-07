using System.ComponentModel.DataAnnotations;

namespace REST_API.Dtos
{
    public class AddBookReq
    {

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100, ErrorMessage = "Name cannot be more than 100 characters")]
        [MinLength(1, ErrorMessage = "Name cannot be less than 1 character")]
        public string Name { get; set; } = string.Empty;



        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200, ErrorMessage = "Description cannot be more than 200 characters")]
        [MinLength(1, ErrorMessage = "Description cannot be less than 1 character")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10,000")]
        public decimal Price { get; set; }



        [Required(ErrorMessage = "AuthorName is required")]
        [MaxLength(50, ErrorMessage = "AuthorName cannot be more than 50 characters")]
        [MinLength(1, ErrorMessage = "AuthorName cannot be less than 1 character")]
        public string AuthorName { get; set; } = string.Empty;
    }
}
