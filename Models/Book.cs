using System;
using System.ComponentModel.DataAnnotations;

namespace MariaDBTest.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        [Display(Name = "Titulo del Libro")]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
