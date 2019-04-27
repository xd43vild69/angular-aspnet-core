using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public interface IMovementCommandService
    {
        int InsertMovement();
        void UpdateMovement();
        void DeleteMovement();
    }
}
