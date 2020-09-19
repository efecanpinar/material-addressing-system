using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abtract;

namespace Entities.Concrete
{ 
    public class Shelf : IEntity
    {
        [Key]
        public int ShelfId { get; set; }
        public int CabinetId { get; set; }
    }
}
