using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class IndexCalculationModel:IEntity
    {
        [Key]
        public int Cid { get; set; }
        public DateTime CalculationDate { get; set; }
        public string TariffCurrencyId { get; set; }
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
