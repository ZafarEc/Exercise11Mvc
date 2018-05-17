using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise11Mvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "You have to have a  name")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "A name must be between 2 and 15 letters long")]
        public string Name { get; set; }

        [Range(1, 100000000, ErrorMessage = "That can't legally be your price")]
        public int Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string  Description { get; set; }


    }
}