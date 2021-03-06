﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Movements
{
    public class Output: IMovementCommandService
    {
        public Kardex Kardex { get; set; }

        public Kardex ExcecuteMovementOnKardex(Kardex kardex)
        {
            if (kardex.ValueSize - kardex.Movements.FirstOrDefault().ValueSize >= 0)
            {
                kardex.ValueSize = kardex.ValueSize - kardex.Movements.FirstOrDefault().ValueSize;
            }
            else
            {
                throw new ApplicationException("Negative Kardex.");
            }
            return kardex;
        }

        public Kardex UndoMovementOnKardex(Kardex kardex)
        {
            if (ValidateUndo(kardex))
            {
                kardex.ValueSize = kardex.ValueSize + kardex.Movements.FirstOrDefault().ValueSize;
            }
            else
            {
                throw new ApplicationException("Negative Kardex.");
            }
            return kardex;
        }

        public Kardex UpdateMovementOnKardex(Kardex kardex)
        {
            if (ValidateUpdate())
            {
                kardex.ValueSize = kardex.ValueSize + kardex.Movements.FirstOrDefault().ValueSize;
            }
            else
            {
                throw new ApplicationException("Negative Kardex.");
            }
            return kardex;
        }

        private bool ValidateUndo(Kardex kardex)
        {
            bool isValid = true;

            if(kardex.ValueSize - kardex.Movements.FirstOrDefault().ValueSize <= 0)
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
