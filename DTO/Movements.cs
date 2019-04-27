using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Movements: Entity
    {
        public int ValueSize { get; set; }
        public int ValuePrice { get; set; }
        public int MovementTypeID { get; set; }
        public int MovementDetailID { get; set; }
    }
}
