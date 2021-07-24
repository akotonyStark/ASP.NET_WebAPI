using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuotationsAPI.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25), MinLength(3), MaxLength(25)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}