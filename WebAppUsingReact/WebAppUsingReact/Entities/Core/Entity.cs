using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppUsingReact.Entities.Core
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime LastEditedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
