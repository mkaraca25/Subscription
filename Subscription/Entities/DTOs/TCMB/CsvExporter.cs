using CsvHelper;
using Microsoft.SqlServer.Dac.Extensibility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TCMB
{
    internal class CsvExporter : IExportable
    {
        public IExportableMetadata Metadata { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDependencyManager DependencyManager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ExportableStatus Status => throw new NotImplementedException();

        /// <param name="rates"></param>
        /// <param name="path"></param>
        public void Export(List<Rate> rates, string path)
        {
            using var writer = new StreamWriter(path);

            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csv.WriteRecords((IEnumerable)rates);
        }
    }
}
