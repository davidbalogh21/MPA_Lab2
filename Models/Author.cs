using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Balogh_David_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Column(TypeName = "text")]
        public string FirstName { get; set; }

        [Column(TypeName = "text")]
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}

