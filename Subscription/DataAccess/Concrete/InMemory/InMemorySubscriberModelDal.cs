using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemorySubscriberModelDal : ISubscriberModelDal
    {
        List<SubscriberModel> _subscriberModels;

        public InMemorySubscriberModelDal()
        {
            _subscriberModels = new List<SubscriberModel> { 
                new SubscriberModel(),
                new SubscriberModel(),
            
            };  
        }

        public void Add(IndexCalculationModel indexCalculationModel)
        {
            
        }

        public void Add(SubscriberModel entity)
        {
            throw new NotImplementedException();
        }

        public SubscriberModel Get(Expression<Func<SubscriberModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SubscriberModel> GetAll(Expression<Func<SubscriberModel, bool>> filter = null)
        {
            return _subscriberModels;
        }

        public List<SubscriberModelDto> GetSubscriberModelDetails()
        {
            throw new NotImplementedException();
        }

        public List<SubscriberModelDto> GetSubscriberModelDtos()
        {
            throw new NotImplementedException();
        }

        /* public List<IndexCalculationModel> getAll()
         {
             //return _subscriberModels;
         }*/

        public void Update(IndexCalculationModel indexCalculationModel)
        {
            throw new NotImplementedException();
        }

        public void Update(SubscriberModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
