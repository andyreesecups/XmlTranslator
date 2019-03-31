using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTranslator.Models
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "ApprovalDate")]
        public string ApprovalDate { get; set; }
        [XmlElement(ElementName = "Approved")]
        public string Approved { get; set; }
        [XmlElement(ElementName = "ApproverComment")]
        public string ApproverComment { get; set; }
        [XmlElement(ElementName = "ApproverEmail")]
        public string ApproverEmail { get; set; }
        [XmlElement(ElementName = "ApproverID")]
        public string ApproverID { get; set; }
        [XmlElement(ElementName = "ApproverLabelRole")]
        public string ApproverLabelRole { get; set; }
        [XmlElement(ElementName = "Approver")]
        public string Approver { get; set; }
        [XmlElement(ElementName = "Amount")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "Assignment")]
        public string Assignment { get; set; }
        [XmlElement(ElementName = "BusinessArea")]
        public string BusinessArea { get; set; }
        [XmlElement(ElementName = "CCDescription")]
        public string CCDescription { get; set; }
        [XmlElement(ElementName = "CostCenter")]
        public string CostCenter { get; set; }
        [XmlElement(ElementName = "DeliveryNote")]
        public string DeliveryNote { get; set; }
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "GLAccount")]
        public string GLAccount { get; set; }
        [XmlElement(ElementName = "GLDescription")]
        public string GLDescription { get; set; }
        [XmlElement(ElementName = "GoodReceipt")]
        public string GoodReceipt { get; set; }
        [XmlElement(ElementName = "InternalOrder")]
        public string InternalOrder { get; set; }
        [XmlElement(ElementName = "ItemNumber")]
        public string ItemNumber { get; set; }
        [XmlElement(ElementName = "LineType")]
        public string LineType { get; set; }
        [XmlElement(ElementName = "OrderNumber")]
        public string OrderNumber { get; set; }
        [XmlElement(ElementName = "Quantity")]
        public string Quantity { get; set; }
        [XmlElement(ElementName = "TaxAmount")]
        public string TaxAmount { get; set; }
        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }
        [XmlElement(ElementName = "TaxJurisdiction")]
        public string TaxJurisdiction { get; set; }
        [XmlElement(ElementName = "TaxRate")]
        public string TaxRate { get; set; }
    }
}
