using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TCMB
{
    public class GetRateRequest
    {
        public ExportType ExportType { get; set; }
        public List<OrderByOption> OrderByOptions { get; set; }
        public List<FilterByOption> FilterByOptions { get; set; }
    }
}
