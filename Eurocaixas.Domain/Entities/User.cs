using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurocaixas.Domain.Entities
{
    public partial class User : Entity
    {
        public int UserId { get; set; }
        public int UserProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
