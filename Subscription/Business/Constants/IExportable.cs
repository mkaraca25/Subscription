using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface IExportable
    {
        void Export(List<Rate> rates, string path);
    }
}
