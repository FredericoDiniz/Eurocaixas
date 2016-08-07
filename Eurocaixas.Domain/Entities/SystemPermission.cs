using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurocaixas.Domain.Entities
{
    public partial class SystemPermission : Entity
    {
        public SystemPermission()
        {
            this.UserProfiles = new List<UserProfile>();
        }

        public int SystemPermissionId { get; set; }
        public string ModuleName { get; set; }
        public string MenuItem { get; set; }
        public string MenuUrl { get; set; }
        public bool Active { get; set; }
        public int? ParentModule { get; set; }

        public virtual SystemPermission SystemPermition { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
