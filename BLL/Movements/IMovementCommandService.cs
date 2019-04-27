using DTO;
using System;
using System.Collections.Generic;

namespace BLL.Movements
{
    public interface IMovementCommandService
    {
        Kardex ExcecuteMovement(Kardex kardex);
    }
}
