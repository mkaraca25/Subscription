using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubscriberModelService
    {
        IDataResult<List<SubscriberModel>> GetAll();
        IDataResult<List<IndexCalculationModel>> GetAllBySubscriberNo(int SubscriberNo);
        IDataResult<SubscriberModel> GetById(int id);
        IDataResult<List<SubscriberModelDto>> GetSubscriberModelDetails();
        IResult Add(SubscriberModel subscriberModel);
        IResult Update(SubscriberModel subscriberModel);
    }
}
