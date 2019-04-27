using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.Movements
{
    public class MovementBill : IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public void ExcecuteMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
        }
    }
}
