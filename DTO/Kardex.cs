using System;
using System.Collections.Generic;

namespace DTO
{
    public class Kardex: Entity
    {
        public virtual ICollection<Movement> Movements { get; set; }
    }
}
