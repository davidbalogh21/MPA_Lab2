using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Balogh_David_Lab2.Models
{
    public class Book
        {
         public int ID { get; set; }

        [Column(TypeName="text")]
        public string Title { get; set; }


        public Author? Author { get; set; }
        public int AuthorID { get; set; }

        public int Price { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<PublishedBook>? PublishedBooks { get; set; }
    }
}

