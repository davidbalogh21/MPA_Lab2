using System;
namespace Balogh_David_Lab2.Models
{
    public class PublishedBook
    
       {
        public int? PublisherID { get; set; }
        public int? BookID { get; set; }
        public Publisher? Publisher { get; set; }
        public Book? Book { get; set; }
    }
}

