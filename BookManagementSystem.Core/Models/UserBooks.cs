using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Core.Models
{
    public class UserBooks
    {
        public Guid Id { get; set; }
        public DateOnly ReservedOn = DateOnly.FromDateTime(DateTime.UtcNow);
        public DateOnly ReservedTo { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public bool IsDeleted { get; set; }
    }
}
