using Business.Constants;
using Entities.DTOs.TCMB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Business.Abstract
{
    public class TCMBService : ITCMBService
    {
        /// <summary>
        /// Fetch TCMB Today's Currency Rates with GetRateRequest Object.
        /// </summary>
        /// <param name="rateRequest">GetRateRequest</param>
        /// <returns>GetRateResponse</returns>
        public GetRateResponse ExportTodaysCurrencyRates(GetRateRequest rateRequest)
        {
            var getRateResponse = new GetRateResponse();

            const string tcmbTodayUrl = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var tcmbXmlDoc = new XmlDocument();

            try
            {
                // Get Rates from TCMB and Load as XmlDocument.
                tcmbXmlDoc.Load(tcmbTodayUrl);

                using var stringReader = new StringReader(tcmbXmlDoc.InnerXml);

                var serializer = new XmlSerializer(typeof(TarihDate));

                // Deserialize Xml response to TCMB proxy class.
                var ratesDeserialized = (TarihDate)serializer.Deserialize(stringReader);

                // Generate IQueryable Rates From Deserialized Response.
                var rates = TCMBServiceHelpers.GenerateRatesFromDeserializedResponse(ratesDeserialized);

                // Aggregated list for filters & orders.
                var filteredAndOrderedRates = new List<Rate>();

                // Check filter options.
                if (rateRequest.FilterByOptions != null)
                {
                    foreach (FilterByOption filterByOption in rateRequest.FilterByOptions)
                    {
                        filteredAndOrderedRates.AddRange(TCMBServiceHelpers.ApplyFilterBy(rates, filterByOption.Field, filterByOption.Value).ToList());
                    }
                }

                // Check order options
                if (rateRequest.OrderByOptions != null)
                {
                    foreach (OrderByOption orderByOption in rateRequest.OrderByOptions)
                    {
                        filteredAndOrderedRates = orderByOption.OrderType switch
                        {
                            OrderType.Ascending => TCMBServiceHelpers.ApplyOrderByAscending(filteredAndOrderedRates.AsQueryable(), orderByOption.Field).ToList(),
                            OrderType.Descending => TCMBServiceHelpers.ApplyOrderByDescending(filteredAndOrderedRates.AsQueryable(), orderByOption.Field).ToList(),
                            _ => TCMBServiceHelpers.ApplyOrderByAscending(filteredAndOrderedRates.AsQueryable(), orderByOption.Field).ToList()
                        };
                    }
                }

                // For the sake of simlicity it exports to current application's running directory.
                // Can be converted to parameter like path which can be taken at RateRequest object.
                var exportPath = Directory.GetCurrentDirectory() + $"\\Rates_of_{DateTime.Today:dd_MM_yyyy}";

                // Check export type and create Exporter.
                //IExportable exporter = ExporterFactory.CreatExporter(rateRequest.ExportType);

                // Do export.
                //exporter.Export(filteredAndOrderedRates, exportPath + $".{rateRequest.ExportType.ToString().ToLowerInvariant()}");

                // Add exported path to GetRateResponse.
                getRateResponse.ExportedPath = exportPath;
            }
            catch (Exception e)
            {
                // Handle Exception
                getRateResponse.HasError = true;
                getRateResponse.ErrorMessage = e.Message;
            }

            return getRateResponse;
        }
    }
}
