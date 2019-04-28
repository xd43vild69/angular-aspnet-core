using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Work
    {
        public virtual ICollection<Stage> Stages { get; set; }
    }
}
