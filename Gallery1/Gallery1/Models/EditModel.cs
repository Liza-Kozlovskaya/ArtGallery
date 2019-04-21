using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class EditModel
    {
        public ArtWork ArtWorks { get; set; }
        public PhotoArt PhotoArt { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public IEnumerable<Author> Authors { get; set; }

        [NotMapped]
        public List<Author> AuthorsCollection { get; set; }
    }
}