using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace candrea_anamaria_lab2.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publisher Publishers { get; set; }
        public PublishedBook publishedBook { get; set; }
        public Book Book { get; set; }
    }
}
