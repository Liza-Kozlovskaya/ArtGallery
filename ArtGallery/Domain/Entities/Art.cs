using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Entities
{
    public class Art
    {
        public int ArtId { get; set; }
        public string ArtName { get; set; }
        public string ArtOriginName { get; set; }
        public string  CreationDate { get; set; } //DateTime ???
        public string Description { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
