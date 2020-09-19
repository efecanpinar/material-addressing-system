using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abtract;

namespace Entities.Concrete
{
    public class Cabinet : IEntity
    {
        [Key]
        public int CabinetId { get; set; }
        public int HallId { get; set; }
    }
}
