using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BookStore_2._0.Models
{
    public class BookModel
    {
        [DataType(DataType.Date)]
        [Display(Name ="Choose date: ")]
        public String MyField { get; set; }
        public int Id { get; set; }
        [StringLength(100,MinimumLength =5)]
        [Required(ErrorMessage ="Please enter the title of your book")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        [Required]
        public int Totalpages { get; set; }

        [Display(Name ="Choose the cover photo of your book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
    }
}
