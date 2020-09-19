using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;
using Core.Entities.Abtract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IShelfDal : IEntityRepository<Shelf>
    {
    }
}
