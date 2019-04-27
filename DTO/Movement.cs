using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Movement: Entity
    {
        public int ValueSize { get; set; }
        public int ValuePrice { get; set; }
        public int MovementTypeID { get; set; }
        public virtual ICollection<MovementDetail> MovementDetails { get; set; }
        public MovementTypeEnum MovementType { get; set; }
    }
    public enum MovementTypeEnum { Bill, Referrals, Output, CreditNote, DebitNote};
}
