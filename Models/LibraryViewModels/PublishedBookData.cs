using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Balogh_David_Lab2.Models.LibraryViewModels
{
    public class PublishedBookData
    {
        public int BookID { get; set; }

        [Column(TypeName = "text")]
        public string Title { get; set; }
        public bool IsPublished { get; set; }
    }
}

