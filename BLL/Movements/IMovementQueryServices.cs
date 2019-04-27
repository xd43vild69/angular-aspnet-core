using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Movements
{
    interface IMovementQueryServices
    {
        IEnumerable<Movement> SelectMovements();
    }
}
