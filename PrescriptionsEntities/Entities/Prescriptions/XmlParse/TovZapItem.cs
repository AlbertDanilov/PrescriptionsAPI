using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sfarm.DAL.Entities.Prescriptions
{
    [XmlRoot(ElementName = "row")]
    public class TovZapItem
    {
        [XmlElement(ElementName = "skladId")]
        public int skladId { get; set; }

        [XmlElement(ElementName = "amount")]
        public decimal amount { get; set; }

        [XmlElement(ElementName = "expirationDate")]
        public DateTime expirationDate { get; set; }

        [XmlElement(ElementName = "doseView")]
        public string doseView { get; set; }

        [XmlElement(ElementName = "mnnCode")]
        public int mnnCode { get; set; }

        [XmlElement(ElementName = "mnnName")]
        public string mnnName { get; set; }

        [XmlElement(ElementName = "trnCode")]
        public int trnCode { get; set; }

        [XmlElement(ElementName = "trnName")]
        public string trnName { get; set; }

        [XmlElement(ElementName = "lfCode")]
        public int lfCode { get; set; }

        [XmlElement(ElementName = "lfName")]
        public string lfName { get; set; }
    }

    [XmlRoot(ElementName = "tovzap")]
    public class TovZap
    {
        [XmlElement(ElementName = "row")]
        public List<TovZapItem> rows { get; set; }
    }
}
