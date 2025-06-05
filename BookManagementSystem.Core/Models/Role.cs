using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Core.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<UserRoles>? UserRoles { get; set; }
        public bool IsDeleted { get; set; }
    }
}
