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
    public class CabinetManager : ICabinetService
    {
        private ICabinetDal _cabinetDal;

        public CabinetManager(ICabinetDal cabinetDal)
        {
            _cabinetDal = cabinetDal;
        }

        public IResult Add(Cabinet cabinet)
        {
            _cabinetDal.Add(cabinet);
            return new SuccessResult(Messages.CabinetAdded);
        }

        public IResult Delete(Cabinet cabinet)
        {
            _cabinetDal.Delete(cabinet);
            return new SuccessResult(Messages.CabinetDeleted);
        }

        public IDataResult<Cabinet> GetById(int cabinetId)
        {
            return new SuccessDataResult<Cabinet>(_cabinetDal.Get(p=>p.CabinetId==cabinetId));
        }

        public IDataResult<List<Cabinet>> GetList()
        {
            return new SuccessDataResult<List<Cabinet>>(_cabinetDal.GetList().ToList());
        }

        public IResult Update(Cabinet cabinet)
        {
            _cabinetDal.Delete(cabinet);
            return new SuccessResult(Messages.CabinetUpdated);
        }
    }
}
