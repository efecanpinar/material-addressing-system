using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abtract;

namespace Entities.Concrete
{
    public class Part : IEntity
    {
        [Key]
        public int PartId { get; set; }
        public int PartNo { get; set; }
        public string PartName { get; set; }
    }
}
