using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EBook.Models;

namespace EBook.Dtos.RequestDto {
    public class BookRequstDto {
        [Required]
        [StringLength (100, MinimumLength = 5, ErrorMessage = "You must specify a title between 4 and 100 characters")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }
        public ICollection<Category> Category { get; set; }
        public int CategoryId { get; set; }

        public decimal Price { get; set; }
        public string CoverFileName { get; set; }
    }
}