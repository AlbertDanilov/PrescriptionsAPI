using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sfarm.DAL.Entities.Prescriptions
{
    [XmlRoot(ElementName = "row")]
    public class SkladItem
    {
        [XmlElement(ElementName = "skladId")]
        public string SkladId { get; set; }

        [XmlElement(ElementName = "parentSkladId")]
        public string ParentSkladId { get; set; }

        [XmlElement(ElementName = "skladName")]
        public string SkladName { get; set; }
    }

    [XmlRoot(ElementName = "sklads")]
    public class Sklads
    {
        [XmlElement(ElementName = "row")]
        public List<SkladItem> rows { get; set; }
    }
}
