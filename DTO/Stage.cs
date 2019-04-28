using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Stage: Entity
    {
        public virtual Budget Budget { get; set; }
    }
}
