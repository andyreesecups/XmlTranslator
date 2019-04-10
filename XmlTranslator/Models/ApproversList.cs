using System.Xml.Serialization;

namespace XmlTranslator.Models
{
    [XmlRoot(ElementName = "ApproversList")]
    public class ApproversList
    {
        // Item is a collection of ApproversList
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public Item[] Item { get; set; } 
    }
}
