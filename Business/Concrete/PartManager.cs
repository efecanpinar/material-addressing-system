using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PartManager : IPartService
    {
        private IPartDal _partDal;

        public PartManager(IPartDal partDal)
        {
            _partDal = partDal;
        }

        public IDataResult<Part> GetById(int partId)
        {
            return new SuccessDataResult<Part>(_partDal.Get(c => c.PartId == partId));
        }

        public IDataResult<List<Part>> GetList()
        {
            return new SuccessDataResult<List<Part>>(_partDal.GetList().ToList());
        }

        public IResult Add(Part part)
        {
            _partDal.Add(part);
            return new SuccessResult(Messages.PartAdded);
        }

        public IResult Update(Part part)
        {
            _partDal.Update(part);
            return new SuccessResult(Messages.PartUpdated);
        }

        public IResult Delete(Part part)
        {
            _partDal.Delete(part);
            return new SuccessResult(Messages.PartDeleted);
        }
    }
}
