using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlTranslator.Models
{
    [XmlRoot(ElementName = "Invoice")]
    public class Invoice
    {
        [XmlElement(ElementName = "History")]
        public List<string> History { get; set; }
        [XmlElement(ElementName = "AlternativePayee")]
        public string AlternativePayee { get; set; }
        [XmlElement(ElementName = "Assignment")]
        public string Assignment { get; set; }
        [XmlElement(ElementName = "BaselineDate")]
        public string BaselineDate { get; set; }
        [XmlElement(ElementName = "BusinessArea")]
        public string BusinessArea { get; set; }
        [XmlElement(ElementName = "CalculateTax")]
        public string CalculateTax { get; set; }
        [XmlElement(ElementName = "CompanyCode")]
        public string CompanyCode { get; set; }
        [XmlElement(ElementName = "DueDate")]
        public string DueDate { get; set; }
        [XmlElement(ElementName = "ERPLinkingDate")]
        public string ERPLinkingDate { get; set; }
        [XmlElement(ElementName = "ERPMMInvoiceNumber")]
        public string ERPMMInvoiceNumber { get; set; }
        [XmlElement(ElementName = "ERPPaymentBlocked")]
        public string ERPPaymentBlocked { get; set; }
        [XmlElement(ElementName = "ERPPostingDate")]
        public string ERPPostingDate { get; set; }
        [XmlElement(ElementName = "ERP")]
        public string ERP { get; set; }
        [XmlElement(ElementName = "ExchangeRate")]
        public string ExchangeRate { get; set; }
        [XmlElement(ElementName = "GRIV")]
        public string GRIV { get; set; }
        [XmlElement(ElementName = "HeaderText")]
        public string HeaderText { get; set; }
        [XmlElement(ElementName = "InvoiceAmount")]
        public string InvoiceAmount { get; set; }
        [XmlElement(ElementName = "InvoiceCurrency")]
        public string InvoiceCurrency { get; set; }
        [XmlElement(ElementName = "InvoiceDate")]
        public string InvoiceDate { get; set; }
        [XmlElement(ElementName = "InvoiceDescription")]
        public string InvoiceDescription { get; set; }
        [XmlElement(ElementName = "InvoiceNumber")]
        public string InvoiceNumber { get; set; }
        [XmlElement(ElementName = "InvoiceReferenceNumber")]
        public string InvoiceReferenceNumber { get; set; }
        [XmlElement(ElementName = "InvoiceType")]
        public string InvoiceType { get; set; }
        [XmlElement(ElementName = "LocalCurrency")]
        public string LocalCurrency { get; set; }
        [XmlElement(ElementName = "LocalInvoiceAmount")]
        public string LocalInvoiceAmount { get; set; }
        [XmlElement(ElementName = "LocalNetAmount")]
        public string LocalNetAmount { get; set; }
        [XmlElement(ElementName = "LocalTaxAmount")]
        public string LocalTaxAmount { get; set; }
        [XmlElement(ElementName = "ManualLink")]
        public string ManualLink { get; set; }
        [XmlElement(ElementName = "NetAmount")]
        public string NetAmount { get; set; }
        [XmlElement(ElementName = "OrderNumber")]
        public string OrderNumber { get; set; }
        [XmlElement(ElementName = "PaymentApprovalStatus")]
        public string PaymentApprovalStatus { get; set; }
        [XmlElement(ElementName = "PaymentTerms")]
        public string PaymentTerms { get; set; }
        [XmlElement(ElementName = "PostingDate")]
        public string PostingDate { get; set; }
        [XmlElement(ElementName = "ReceptionMethod")]
        public string ReceptionMethod { get; set; }
        [XmlElement(ElementName = "SAPPaymentMethod")]
        public string SAPPaymentMethod { get; set; }
        [XmlElement(ElementName = "TaxAmount")]
        public string TaxAmount { get; set; }
        [XmlElement(ElementName = "TouchlessDone")]
        public string TouchlessDone { get; set; }

        [XmlElement(ElementName = "TouchlessEnabled")]
        public string TouchlessEnabled { get; set; }

        [XmlElement(ElementName = "UnplannedDeliveryCosts")]
        public string UnplannedDeliveryCosts { get; set; }

        [XmlElement(ElementName = "VendorCity")]
        public string VendorCity { get; set; }

        [XmlElement(ElementName = "VendorCountry")]
        public string VendorCountry { get; set; }

        [XmlElement(ElementName = "VendorName")]
        public string VendorName { get; set; }

        [XmlElement(ElementName = "VendorNumber")]
        public string VendorNumber { get; set; }

        [XmlElement(ElementName = "VendorRegion")]
        public string VendorRegion { get; set; }

        [XmlElement(ElementName = "VendorStreet")]
        public string VendorStreet { get; set; }

        [XmlElement(ElementName = "VendorZipCode")]
        public string VendorZipCode { get; set; }

        [XmlElement(ElementName = "VerificationDate")]
        public string VerificationDate { get; set; }

        [XmlElement(ElementName = "ApproversList")]
        public List<ApproversList> ApproversList { get; set; }

        [XmlElement(ElementName = "LineItems")]
        public List<LineItems> LineItems { get; set; }

        [XmlElement(ElementName = "InvoiceDocumentURL")]
        public string InvoiceDocumentURL { get; set; }

        [XmlElement(ElementName = "InvoiceImageURL")]
        public string InvoiceImageURL { get; set; }
        [XmlAttribute(AttributeName = "RUID")]
        public string RUID { get; set; }

    }
}
