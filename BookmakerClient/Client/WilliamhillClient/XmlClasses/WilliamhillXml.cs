using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Client.WilliamhillClient.XmlClasses
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class oxip
    {

        private oxipResponse responseField;

        private decimal versionField;

        private string createdField;

        private string lastMsgIdField;

        private decimal requestTimeField;

        public oxip()
        {
            if (this.responseField == null)
            {
                this.responseField = new oxipResponse();
            }
        }

        /// <remarks/>
        public oxipResponse response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lastMsgId
        {
            get
            {
                return this.lastMsgIdField;
            }
            set
            {
                this.lastMsgIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal requestTime
        {
            get
            {
                return this.requestTimeField;
            }
            set
            {
                this.requestTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponse
    {

        private oxipResponseWilliamhill williamhillField;

        private string requestField;

        private int codeField;

        private string messageField;

        private string debugField;

        private string providerField;

        public oxipResponse()
        {
            if (this.williamhillField == null)
            {
                this.williamhillField = new oxipResponseWilliamhill();
            }
        }

        /// <remarks/>
        public oxipResponseWilliamhill williamhill
        {
            get
            {
                return this.williamhillField;
            }
            set
            {
                this.williamhillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string debug
        {
            get
            {
                return this.debugField;
            }
            set
            {
                this.debugField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponseWilliamhill
    {

        private oxipResponseWilliamhillClass classField;

        private string disclaimerField;

        public oxipResponseWilliamhill()
        {
            if (this.classField == null)
            {
                this.classField = new oxipResponseWilliamhillClass();
            }
        }

        /// <remarks/>
        public oxipResponseWilliamhillClass @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        public string disclaimer
        {
            get
            {
                return this.disclaimerField;
            }
            set
            {
                this.disclaimerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponseWilliamhillClass
    {

        private List<oxipResponseWilliamhillClassType> typeField;

        private int idField;

        private string nameField;

        private System.DateTime maxRepDateField;

        private System.DateTime maxRepTimeField;

        public oxipResponseWilliamhillClass()
        {
            if (this.typeField == null)
            {
                this.typeField = new List<oxipResponseWilliamhillClassType>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public List<oxipResponseWilliamhillClassType> type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime maxRepDate
        {
            get
            {
                return this.maxRepDateField;
            }
            set
            {
                this.maxRepDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime maxRepTime
        {
            get
            {
                return this.maxRepTimeField;
            }
            set
            {
                this.maxRepTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponseWilliamhillClassType
    {

        private List<oxipResponseWilliamhillClassTypeMarket> marketField;

        private int idField;

        private string nameField;

        private string urlField;

        private System.DateTime lastUpdateDateField;

        private System.DateTime lastUpdateTimeField;

        public oxipResponseWilliamhillClassType()
        {
            if (this.marketField == null)
            {
                marketField = new List<oxipResponseWilliamhillClassTypeMarket>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("market")]
        public List<oxipResponseWilliamhillClassTypeMarket> market
        {
            get
            {
                return this.marketField;
            }
            set
            {
                this.marketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime lastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime lastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponseWilliamhillClassTypeMarket
    {

        private List<oxipResponseWilliamhillClassTypeMarketParticipant> participantField;
        private int idField;
        private string nameField;
        private string urlField;
        private System.DateTime dateField;
        private System.DateTime timeField;
        private System.DateTime betTillDateField;
        private System.DateTime betTillTimeField;
        private System.DateTime lastUpdateDateField;
        private System.DateTime lastUpdateTimeField;
        private string placeAvailableField;
        private string forcastAvailableField;
        private string tricastAvailableField;
        private string eachwayAvailableField;
        private string cashoutAvailableField;
        private string startingPriceAvailableField;
        private string livePriceAvailableField;
        private string guarenteedPriceAvailableField;
        private string firstPriceAvailableField;
        private int ewPlacesField;
        private bool ewPlacesFieldSpecified;
        private string ewReductionField;

        public oxipResponseWilliamhillClassTypeMarket()
        {
            if (this.participantField == null)
            {
                this.participantField = new List<oxipResponseWilliamhillClassTypeMarketParticipant>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("participant")]
        public List<oxipResponseWilliamhillClassTypeMarketParticipant> participant
        {
            get
            {
                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime betTillDate
        {
            get
            {
                return this.betTillDateField;
            }
            set
            {
                this.betTillDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime betTillTime
        {
            get
            {
                return this.betTillTimeField;
            }
            set
            {
                this.betTillTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime lastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime lastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string placeAvailable
        {
            get
            {
                return this.placeAvailableField;
            }
            set
            {
                this.placeAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string forcastAvailable
        {
            get
            {
                return this.forcastAvailableField;
            }
            set
            {
                this.forcastAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tricastAvailable
        {
            get
            {
                return this.tricastAvailableField;
            }
            set
            {
                this.tricastAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eachwayAvailable
        {
            get
            {
                return this.eachwayAvailableField;
            }
            set
            {
                this.eachwayAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cashoutAvailable
        {
            get
            {
                return this.cashoutAvailableField;
            }
            set
            {
                this.cashoutAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startingPriceAvailable
        {
            get
            {
                return this.startingPriceAvailableField;
            }
            set
            {
                this.startingPriceAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string livePriceAvailable
        {
            get
            {
                return this.livePriceAvailableField;
            }
            set
            {
                this.livePriceAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guarenteedPriceAvailable
        {
            get
            {
                return this.guarenteedPriceAvailableField;
            }
            set
            {
                this.guarenteedPriceAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string firstPriceAvailable
        {
            get
            {
                return this.firstPriceAvailableField;
            }
            set
            {
                this.firstPriceAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ewPlaces
        {
            get
            {
                return this.ewPlacesField;
            }
            set
            {
                this.ewPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ewPlacesSpecified
        {
            get
            {
                return this.ewPlacesFieldSpecified;
            }
            set
            {
                this.ewPlacesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ewReduction
        {
            get
            {
                return this.ewReductionField;
            }
            set
            {
                this.ewReductionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class oxipResponseWilliamhillClassTypeMarketParticipant
    {

        private string nameField;

        private int idField;

        private string oddsField;

        private string oddsDecimalField;

        private System.DateTime lastUpdateDateField;

        private System.DateTime lastUpdateTimeField;

        private string handicapField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string odds
        {
            get
            {
                return this.oddsField;
            }
            set
            {
                this.oddsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string oddsDecimal
        {
            get
            {
                return this.oddsDecimalField;
            }
            set
            {
                this.oddsDecimalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime lastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime lastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handicap
        {
            get
            {
                return this.handicapField;
            }
            set
            {
                this.handicapField = value;
            }
        }
    }

}
