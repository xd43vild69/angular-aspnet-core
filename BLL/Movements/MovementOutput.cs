using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Movements
{
    public class MovementOutput: IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public void ExcecuteMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            if (kardex.ValueSize - movement.ValueSize >= 0)
            {
                kardex.ValueSize = kardex.ValueSize - movement.ValueSize;
            }
            else
            {
                throw new ApplicationException("Negative Kardex.");
            }            
        }
    }
}
