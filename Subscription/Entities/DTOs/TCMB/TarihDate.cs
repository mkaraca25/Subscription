using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TCMB
{
    public class TarihDate
    {
        private Tarih_DateCurrency[] currencyField;

        private string tarihField;

        private string dateField;

        private string bulten_NoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Currency")]
        public Tarih_DateCurrency[] Currency
        {
            get => this.currencyField;
            set => this.currencyField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tarih
        {
            get => this.tarihField;
            set => this.tarihField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get => this.dateField;
            set => this.dateField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Bulten_No
        {
            get => this.bulten_NoField;
            set => this.bulten_NoField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Tarih_DateCurrency
    {

        private byte unitField;

        private string isimField;

        private string currencyNameField;

        private decimal forexBuyingField;

        private string forexSellingField;

        private string banknoteBuyingField;

        private string banknoteSellingField;

        private string crossRateUSDField;

        private string crossRateOtherField;

        private byte crossOrderField;

        private string kodField;

        private string currencyCodeField;

        /// <remarks/>
        public byte Unit
        {
            get => this.unitField;
            set => this.unitField = value;
        }

        /// <remarks/>
        public string Isim
        {
            get => this.isimField;
            set => this.isimField = value;
        }

        /// <remarks/>
        public string CurrencyName
        {
            get => this.currencyNameField;
            set => this.currencyNameField = value;
        }

        /// <remarks/>
        public decimal ForexBuying
        {
            get => this.forexBuyingField;
            set => this.forexBuyingField = value;
        }

        /// <remarks/>
        public string ForexSelling
        {
            get => this.forexSellingField;
            set => this.forexSellingField = value;
        }

        /// <remarks/>
        public string BanknoteBuying
        {
            get => this.banknoteBuyingField;
            set => this.banknoteBuyingField = value;
        }

        /// <remarks/>
        public string BanknoteSelling
        {
            get => this.banknoteSellingField;
            set => this.banknoteSellingField = value;
        }

        /// <remarks/>
        public string CrossRateUSD
        {
            get => this.crossRateUSDField;
            set => this.crossRateUSDField = value;
        }

        /// <remarks/>
        public string CrossRateOther
        {
            get => this.crossRateOtherField;
            set => this.crossRateOtherField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CrossOrder
        {
            get => this.crossOrderField;
            set => this.crossOrderField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod
        {
            get => this.kodField;
            set => this.kodField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get => this.currencyCodeField;
            set => this.currencyCodeField = value;
        }
    }
}

