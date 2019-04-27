using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.Movements
{
    public class MovementBill : IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public Kardex ExcecuteMovement(Kardex kardex)
        {
            return null;
        }
    }
}
