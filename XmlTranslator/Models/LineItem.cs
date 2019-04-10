using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlTranslator.Models
{
    [XmlRoot(ElementName = "LineItems")]
    public class LineItems
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }
}
