using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCellDal : EfEntityRepositoryBase<Cell, StockTrackingContext>, ICellDal
    {
    }
}
