using System;
using System.Collections.Generic;

namespace MariaDBTest.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
