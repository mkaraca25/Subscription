using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubscriberModelManager : ISubscriberModelService
    {
        ISubscriberModelDal _subscriberModelDal;
        IIndexCalculationModelDal _indexCalculationModelDal;

        public SubscriberModelManager(IIndexCalculationModelDal indexCalculationModelDal)
        {
            _indexCalculationModelDal = indexCalculationModelDal;
        }

        public SubscriberModelManager(ISubscriberModelDal subscriberModelDal)
        {
            _subscriberModelDal = subscriberModelDal;

        }

        public IResult Add(SubscriberModel subscriberModel)
        {
            //Magic string
            //if (subscriberModel.TariffCurrencyId.Length>=2)
            //{
            //    return new ErrorResult(Messages.SubscriberNoInvalid);
            //}
            _subscriberModelDal.Add(subscriberModel);
            return new SuccessResult(Messages.SubscriberModelAdded);
        }
        
        public IDataResult<List<SubscriberModel>> GetAll()
        {

                if (DateTime.Now.Hour == 1)
                {
                    return new ErrorDataResult<List<SubscriberModel>>(Messages.MaintenanceTime);
                }
            return new SuccessDataResult<List<SubscriberModel>>(_subscriberModelDal.GetAll(),Messages.SubscriberModelListed);
        }

        public IDataResult<List<IndexCalculationModel>> GetAllBySubscriberNo(int SubscriberNo)
        {
            return new SuccessDataResult<List<IndexCalculationModel>>(_indexCalculationModelDal.GetAll(i => i.Cid == SubscriberNo));
        }

        public IDataResult<SubscriberModel> GetById(int id)
        {
            return new SuccessDataResult<SubscriberModel>(_subscriberModelDal.Get(p=>p.Id == id));
        }

        public List<SubscriberModelDto> GetSubscriberModelDetails()
        {
           return _subscriberModelDal.GetSubscriberModelDetails();
        }

        public IResult Update(SubscriberModel subscriberModel)
        {
            _subscriberModelDal.Update(subscriberModel);
            return new SuccessResult(Messages.SubscriberModelUpdated);
        }

        IDataResult<List<SubscriberModelDto>> ISubscriberModelService.GetSubscriberModelDetails()
        {
            throw new NotImplementedException();
        }
    }
}
