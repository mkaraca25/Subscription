using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TCMB
{
    public class GetRateResponse
    {
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public string ExportedPath { get; set; }
    }
}
