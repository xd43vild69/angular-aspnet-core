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

        public void UndoMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            if (ValidateUndo(movement, kardex))
            {
                kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
            }
        }

        public void UpdateMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            if (ValidateUpdate())
            {
                kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
            }
        }

        private bool ValidateUndo(Movement movement, Kardex kardex)
        {
            bool isValid = true;

            if(kardex.ValueSize - movement.ValueSize <= 0)
            {
                isValid = false;
            }

            return isValid;
        }
        private bool ValidateUpdate()
        {
            return true;
        }
    }
}
