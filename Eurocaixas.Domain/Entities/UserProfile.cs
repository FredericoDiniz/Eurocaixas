using System.Collections.Generic;

namespace Eurocaixas.Domain.Entities
{
    public partial class UserProfile : Entity
    {
        public UserProfile()
        {
            this.Users = new List<User>();
            this.SystemPermitions = new List<SystemPermission>();
        }

        public int UserProfileId { get; set; }
        public string ProfileName { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<SystemPermission> SystemPermitions { get; set; }
    }
}