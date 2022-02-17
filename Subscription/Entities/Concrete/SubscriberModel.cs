
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    
    public class SubscriberModel:IEntity
    {
        [Key]
        public int SubscriberId { get; set; }
        public int Id { get; set; }
        public int SubscriberNo { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Address { get; set; }
        public string AdSoyad { get; set; }
        public string TariffCurrencyId { get; set; }
        public int KdvRateId { get; set; }
    }
}
