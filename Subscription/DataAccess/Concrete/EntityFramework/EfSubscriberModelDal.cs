using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfSubscriberModelDal : EfEntityRepositoryBase<SubscriberModel, SubscriptionContext>, ISubscriberModelDal
    {
        public List<SubscriberModelDto> GetSubscriberModelDetails()
        {
            using (SubscriptionContext context =new SubscriptionContext())
            {
                var result = from s in context.subscriberModel
                             join i in context.indexCalculation
                             on s.Id equals i.Cid
                             select new SubscriberModelDto { 
                             SubscriberId=s.SubscriberId,
                             Id=s.Id,
                             SubscriberNo = s.SubscriberNo,
                             OpeningDate=s.OpeningDate,
                             Address=s.Address,
                             AdSoyad=s.AdSoyad,
                             TariffCurrencyId=s.TariffCurrencyId,
                             KdvRateId=s.KdvRateId,
                             CalculationDate=i.CalculationDate,
                             IndexKdvRateId = i.IndexKdvRateId, 
                             TariffUnitPrice=i.TariffUnitPrice,
                             CalculationType=i.CalculationType, 
                             FirstIndex=i.FirstIndex,
                             LastIndex=i.LastIndex,
                             Consumption=i.Consumption,
                             TariffTotalPrice=i.TariffTotalPrice,
                             TariffKdvPrice = i.TariffKdvPrice,
                             Cid=i.Cid,

                             };
                return result.ToList();
            }
        }
    }
}
