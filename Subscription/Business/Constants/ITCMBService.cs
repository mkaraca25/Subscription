using Entities.DTOs.TCMB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface ITCMBService
    {
        GetRateResponse ExportTodaysCurrencyRates(GetRateRequest getRateRequest);
    }
}
