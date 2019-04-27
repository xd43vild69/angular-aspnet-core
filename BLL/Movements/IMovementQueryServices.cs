using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    interface IMovementQueryServices
    {
        IEnumerable<Movement> SelectMovements();
    }
}
