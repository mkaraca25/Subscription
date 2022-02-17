using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SubscriberModelDto:IDto
    {
        public int SubscriberId { get; set; }
        public int Id { get; set; }
        public int SubscriberNo { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Address { get; set; }
        public string AdSoyad { get; set; }
        public string TariffCurrencyId { get; set; }
        public int KdvRateId { get; set; }
        public int Cid { get; set; }
        public DateTime CalculationDate { get; set; }
        public int IndexKdvRateId { get; set; }
        public int TariffUnitPrice { get; set; }
        public Boolean CalculationType { get; set; }
        public int FirstIndex { get; set; }
        public int LastIndex { get; set; }
        public double Consumption { get; set; }
        public double TariffTotalPrice { get; set; }
        public double TariffKdvPrice { get; set; }
    }
}
