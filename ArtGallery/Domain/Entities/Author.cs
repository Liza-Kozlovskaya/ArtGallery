using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Author_Name { get; set; }
        public string Pseudonym { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string Biography { get; set; }
        public string Education { get; set; }
        public string Sex { get; set; }
    }
}

