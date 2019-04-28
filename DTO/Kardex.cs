using System;
using System.Collections.Generic;

namespace DTO
{
    public class Kardex: Entity
    {

        public int ValueSize { get; set; }
        public int ValueBalance { get; set; }
        public virtual ICollection<Movement> Movements { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
    }
}
