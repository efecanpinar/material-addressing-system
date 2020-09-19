using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPartService
    {
        IDataResult<Part> GetById(int partId);
        IDataResult<List<Part>> GetList();
        IResult Add(Part part);
        IResult Update(Part part);
        IResult Delete(Part part);
    }
    
}
