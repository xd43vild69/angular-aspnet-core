using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Movements
{
    public class Output: IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public Kardex ExcecuteMovementOnKardex(Movement movement, Kardex kardex)
        {
            if (kardex.ValueSize - movement.ValueSize >= 0)
            {
                kardex.ValueSize = kardex.ValueSize - movement.ValueSize;
            }
            else
            {
                throw new ApplicationException("Negative Kardex.");
            }
            return kardex;
        }

        public Kardex UndoMovementOnKardex(Movement movement, Kardex kardex)
        {
            if (ValidateUndo(movement, kardex))
            {
                kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
            }
            return kardex;
        }

        public Kardex UpdateMovementOnKardex(Movement movement, Kardex kardex)
        {
            if (ValidateUpdate())
            {
                kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
            }
            return kardex;
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
