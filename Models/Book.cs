using System;
using System.ComponentModel.DataAnnotations;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string ISBN { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title { get; set; }
        [Required]
        [MaxLength(35)]
        public string Genre { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
      
        public ApplicationUser User { get; set; }
        [Required]
        public string UserId { get; set; }



    }
}