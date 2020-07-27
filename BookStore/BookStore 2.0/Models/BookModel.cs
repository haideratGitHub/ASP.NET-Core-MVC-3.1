using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore_2._0.Models
{
    public class BookModel
    {
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
    }
}
