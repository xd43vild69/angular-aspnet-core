using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Linq;

namespace BLL.Movements
{
    public class Bill : IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public Kardex ExcecuteMovementOnKardex(Kardex kardex)
        {
            kardex.ValueSize = kardex.ValueSize + kardex.Movements.FirstOrDefault().ValueSize;
            return kardex;
        }

        public Kardex UndoMovementOnKardex(Kardex kardex)
        {
            if (ValidateUndo())
            {
                kardex.ValueSize = kardex.ValueSize - kardex.Movements.FirstOrDefault().ValueSize;
            }
            return kardex;
        }

        public Kardex UpdateMovementOnKardex(Kardex kardex)
        {
            if (ValidateUpdate())
            {
                kardex.ValueSize = kardex.ValueSize - kardex.Movements.FirstOrDefault().ValueSize;
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
