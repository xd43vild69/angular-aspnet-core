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

        public void UndoMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            if (ValidateUndo())
            {
                kardex.ValueSize = kardex.ValueSize - movement.ValueSize;
            }
        }

        private bool ValidateUndo()
        {
            return true;
        }

    }
}
