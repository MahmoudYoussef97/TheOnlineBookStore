using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheOnlineBookStore.Models
{
    public class Book
    {   
        public int Id { get; set; }
        [Required, MaxLength(60)]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; } = 0;
        [Required, MaxLength(700)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public bool IsFree { get; set; }
    }
}
