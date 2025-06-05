using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Core.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string GenreName { get; set; }
        public IEnumerable<BookGeneres> BookGeneres { get; set; }
        public bool IsDeleted { get; set; }
    }
}
