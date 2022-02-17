using Entities.DTOs.TCMB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal static class TCMBServiceHelpers
    {
        /// <param name="query"></param>
        /// <param name="property"></param>
        /// <returns>IQueryable&lt;Rate&gt;</returns>
        public static IQueryable<Rate> ApplyOrderByAscending(IQueryable<Rate> query, string property)
        {
            return property switch
            {
                "CurrencyCode" => query.OrderBy(p => p.CurrencyCode),
                "CurrencyName" => query.OrderBy(p => p.CurrencyName),
                "BanknoteBuying" => query.OrderBy(p => p.BanknoteBuying),
                "BanknoteSelling" => query.OrderBy(p => p.BanknoteSelling),
                "ForexBuying" => query.OrderBy(p => p.ForexBuying),
                "ForexSelling" => query.OrderBy(p => p.ForexSelling),
                _ => query
            };
        }

        /// <summary>
        /// Applies order by descending with given property name.
        /// Avaliable Property Names: CurrencyCode, CurrencyName, BanknoteBuying, BanknoteSelling, ForexBuying, ForexSelling.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="property"></param>
        /// <returns>IQueryable&lt;Rate&gt;</returns>
        public static IQueryable<Rate> ApplyOrderByDescending(IQueryable<Rate> query, string property)
        {
            return property switch
            {
                "CurrencyCode" => query.OrderByDescending(p => p.CurrencyCode),
                "CurrencyName" => query.OrderByDescending(p => p.CurrencyName),
                "BanknoteBuying" => query.OrderByDescending(p => p.BanknoteBuying),
                "BanknoteSelling" => query.OrderByDescending(p => p.BanknoteSelling),
                "ForexBuying" => query.OrderByDescending(p => p.ForexBuying),
                "ForexSelling" => query.OrderByDescending(p => p.ForexSelling),
                _ => query
            };
        }

        /// <summary>
        /// Applies filter with given property name and value.
        /// Avaliable Property Names: CurrencyCode, CurrencyName.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns>IQueryable&lt;Rate&gt;</returns>
        public static IQueryable<Rate> ApplyFilterBy(IQueryable<Rate> query, string property, object value)
        {
            return property switch
            {
                "CurrencyCode" => query.Where(p => p.CurrencyCode.Contains(value.ToString())),
                "CurrencyName" => query.Where(p => p.CurrencyName.Contains(value.ToString())),
                _ => query
            };
        }
        /// <param name="ratesDeserialized"></param>
        /// <returns>IQueryable&lt;Rate&gt;</returns>
        public static IQueryable<Rate> GenerateRatesFromDeserializedResponse(TarihDate ratesDeserialized)
        {
            return ratesDeserialized.Currency.Select(currency => new Rate
            {
                CurrencyCode = currency.CurrencyCode,
                CurrencyName = currency.CurrencyName,
                Unit = currency.Unit,
                BanknoteSelling = GetParsedRateAmount(currency.BanknoteSelling),
                BanknoteBuying = GetParsedRateAmount(currency.BanknoteBuying),
                ForexBuying = currency.ForexBuying,
                ForexSelling = GetParsedRateAmount(currency.ForexSelling),
            }).AsQueryable();
        }

        /// <summary>
        /// Parse string value to decimal with DecimalDigits = 2, DecimalSeparator = ".", NumberGroupSeparator = ","
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>decimal</returns>
        public static decimal GetParsedRateAmount(string amount)
        {
            decimal.TryParse(amount, NumberStyles.Any, new NumberFormatInfo { CurrencyDecimalDigits = 2, CurrencyDecimalSeparator = ".", NumberGroupSeparator = "," }, out var amountInDecimal);

            return amountInDecimal;
        }
    }
}
