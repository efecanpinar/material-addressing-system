using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abtract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Concrete
{
    public class Cell : IEntity
    {
        [Key]
        public int CellId { get; set; }
        public int PartId { get; set; }
    }

  
}
