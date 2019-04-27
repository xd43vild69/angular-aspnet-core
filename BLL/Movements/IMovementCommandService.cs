using DTO;
using System;
using System.Collections.Generic;

namespace BLL.Movements
{
    public interface IMovementCommandService
    {
        void ExcecuteMovementOnKardex(Movement movement, ref Kardex kardex);
    }
}
