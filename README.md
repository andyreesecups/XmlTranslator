This is a prototype of an integration where I receive an XML document, deserialize and store it into an object, and insert some of those properties into a database. The XML document represents an invoice that is posted in an order management software and is then inserted into an ERP.

The XML file being Deserialized is below:
```xml
<?xml version="1.0" encoding="UTF-8"?>
<Invoice CUID="CD#RPOR12941.13031">
    <History>04/11/2016 11:59:24 - Payment approval requested by Jerry Smith
04/11/2016 11:59:44 - Approved by Gayle Johnson
04/11/2016 11:59:54 - Validated by Clyde Williams</History>
    <AlternativePayee></AlternativePayee>
    <Assignment></Assignment>
    <BaselineDate></BaselineDate>
    <BusinessArea></BusinessArea>
    <CalculateTax>0</CalculateTax>
    <CompanyCode>TMW</CompanyCode>
    <DueDate>2016-04-18</DueDate>
    <ERPLinkingDate>2016-04-11</ERPLinkingDate>
    <ERPMMInvoiceNumber></ERPMMInvoiceNumber>
    <ERPPaymentBlocked></ERPPaymentBlocked>
    <ERPPostingDate>2016-04-11</ERPPostingDate>
    <ERP>Generic</ERP>
    <ExchangeRate>0.8938</ExchangeRate>
    <GRIV>0</GRIV>
    <HeaderText>0</HeaderText>
    <History>0</History>
    <InvoiceAmount>110</InvoiceAmount>
    <InvoiceCurrency>USD</InvoiceCurrency>
    <InvoiceDate>2016-01-23</InvoiceDate>
    <InvoiceDescription></InvoiceDescription>
    <InvoiceNumber>180925</InvoiceNumber>
    <InvoiceReferenceNumber></InvoiceReferenceNumber>
    <InvoiceType>Non-PO Invoice</InvoiceType>
    <LocalCurrency>EUR</LocalCurrency>
    <LocalInvoiceAmount>98.32</LocalInvoiceAmount>
    <LocalNetAmount>89.38</LocalNetAmount>
    <LocalTaxAmount>8.94</LocalTaxAmount>
    <ManualLink>0</ManualLink>
    <NetAmount>100</NetAmount>
    <OrderNumber></OrderNumber>
    <PaymentApprovalStatus>Approved</PaymentApprovalStatus>
    <PaymentTerms>N30</PaymentTerms>
    <PostingDate>2016-04-11</PostingDate>
    <ReceptionMethod>Scan/Other</ReceptionMethod>
    <SAPPaymentMethod></SAPPaymentMethod>
    <TaxAmount>10</TaxAmount>
    <UnplannedDeliveryCosts>0</UnplannedDeliveryCosts>
    <VendorCity>New Orleans</VendorCity>
    <VendorCountry>US</VendorCountry>
    <VendorName>Grounders</VendorName>
    <VendorNumber>01905382</VendorNumber>
    <VendorRegion>LA</VendorRegion>
    <VendorStreet>12002 St. Charles St.</VendorStreet>
    <VendorZipCode>48563</VendorZipCode>
    <VerificationDate>2016-04-11</VerificationDate>
    <ApproversList>
        <item>
            <ApprovalDate>2016-04-11</ApprovalDate>
            <Approved>1</Approved>
            <ApproverComment>The amount is correct.</ApproverComment>
            <ApproverEmail>csmith@example.com</ApproverEmail>
            <ApproverID>csmith@example.com</ApproverID>
            <ApproverLabelRole>Approbateur</ApproverLabelRole>
            <Approver>Clyde Smith</Approver>
        </item>
    </ApproversList>
    <LineItems>
        <item>
            <Amount>100</Amount>
            <Assignment></Assignment>
            <BusinessArea></BusinessArea>
            <CCDescription>CCdesc</CCDescription>
            <CostCenter>ANCILLCC</CostCenter>
            <Description>desc</Description>
            <GLAccount>1120</GLAccount>
            <GLDescription>GLdesc</GLDescription>
            <InternalOrder></InternalOrder>
            <LineType>GL</LineType>
            <TaxAmount>10</TaxAmount>
            <TaxCode>VAT10</TaxCode>
            <TaxJurisdiction></TaxJurisdiction>
            <TaxRate>10</TaxRate>
        </item>
    </LineItems>
    <InvoiceDocumentURL>http://127.0.0.1:80/ondemand/ManageDocumentsCheck.link?ruid=
CD.13031</InvoiceDocumentURL>
    <InvoiceImageURL>http://127.0.0.1:80/ondemand/attach.file?id=CD.13031
    </InvoiceImageURL>
</Invoice>
```

If InsertDataToDatabase is successful then it will send a successful XML Acknowledgment using XmlWriter:
```xml
<?xml version="1.0" encoding="UTF-8"?>
<ERPack>
   <EskerInvoiceID>CD#RPOR12941.13031</EskerInvoiceID>
   <ERPID>180925</ERPID>
</ERPack>
```

If InsertDataToDatabase fails then it will send a failed XML Acknowledgment using XmlWriter:
```xml
<?xml version="1.0" encoding="UTF-8"?>
<ERPack>
   <EskerInvoiceID>CD#RPOR12941.13031</EskerInvoiceID>
   <ERPPostingError>ERP Error</ERPPostingError>
</ERPack>
```

