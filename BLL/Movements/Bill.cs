using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.Movements
{
    public class Bill : IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public Kardex ExcecuteMovementOnKardex(Movement movement, Kardex kardex)
        {
            kardex.ValueSize = kardex.ValueSize + movement.ValueSize;
            return kardex;
        }

        public Kardex UndoMovementOnKardex(Movement movement, Kardex kardex)
        {
            if (ValidateUndo())
            {
                kardex.ValueSize = kardex.ValueSize - movement.ValueSize;
            }
            return kardex;
        }

        public Kardex UpdateMovementOnKardex(Movement movement, Kardex kardex)
        {
            if (ValidateUpdate())
            {
                kardex.ValueSize = kardex.ValueSize - movement.ValueSize;
            }
            return kardex;
        }

        private bool ValidateUndo()
        {
            return true;
        }

        private bool ValidateUpdate()
        {
            return true;
        }
    }
}
