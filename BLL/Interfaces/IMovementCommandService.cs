using DTO;
using System;
using System.Collections.Generic;

namespace BLL.Movements
{
    public interface IMovementCommandService
    {
        void ExcecuteMovementOnKardex(Movement movement, ref Kardex kardex);
        void UndoMovementOnKardex(Movement movement, ref Kardex kardex);
        void UpdateMovementOnKardex(Movement movement, ref Kardex kardex);
    }
}
