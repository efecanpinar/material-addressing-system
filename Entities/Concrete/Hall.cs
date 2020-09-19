using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abtract;

namespace Entities.Concrete
{

    public class Hall : IEntity
    {
        [Key] 
        public int HallId { get; set; }
        public string HallName { get; set; }
    }
}
